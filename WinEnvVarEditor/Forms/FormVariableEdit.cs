using System;
using System.Windows.Forms;
using WinEnvVarEditor.Types;

namespace WinEnvVarEditor
{
	internal partial class FormVariableEdit : Form
	{
		private EnvVar _variable;

		public FormVariableEdit(EnvVar EV)
		{
			InitializeComponent();
			_variable = EV;
			TB_Variable.ReadOnly = EV.State != State.Added;
			//TODO Locale
			TB_Variable.Text = _variable.Name;
			TB_Value.Text = _variable.Value;
		}

		private void B_OK_Click(object sender, EventArgs e)
		{
		}

		private void B_Cancel_Click(object sender, EventArgs e)
		{
		}
	}
}