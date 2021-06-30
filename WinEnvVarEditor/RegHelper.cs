using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;

namespace WinEnvVarEditor
{
	internal class RegHelper
	{
		public List<EnvVar> GetSystemVars()
		{
			return GetVars(GetSystemTree());
		}

		public List<EnvVar> GetUserVars()
		{
			return GetVars(GetUserTree());
		}

		public bool SaveVar(EnvVar Var)
		{
			return false;
		}

		private List<EnvVar> GetVars(RegistryKey RK)
		{
			var Names = RK.GetValueNames();
			var t = Names.Select(n => new EnvVar(n, (string)RK.GetValue(n), RK.GetValueKind(n))).ToList();
			return t;
		}

		private RegistryKey GetSystemTree()
		{
			return Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment");
		}

		private RegistryKey GetUserTree()
		{
			return Registry.CurrentUser.OpenSubKey("Environment");
		}
	}
}