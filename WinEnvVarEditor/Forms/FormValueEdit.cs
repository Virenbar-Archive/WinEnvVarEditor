using System;
using System.Windows.Forms;
using WinEnvVarEditor.Types;

namespace WinEnvVarEditor
{
	internal partial class FormValueEdit : Form
	{
		private EnvVarValue _value;

		public FormValueEdit(EnvVar Var, EnvVarValue Value)
		{
			InitializeComponent();
			_value = Value;
			//TODO Locale
			TB_Variable.Text = Var.Name;
			TB_Value.Text = Value.Value;
		}

		private void FormValueEdit_Load(object sender, EventArgs e)
		{
		}

		private void B_OK_Click(object sender, EventArgs e)
		{
			_value.Value = TB_Value.Text;
		}

		private void B_Cancel_Click(object sender, EventArgs e)
		{
		}
	}
}