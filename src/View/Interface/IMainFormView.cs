using System.Windows.Forms;

namespace SharpRevise.View.Interface {
	public interface IMainFormView {
		string HotkeyField {get;set;}
		string HotkeyButton {get;set;}

		Presenter.MainFormPresenter Presenter {set;}

		void HotkeyFieldFocus();
	}
}
