using System.Windows.Forms;
using SharpRevise.View.Interface;

namespace SharpRevise.View {
	public partial class MainForm : Form, IMainFormView {
		/// <summary>
		/// Treeview for categories and comments
		/// </summary>
		public TreeView SortTree {
			get {
				return sortTree;
			}
		}

		/// <summary>
		/// Gives access to hotkey-assigner field
		/// </summary>
		public TextBox HotkeyField {
			get {
				return keyListenField;
			}
		}

		/// <summary>
		/// Gives access to hotkey-assigner button
		/// </summary>
		public Button HotkeyButton {
			get {
				return buttonKeyListen;
			}
		}

		/// <summary>
		/// View's presenter
		/// </summary>
		public Presenter.MainFormPresenter Presenter {private get; set;}

		/// <summary>
		/// Main form constructor initializes WinForms
		/// </summary>
		public MainForm() {
			InitializeComponent();
		}

		/// <summary>
		/// On close, clean up global hotkey
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void formClosingEvent(object sender, FormClosingEventArgs e) {
			Presenter.DeregisterHotkey();
		}

		/// <summary>
		/// On-click event for Build Changelog menu option
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buildChangelogMenuEvent(object sender, System.EventArgs e) {
			Presenter.BuildChangelog();
		}
	}
}
