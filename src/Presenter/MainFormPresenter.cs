using System;
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

			setFormStyling();
			updateSortTree();
			pullSettings();
		}

		/// <summary>
		/// Toggle trayform on hotkey
		/// </summary>
		/// <param name="message"></param>
		public void CommandAction(int message) {
			if(message == SharpHotkey.Hotkey.Message.Id) {
				_model.TrayForm.Toggle(_model.Settings.Categories);
			}
		}

		/// <summary>
		/// If key doesn't exist and doesn't exceed 3 total keys, this method adds it to key list
		/// </summary>
		/// <param name="key"></param>
		public void AddKeyToCommand(Keys key) {
			if(!_model.CurrentKeys.Contains(key) && _model.CurrentKeys.Count < 3) {
				_model.CurrentKeys.Add(key);
			}
		}

		/// <summary>
		/// Toggles hotkey listening
		/// <para>
		///	If assigning, change button label, clear current keys and field, and focus on the field
		///	to start listening for keys
		/// </para>
		/// <para>
		///	If finished assigning, reset button label, display command, and apply the new hotkey
		/// </para>
		/// </summary>
		public void ToggleHotkeyListener() {
			_model.AssigningCommand = !_model.AssigningCommand;

			if(_model.AssigningCommand) {
				_view.HotkeyButton.Text = "Listening...";
				_view.HotkeyField.Text = String.Empty;
				_view.HotkeyField.Focus();

				_model.CurrentKeys = new List<Keys>();
			} else {
				_view.HotkeyButton.Text = "Assign Command";

				_model.UpdateCommand();
				
				updateHotkeyField();

				applyHotkey(Service.Hotkey.Separate(_model.CurrentKeysToString));
			}
		}

		/// <summary>
		/// Deregisters an open hotkey
		/// <para>This method is called in the MainForm closing event</para>
		/// </summary>
		public void DeregisterHotkey() {
			if(_model.Hotkey != null) {
				_model.Hotkey.Deregister();
			}
		}

		/// <summary>
		/// Begins building changelog
		/// </summary>
		public void BuildChangelog() {
			SaveFileDialog dialog = new SaveFileDialog();

			dialog.FileName = "CHANGELOG.md";
			dialog.Filter = "Markdown files (*.md) | *.md";

			if(dialog.ShowDialog() == DialogResult.OK) {
				Service.MarkdownWriter.Write(dialog.FileName, _model.SortTree.Nodes);
			}
		}

		/// <summary>
		/// Provides styling to MainForm by setting its position to center and disabling the maximize window option
		/// </summary>
		private void setFormStyling() {
			_view.StartPosition = FormStartPosition.CenterScreen;

			_view.MaximizeBox = false;
		}

		/// <summary>
		/// Updates hotkey field to current command in settings
		/// </summary>
		private void updateHotkeyField() {
			_view.HotkeyField.Text = String.Join(" + ", _model.Settings.Command);
		}

		private void updateSortTree() {
			if(_model.Settings.Categories != null) {
				foreach(string category in _model.Settings.Categories) {
					_view.SortTree.Nodes.Add(category);
				}
			}

			_model.SortTree = _view.SortTree;
			
		}

		/// <summary>
		/// Pulls data from model's settings to make changes (i.e. assign hotkey)
		/// <para>Called in constructor</para>
		/// </summary>
		private void pullSettings() {
			if(_model.Settings.Command != null) {
				updateHotkeyField();

				applyHotkey(Service.Hotkey.Separate(_model.Settings.Command));
			}
		}

		/// <summary>
		/// Calls the hotkey service to detect which keys are modifiers (alt, ctrl, shift). The service will also 
		/// attempt to deregister a previously set hotkey
		/// <para>Called in ToggleHotkeyListener() when user is done assigning the hotkey</para>
		/// </summary>
		private void applyHotkey(Service.Hotkey.Command command) {
			Service.Hotkey.AttemptDeregister(_model.Hotkey);

			_model.Hotkey = new SharpHotkey.Hotkey(
				(MainForm)_view,
				command.Standard,
				command.Modifiers
			);
		}
	}
}
