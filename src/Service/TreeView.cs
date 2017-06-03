using System.Windows.Forms;

namespace SharpRevise.Service {
	public class TreeView {
		public static void AddChildNode(TreeNodeCollection tree, string parent, string child) {
			TreeNode node = GetNode(parent, tree);

			if(node != null) {
				node.Nodes.Add(child);
			}
		}

		public static TreeNode GetNode(string text, TreeNodeCollection nodes) {
			foreach(TreeNode node in nodes) {
				if(node.Text == text) {
					return node;
				}
			}

			return null;
		}
	}
}
