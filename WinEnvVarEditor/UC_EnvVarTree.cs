using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinEnvVarEditor.Types;

namespace WinEnvVarEditor
{
	internal partial class UC_EnvVarTree : UserControl
	{
		private static ImageList IL = new ImageList();
		private EnvVarStore _store;

		static UC_EnvVarTree()
		{
			IL.Images.Add(FugueIcons.TagLabelGreen);
			IL.Images.Add(FugueIcons.TagLabelYellow);
			IL.Images.Add(FugueIcons.Bookmark);
		}

		public UC_EnvVarTree()
		{
			InitializeComponent();
			TV.ImageList = IL;
			TV.ImageIndex = (int)ImageKey.String;
			TV.SelectedImageIndex = (int)ImageKey.String;
		}

		public EnvVarValue CurrentValue => TV.SelectedNode?.Tag is EnvVarValue ? (EnvVarValue)TV.SelectedNode.Tag : null;
		public EnvVar CurrentVar => TV.SelectedNode?.Tag is EnvVar ? (EnvVar)TV.SelectedNode?.Tag : (EnvVar)TV.SelectedNode?.Parent.Tag;

		public EnvVarStore Store => _store;

		public void SetStore(EnvVarStore EVS)
		{
			if (_store != null) { _store.StoreChanged -= StoreChanged; }
			_store = EVS;
			_store.StoreChanged += StoreChanged;
			RefreshUI();
		}

		private void RefreshData() { _store?.Refresh(); }

		private void RefreshUI()
		{
			if (_store == null) { return; }
			UpdateTree();
			FLP_Buttons.Enabled = _store.HasChanges;
			OnSelectionChanged();
		}

		private void UpdateTree()
		{
			TV.BeginUpdate();
			var OldNOdes = new HashSet<string>(TV.Nodes.Cast<TreeNode>().Where(N => N.IsExpanded).Select(N => N.Name));
			TV.Nodes.Clear();
			foreach (var Var in _store.Variables)
			{
				var VarNode = ToNode(Var);
				TV.Nodes.Add(VarNode);
				if (OldNOdes.Contains(VarNode.Name)) { VarNode.Expand(); }
			}
			TV.EndUpdate();
		}

		private enum ImageKey : int
		{
			String = 0,
			ExString = 1,
			Value = 2
		}

		#region Static

		private static TreeNode ToNode(EnvVarValue EVV)
		{
			var TN = new TreeNode(EVV.Value)
			{
				Tag = EVV,
				ImageIndex = (int)ImageKey.Value,
				SelectedImageIndex = (int)ImageKey.Value,
				ForeColor = EVV.State.ToColor()
			};
			TN.ApplyStyle(EVV.State);
			return TN;
		}

		private static TreeNode ToNode(EnvVar EV)
		{
			var II = (int)(EV.IsExpand ? ImageKey.ExString : ImageKey.String);
			var TN = new TreeNode(EV.Name)
			{
				Name = EV.Name,
				Tag = EV,
				ImageIndex = II,
				SelectedImageIndex = II
			};
			TN.ApplyStyle(EV.State);
			if (EV.Values.Count > 1)
			{
				TN.Text += " (...)";
				TN.Nodes.AddRange(EV.Values.Select(ToNode).ToArray());
			}
			else
			{
				TN.Text += $": {EV.Value}";
			}
			return TN;
		}

		#endregion Static

		#region UIEvents

		private void B_Apply_Click(object sender, EventArgs e)
		{
			_store.SaveChanges();
		}

		private void B_Cancel_Click(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void B_Refresh_Click(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void StoreChanged(object sender, EventArgs e)
		{
			RefreshUI();
		}

		private void TV_AfterSelect(object sender, TreeViewEventArgs e) { OnSelectionChanged(); }

		#endregion UIEvents

		#region Events

		protected void OnSelectionChanged()
		{
			SelectionChanged?.Invoke(this, EventArgs.Empty);
		}

		public event EventHandler SelectionChanged;

		#endregion Events
	}
}