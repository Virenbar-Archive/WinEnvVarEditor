using Microsoft.Win32;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WinEnvVarEditor
{
	internal class EnvVar
	{
		private readonly List<EnvVarValue> values;
		private RegistryValueKind kind;

		public EnvVar() : this("NewVar", "") { }

		public EnvVar(string Name, string Value) : this(Name, Value, RegistryValueKind.String) { }

		public EnvVar(string Name, string Value, RegistryValueKind RVK)
		{
			this.Name = Name;
			values = Value.Split(';').Select(s => new EnvVarValue(s)).ToList();
			kind = RVK;
		}

		public bool IsExpand
		{
			get => kind == RegistryValueKind.ExpandString;
			set => kind = value ? RegistryValueKind.ExpandString : RegistryValueKind.String;
		}

		public string Name { get; }
		public string Value => string.Join(";", Values);
		public ReadOnlyCollection<EnvVarValue> Values => values.AsReadOnly();

		public override string ToString()
		{
			return $"{Name}: {Value}";
		}
	}
}