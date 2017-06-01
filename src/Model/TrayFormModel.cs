using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRevise.Model {
	public class TrayFormModel {
		public bool IsOpen {get;set;}
		public List<string> Categories {get;set;}

		public TrayFormModel() {
			IsOpen = false;

			Categories = new List<string>();
		}
	}
}
