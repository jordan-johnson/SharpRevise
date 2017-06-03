using SharpRevise.Properties;
using System;
using System.Windows.Forms;

namespace SharpRevise.Model {
	public class SystemTray {
		private NotifyIcon _icon;

		public SystemTray() {
			_icon = new NotifyIcon();

			_icon.Icon = Resources.Icon;

			_icon.Visible = true;

			_icon.Click += new EventHandler(iconClickEvent);
		}

		~SystemTray() {
			_icon.Visible = false;
		}

		public void Toggle() {
			_icon.Visible = !_icon.Visible;

			if(_icon.Visible) {

			}
		}

		private void iconClickEvent(object sender, EventArgs e) {
			MessageBox.Show("yay");
		}
	}
}
