using System.Windows.Forms;

namespace SharpRevise.Kernel {
	public class Bootstrap {
		private Model.MainFormModel _model;
		private View.MainForm _view;

		public Bootstrap() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			_model = new Model.MainFormModel();
			_view = new View.MainForm();

			var presenter = new Presenter.MainFormPresenter(_view, _model);
		}

		public void Run() {
			Application.Run(_view);
		}
	}
}
