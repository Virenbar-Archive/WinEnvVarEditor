using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinEnvVarEditor.Types
{
	internal class ObservableObject : INotifyPropertyChanged
	{
		protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}