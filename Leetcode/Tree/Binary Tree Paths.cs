using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Binary_Tree_Paths
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> answer = new List<string>();
            if (root != null) searchBT(root, "", answer);
            return answer;
        }

        private void searchBT(TreeNode root, string path, List<string> answer)
        {
            if (root.left == null && root.right == null) answer.Add(path + root.val);
            if (root.left != null) searchBT(root.left, path + root.val + "->", answer);
            if (root.right != null) searchBT(root.right, path + root.val + "->", answer);
        }

    }
}
