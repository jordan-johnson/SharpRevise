using System.Collections.Generic;
using System.Windows.Forms;
using SharpHotkey;
using SharpRevise.Presenter;

namespace SharpRevise.Model {
	public class MainFormModel {
		/// <summary>
		/// Global hotkey
		/// </summary>
		public Hotkey Hotkey {get;set;}

		/// <summary>
		/// Used in toggle hotkey listener in presenter
		/// </summary>
		public bool AssigningCommand = false;

		/// <summary>
		/// Settings to be read and saved locally in a json file
		/// </summary>
		public Settings Settings {get;set;}

		/// <summary>
		/// Stores keys from keydown event
		/// </summary>
		public List<Keys> CurrentKeys {get;set;}

		/// <summary>
		/// Tree of categories and comments
		/// </summary>
		public TreeView SortTree {get;set;}

		/// <summary>
		/// Converts current keys to string
		/// </summary>
		public List<string> CurrentKeysToString {
			get {
				List<string> keys = new List<string>();

				foreach(Keys key in CurrentKeys) {
					keys.Add(key.ToString());
				}

				return keys;
			}
		}

		/// <summary>
		/// Handles system tray info
		/// </summary>
		public SystemTray SystemTrayHandler = new SystemTray();

		/// <summary>
		/// Tray form presenter
		/// </summary>
		public TrayFormPresenter TrayForm = new TrayFormPresenter();

		/// <summary>
		/// Constructor will either read or write a settings file
		/// </summary>
		public MainFormModel() {
			Settings = new Settings();

			if(Settings.IsAvailable()) {
				Settings = Service.Serializer.Deserialize<Settings>(Settings.FileName);
			} else {
				Settings.WriteNew();
			}

			TrayForm.SubmitAction = AddComment;
		}

		/// <summary>
		/// Update command in settings
		/// </summary>
		public void UpdateCommand() {
			if(CurrentKeys != null) {
				Settings.Command = CurrentKeysToString;

				Settings.Update();
			}
		}

		/// <summary>
		/// Adds a comment to a category
		/// </summary>
		/// <param name="category"></param>
		/// <param name="comment"></param>
		public void AddComment(string category, string comment) {
			Service.TreeView.AddChildNode(SortTree.Nodes, category, comment);

			SortTree.ExpandAll();
		}
	}
}
