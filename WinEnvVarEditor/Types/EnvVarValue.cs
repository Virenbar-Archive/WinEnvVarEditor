using System;

namespace WinEnvVarEditor.Types
{
	internal class EnvVarValue

	{
		private string _value;

		public EnvVarValue()
		{
			State = State.Added;
		}

		public EnvVarValue(string Value)
		{
			this.Value = Value;
			State = State.NotChanged;
		}

		public State State { get; private set; }

		public string Value
		{
			get => _value;
			set
			{
				if (value != _value)
				{
					_value = value;
					if (State == State.NotChanged) { State = State.Changed; }
					OnValueChanged();
				}
			}
		}

		public void SetDeleted()
		{
			State = State.Deleted;
			OnValueChanged();
		}

		public override string ToString()
		{
			return Value;
		}

		#region Events

		protected void OnValueChanged()
		{
			ValueChanged?.Invoke(this, EventArgs.Empty);
		}

		public event EventHandler ValueChanged;

		#endregion Events
	}
}