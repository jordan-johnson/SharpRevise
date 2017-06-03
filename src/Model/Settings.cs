using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpRevise.Model {
	public class Settings {
		public List<string> Categories {get;set;}
		public List<string> Command {get;set;}
		public bool MinimizeOnStart {get;set;}

		[JsonIgnore]
		public const string FileName = "settings.json";

		public Settings() {
			Categories = new List<string>();
			Command = new List<string>();
		}

		public void WriteNew() {
			Categories = new List<string>() {
				"New Features", "Minor Changes", "Fixes", "To do"
			};

			Command = null;

			MinimizeOnStart = false;

			Update();
		}

		public bool IsAvailable() {
			if(File.Exists(FileName)) {
				return true;
			}

			return false;
		}

		public void Update() {
			Service.Serializer.Serialize(this, FileName);
		}
	}
}
