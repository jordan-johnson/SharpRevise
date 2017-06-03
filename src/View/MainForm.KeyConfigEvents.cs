using System;
using System.Windows.Forms;

namespace SharpRevise.View {
	partial class MainForm {
		protected override void WndProc(ref Message m) {
			Presenter.CommandAction(m.Msg);

			base.WndProc(ref m);
		}

		private void assignCommandEvent(object sender, EventArgs e) {
			Presenter.ToggleHotkeyListener();
		}

		private void keyListenerDownEvent(object sender, KeyEventArgs e) {
			Presenter.AddKeyToCommand(e.KeyCode);
		}

		private void keyListenerClickEvent(object sender, EventArgs e) {
			Presenter.ToggleHotkeyListener();
		}
	}
}
