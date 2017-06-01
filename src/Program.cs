using System;
using SharpRevise.Kernel;

namespace SharpRevise {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Bootstrap boot = new Bootstrap();
			boot.Run();
		}
	}
}
