using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WinEnvVarEditor.Types
{
	internal class EnvVarStore //: ObservableCollection<EnvVar>//, IEnumerable
	{
		private const string SystemTree = "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment";
		private const string UserTree = "Environment";
		private readonly string _path;
		private readonly RegistryKey _registry;
		private List<EnvVar> _variables = new List<EnvVar>();

		private EnvVarStore(RegistryKey RK, string Path)
		{
			_registry = RK;
			_path = Path;
		}

		public IEnumerable<EnvVar> Changes => _variables.Where(V => V.State != State.NotChanged);
		public bool HasChanges => Changes.Count() > 0;
		public IReadOnlyCollection<EnvVar> Variables => _variables.ToList().AsReadOnly();

		public static EnvVarStore GetSystemTree()
		{
			return new EnvVarStore(Registry.LocalMachine, SystemTree);
		}

		public static EnvVarStore GetUserTree()
		{
			return new EnvVarStore(Registry.CurrentUser, UserTree);
		}

		public void AddVariable(EnvVar Var)
		{
			_variables.Add(Var);
			Var.VariableChanged += VariableChanged;
			OnStoreChanged();
		}

		public void Refresh()
		{
			_variables.ForEach((V) => V.VariableChanged -= VariableChanged);
			_variables.Clear();
			using (var R = _registry.OpenSubKey(_path))
			{
				var Names = R.GetValueNames();
				Array.ForEach(Names, N =>
				{
					var Var = new EnvVar(N, (string)R.GetValue(N), R.GetValueKind(N));
					Var.VariableChanged += VariableChanged;
					_variables.Add(Var);
				});
				//_variables.AddRange(Names.Select(n => new EnvVar(n, (string)R.GetValue(n), R.GetValueKind(n))));
			}
			OnStoreChanged();
		}

		public void SaveChanges()
		{
			using (var R = _registry.OpenSubKey(_path, true))
			{
				var Vars = Changes;
				foreach (var Var in Vars)
				{
					if (Var.State == State.Deleted)
					{
						R.DeleteValue(Var.Name);
					}
					else
					{
						R.SetValue(Var.Name, Var.Value, Var.Kind);
					}
				}
			}
			Refresh();
		}

		#region Events

		protected void OnStoreChanged()
		{
			StoreChanged?.Invoke(this, EventArgs.Empty);
		}

		private void VariableChanged(object sender, EventArgs e)
		{
			OnStoreChanged();
		}

		public event EventHandler StoreChanged;

		#endregion Events
	}
}