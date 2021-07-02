using System;
using System.Windows.Forms;
using WinEnvVarEditor.Locale;
using WinEnvVarEditor.Types;

namespace WinEnvVarEditor
{
	public partial class FormMain : Form
	{
		private UC_EnvVarTree CurrentTree;
		private EnvVarStore SystemStore = EnvVarStore.GetSystemTree();
		private EnvVarStore UserStore = EnvVarStore.GetUserTree();

		public FormMain()
		{
			InitializeComponent();

			UserStore.Refresh();
			EVT_User.SetStore(UserStore);
			EVT_User.SelectionChanged += CurrentTree_SelectionChanged;

			SystemStore.Refresh();
			EVT_System.SetStore(SystemStore);
			EVT_System.SelectionChanged += CurrentTree_SelectionChanged;

			CurrentTree = EVT_User;

			L_Variables.Text = Strings.L_Variables;
			TSB_Add.Text = Strings.B_Add;
			TSB_Edit.Text = Strings.B_Edit;
			TSB_Delete.Text = Strings.B_Delete;

			L_Values.Text = Strings.L_Values;
			TSB_AddV.Text = Strings.B_Add;
			TSB_EditV.Text = Strings.B_Edit;
			TSB_DeleteV.Text = Strings.B_Delete;
		}

		private EnvVarValue CurrentValue => CurrentTree?.CurrentValue;

		private EnvVar CurrentVar => CurrentTree?.CurrentVar;

		private void RefreshUI()
		{
			TS_Main.Enabled = CurrentTree?.Store != null;
			if (!TS_Main.Enabled) { return; }

			var CanEdit = CurrentVar != null && CurrentVar.State != State.Deleted;
			TSB_Edit.Enabled = CanEdit;
			TSB_Delete.Enabled = CanEdit;

			var CanEditV = CurrentValue != null && CurrentValue.State != State.Deleted;
			TSB_AddV.Enabled = CurrentVar != null && CurrentVar.State != State.Deleted;
			TSB_EditV.Enabled = CanEditV;
			TSB_DeleteV.Enabled = CanEditV;
		}

		#region UIEvents

		private void CurrentTree_SelectionChanged(object sender, EventArgs e) { RefreshUI(); }

		private void FormMain_Load(object sender, EventArgs e) { }

		private void MI_About_Click(object sender, EventArgs e) { new FormAboutBox().ShowDialog(this); }

		private void TC_Main_SelectedIndexChanged(object sender, EventArgs e)
		{
			var Tab = TC_Main.SelectedTab.Name;
			if (Tab == TP_User.Name)
			{
				CurrentTree = EVT_User;
			}
			else if (Tab == TP_System.Name)
			{
				CurrentTree = EVT_System;
			}
			else { }
			RefreshUI();
		}

		private void TSB_Add_Click(object sender, EventArgs e)
		{
			var Var = new EnvVar();
			var F = new FormVariableEdit(Var);
			if (F.ShowDialog(this) == DialogResult.OK)
			{
				CurrentTree.Store.AddVariable(Var);
			}
		}

		private void TSB_AddV_Click(object sender, EventArgs e)
		{
			var Value = new EnvVarValue();
			var F = new FormValueEdit(CurrentVar, Value);
			if (F.ShowDialog(this) == DialogResult.OK)
			{
				CurrentVar.AddValue(Value);
			}
		}

		private void TSB_Delete_Click(object sender, EventArgs e) { CurrentVar.SetDeleted(); }

		private void TSB_DeleteV_Click(object sender, EventArgs e) { CurrentValue.SetDeleted(); }

		private void TSB_Edit_Click(object sender, EventArgs e) { new FormVariableEdit(CurrentVar).ShowDialog(this); }

		private void TSB_EditV_Click(object sender, EventArgs e) { new FormValueEdit(CurrentVar, CurrentValue).ShowDialog(this); }

		#endregion UIEvents
	}
}