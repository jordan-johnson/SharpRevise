using System.Windows.Forms;

namespace SharpRevise.View.Interface {
	public interface IMainFormView {
		TextBox HotkeyField {get;}
		Button HotkeyButton {get;}
		TreeView SortTree {get;}

		FormStartPosition StartPosition {get;set;}
		bool MaximizeBox {get;set;}

		Presenter.MainFormPresenter Presenter {set;}
	}
}
