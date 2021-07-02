using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WinEnvVarEditor
{
	internal static class Extensions
	{
		public static void DoubleBuffered(this Control Ctrl, bool setting = true)
		{
			Type CtrlType = Ctrl.GetType();
			PropertyInfo propInfo = CtrlType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			propInfo.SetValue(Ctrl, setting, null);
		}

		public static Color ToColor(this State State)
		{
			switch (State)
			{
				//case State.NotChanged: return Color.White;
				case State.Added: return Color.PaleGreen;
				case State.Changed: return Color.Khaki;
				case State.Deleted: return Color.LightPink;
				default: return Color.Black;
			}
		}

		public static void ApplyStyle(this TreeNode Node, State State)
		{
			Node.ForeColor = State.ToColor();
			Node.NodeFont = new Font(Properties.Settings.Default.Font, State == State.NotChanged ? FontStyle.Regular : FontStyle.Bold);
		}
	}
}