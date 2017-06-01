using System;
using System.Windows.Forms;
using SharpRevise.View.Interface;

namespace SharpRevise.View {
	public partial class MainForm : Form, IMainFormView {
		public string HotkeyField {
			get {
				return this.keyListenField.Text;
			}
			set {
				this.keyListenField.Text = value;
			}
		}

		public string HotkeyButton {
			get {
				return this.buttonKeyListen.Text;
			}
			set {
				this.buttonKeyListen.Text = value;
			}
		}

		public Presenter.MainFormPresenter Presenter {private get; set;}

		public MainForm() {
			InitializeComponent();

			MaximizeBox = false;

			setPosition();
		}

		public void HotkeyFieldFocus() {
			keyListenField.Focus();
		}

		protected override void WndProc(ref Message m) {
			Presenter.CommandAction(m.Msg);

			base.WndProc(ref m);
		}

		private void setPosition() {
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void assignCommandEvent(object sender, EventArgs e) {
			Presenter.ToggleHotkeyListener();
		}

		private void keyListenerDownEvent(object sender, KeyEventArgs e) {
			Presenter.AddKeyToCommand(e.KeyCode);
		}

		private void formClosingEvent(object sender, FormClosingEventArgs e) {
			Presenter.DeregisterHotkey();
		}
	}
}
