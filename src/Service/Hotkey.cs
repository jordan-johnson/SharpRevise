using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SharpRevise.Service {
	public class Hotkey {
		/// <summary>
		/// Command class stores both modifiers and the standard key
		/// </summary>
		public class Command {
			public Keys Standard {get;set;}
			public int Modifiers {get;set;}

			public Command() {
				Standard = Keys.NoName;
				Modifiers = 0;
			}
		}

		/// <summary>
		/// Differentiate which keys are modifiers
		/// </summary>
		/// <param name="keys"></param>
		/// <returns></returns>
		public static Command Separate(List<string> keys) {
			Command command = new Command();

			foreach(string key in keys) {
				Keys parsedKey = Parse(key);

				if(IsModifier(parsedKey)) {
					command.Modifiers += GetModifierInt(parsedKey);
				} else {
					command.Standard = parsedKey;
				}
			}

			return command;
		}

		/// <summary>
		/// Attempt to deregister hotkey
		/// </summary>
		/// <param name="hotkey"></param>
		public static void AttemptDeregister(SharpHotkey.Hotkey hotkey) {
			if(hotkey != null) {
				if(hotkey.IsRegistered) {
					if(!hotkey.Deregister()) {
						throw new Exception("Global hotkey could not be deregistered!");
					}
				}
			}
		}

		/// <summary>
		/// List of available modifiers
		/// </summary>
		public static List<string> Modifiers = new List<string>() {
			"ControlKey", "ShiftKey", "Menu"
		};

		/// <summary>
		/// Determine if key value is a modifier
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static bool IsModifier(Keys key) {
			if(Modifiers.Contains(key.ToString())) {
				return true;
			}

			return false;
		}

		/// <summary>
		/// Get int value of modifier
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static int GetModifierInt(Keys key) {
			switch(key) {
				case Keys.Alt:
					return SharpHotkey.Hotkey.Modifiers.Alt;
				case Keys.ControlKey:
					return SharpHotkey.Hotkey.Modifiers.Ctrl;
				case Keys.ShiftKey:
					return SharpHotkey.Hotkey.Modifiers.Shift;
			}

			return 0;
		}

		/// <summary>
		/// Convert name of key to its enum value
		/// </summary>
		/// <param name="key">Name of key</param>
		/// <returns>Keys enum value</returns>
		public static Keys Parse(string key) {
			return (Keys) Enum.Parse(typeof(Keys), key);
		}
	}
}
