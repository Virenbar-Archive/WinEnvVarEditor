using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinEnvVarEditor
{
	internal class EnvVarValue
	{
		public EnvVarValue() : this("") { }

		public EnvVarValue(string Value)
		{
			this.Value = Value;
		}

		public string Value { get; set; }

		public override string ToString()
		{
			return Value;
		}
	}
}