using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SharpRevise.Service {
	public class MarkdownWriter {
		public static void Write(string location, TreeNodeCollection nodes) {
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("# Changelog");
			sb.Append(Environment.NewLine);
			sb.AppendLine("## 0.0.0 (0000-00-00)");
			sb.Append(Environment.NewLine);

			foreach(TreeNode category in nodes) {
				if(category.Nodes != null && category.Nodes.Count > 0) {
					sb.AppendLine("### " + category.Text);
					sb.Append(Environment.NewLine);

					foreach(TreeNode comment in category.Nodes) {
						sb.AppendLine("* " + comment.Text);
						sb.Append(Environment.NewLine);
					}
				}
			}

			File.WriteAllText(location, sb.ToString());
		}
	}
}
