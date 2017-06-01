using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SharpRevise.View.Interface;

namespace SharpRevise.View {
	public partial class TrayForm : Form, ITrayFormView {
		public ComboBox.ObjectCollection Categories {
			get {
				return categoryList.Items;
			}
		}

		public int CategoryIndex {
			get {
				return categoryList.SelectedIndex;
			}
			set {
				categoryList.SelectedIndex = value;
			}
		}

		public Presenter.TrayFormPresenter Presenter {private get; set;}

		public TrayForm() {
			InitializeComponent();
		}
	}
}
