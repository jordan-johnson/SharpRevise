using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using SharpRevise.View.Interface;
using SharpRevise.Model;
using SharpRevise.View;

namespace SharpRevise.Presenter {
	public class TrayFormPresenter {
		private ITrayFormView _view;
		private TrayFormModel _model;

		public void Create(List<string> categories) {
			_model = new TrayFormModel();
			_model.Categories = categories;

			_view = new TrayForm();
			_view.Presenter = this;

			_view.Show();
			_view.Activate();

			setupCategories();
			setFormStyling();
		}

		public void Toggle(List<string> categories) {
			if(_view != null) {
				if(_view.Visible) {
					_view.Close();

					return;
				}
			}

			Create(categories);
		}

		public void setFormStyling() {
			if(_view != null) {
				setPosition();

				_view.MaximizeBox = false;
			}
		}

		private void setPosition() {
			_view.StartPosition = FormStartPosition.Manual;

			int xOffset = Screen.PrimaryScreen.WorkingArea.Width - _view.Width;
			int yOffset = Screen.PrimaryScreen.WorkingArea.Height - _view.Height;
			
			_view.Location = new Point(xOffset, yOffset);
		}

		private void setupCategories() {
			foreach(string category in _model.Categories) {
				_view.Categories.Add(category);
			}

			_view.CategoryIndex = 0;
		}
	}
}
