using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using SharpRevise.View;
using SharpRevise.View.Interface;
using SharpRevise.Model;

namespace SharpRevise.Presenter {
	public class MainFormPresenter {
		private IMainFormView _view;
		private MainFormModel _model;

		public MainFormPresenter(IMainFormView view, MainFormModel model) {
			_view = view;
			_view.Presenter = this;
			_model = model;

			_model.TrayForm = new TrayFormPresenter();
		}

		public void CommandAction(int message) {
			if(message == SharpHotkey.Hotkey.Message.Id) {
				_model.TrayForm.Toggle(_model.Settings.Categories);
			}
		}

		public void AddKeyToCommand(Keys key) {
			if(!_model.CurrentKeys.Contains(key) && _model.CurrentKeys.Count < 3) {
				_model.CurrentKeys.Add(key);
			}
		}

		public void ToggleHotkeyListener() {
			_model.AssigningCommand = !_model.AssigningCommand;

			if(_model.AssigningCommand) {
				_view.HotkeyButton = "Listening...";
				_view.HotkeyField = String.Empty;
				_view.HotkeyFieldFocus();

				_model.CurrentKeys = new List<Keys>();
			} else {
				_view.HotkeyButton = "Assign Command";
				_view.HotkeyField = String.Join(" + ", _model.CurrentKeysToString);

				_model.UpdateCommand();
				applyHotkey();
			}
		}

		public void DeregisterHotkey() {
			if(_model.Hotkey != null) {
				_model.Hotkey.Deregister();
			}
		}

		private void applyHotkey() {
			Service.Hotkey.Command command = Service.Hotkey.Separate(_model.CurrentKeysToString);

			Service.Hotkey.AttemptDeregister(_model.Hotkey);

			_model.Hotkey = new SharpHotkey.Hotkey(
				(MainForm)_view,
				command.Standard,
				command.Modifiers
			);
		}
	}
}
