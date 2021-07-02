using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WinEnvVarEditor.Types
{
	internal class EnvVar
	{
		private readonly List<EnvVarValue> _values = new List<EnvVarValue>();
		private string _name;
		private State _state;

		public EnvVar()
		{
			_name = "NewVar";
			_state = State.Added;
			var Value = new EnvVarValue();
			_values.Add(Value);
			Value.ValueChanged += ValueChanged;
			Kind = RegistryValueKind.String;
		}

		public EnvVar(string Name, string Value, RegistryValueKind RVK)
		{
			_name = Name;
			_state = State.NotChanged;
			var Values = Value.Split(';').Select(s => new EnvVarValue(s)).ToArray();
			Array.ForEach(Values, V =>
			{
				_values.Add(V);
				V.ValueChanged += ValueChanged;
			});
			Kind = RVK;
		}

		public bool IsExpand
		{
			get => Kind == RegistryValueKind.ExpandString;
			set
			{
				var k = value ? RegistryValueKind.ExpandString : RegistryValueKind.String;
				Kind = k;
				OnVariableChanged();
			}
		}

		public RegistryValueKind Kind { get; private set; }

		public string Name
		{
			get => _name;
			set
			{
				if (_state == State.Added && value != _name)
				{
					_name = value;
					OnVariableChanged();
				}
			}
		}

		public State State
		{
			get
			{
				if (_state == State.Added | _state == State.Deleted) { return _state; }
				if (_values.Any(V => V.State != State.NotChanged)) { return State.Changed; }
				return _state;
			}
		}

		public string Value => string.Join(";", _values.Where(V => V.State != State.Deleted));

		public ReadOnlyCollection<EnvVarValue> Values => _values.AsReadOnly();

		public void AddValue(EnvVarValue EVV)
		{
			_values.Add(EVV);
			EVV.ValueChanged += ValueChanged;
			OnVariableChanged();
		}

		public void SetDeleted()
		{
			_state = State.Deleted;
			_values.ForEach(V => V.SetDeleted());
			OnVariableChanged();
		}

		public void SetName(string Name)
		{
			if (_state != State.Added) { throw new InvalidOperationException(""); }
			_name = Name;
		}

		public override string ToString()
		{
			return $"{Name}: {Value}";
		}

		#region Events

		protected void OnVariableChanged()
		{
			VariableChanged?.Invoke(this, EventArgs.Empty);
		}

		private void ValueChanged(object sender, EventArgs e)
		{
			OnVariableChanged();
		}

		public event EventHandler VariableChanged;

		#endregion Events
	}
}