using System.Collections.Generic;
using System.Windows.Forms;

namespace SharpRevise.View.Interface {
	public interface ITrayFormView {
		int Width {get;set;}
		int Height {get;set;}
		bool MaximizeBox {get;set;}
		int CategoryIndex {get;set;}
		FormStartPosition StartPosition {get;set;}
		System.Drawing.Point Location {get;set;}
		string Comment {get;}
		string CurrentCategory {get;}

		bool Visible {get;set;}
		void Show();
		void Close();
		void Activate();
		
		ComboBox.ObjectCollection Categories {get;}
		Presenter.TrayFormPresenter Presenter {set;}
	}
}
