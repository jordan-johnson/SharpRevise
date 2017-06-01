using System.IO;
using Newtonsoft.Json;

namespace SharpRevise.Service {
	public class Serializer {
		public static void Serialize(dynamic obj, string path) {
			File.WriteAllText(path, JsonConvert.SerializeObject(obj, Formatting.Indented));
		}

		public static T Deserialize<T>(string path) {
			if(Exists(path)) {
				using(StreamReader file = File.OpenText(path)) {
					JsonSerializer serializer = new JsonSerializer();
					T deserialized = (T)serializer.Deserialize(file, typeof(T));

					return deserialized;
				}
			}

			return default(T);
		}

		public static bool Exists(string path) {
			if(File.Exists(path)) {
				return true;
			}

			return false;
		}
	}
}
