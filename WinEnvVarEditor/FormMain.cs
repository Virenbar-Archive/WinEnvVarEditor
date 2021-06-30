using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEnvVarEditor
{
	public partial class FormMain : Form
	{
		private RegHelper RH = new RegHelper();
		private EnvVar CurrentVar;

		public FormMain()
		{
			InitializeComponent();
		}

		private void TV_User_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var N = e.Node.Tag;
			CurrentVar = N is EnvVar ? (EnvVar)e.Node.Tag : (EnvVar)e.Node.Parent.Tag;
		}

		private void UpdateTree(TreeView Tree, List<EnvVar> Vars)
		{
			Tree.BeginUpdate();
			Tree.Nodes.Clear();
			foreach (var Var in Vars)
			{
				var VarNode = new TreeNode(Var.Name)
				{
					ImageIndex = Var.IsExpand ? 1 : 0,
					Tag = Var
				};
				if (Var.Values.Count > 1)
				{
					VarNode.Text += " (...)";
					VarNode.Nodes.AddRange(Var.Values.Select(V => new TreeNode(V.Value) { Tag = V }).ToArray());
				}
				else
				{
					VarNode.Text += $": {Var.Value}";
				}
				Tree.Nodes.Add(VarNode);
			}

			Tree.EndUpdate();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void RefreshData()
		{
			var e1 = RH.GetUserVars();
			var e2 = RH.GetSystemVars();

			UpdateTree(TV_User, e1);
			UpdateTree(TV_System, e2);
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void MI_About_Click(object sender, EventArgs e)
		{
			var F = new FormAboutBox();
			F.ShowDialog(this);
		}
	}
}