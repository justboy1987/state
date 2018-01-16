using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Binary_Tree_Paths
    {
        IList<string> list = new List<string>();
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            Helper(root, new List<TreeNode> ());
            return list;
        }

        private void Helper(TreeNode root, List<TreeNode> path)
        {
            if (root == null)
            {
                return;
            }
            path.Add(root);
            if (root.left == null && root.right == null)
            {
                list.Add(GetPathStr(path));
            }
            Helper(root.left, path);
            Helper(root.right, path);
            path.RemoveAt(path.Count -1);
        }

        private string GetPathStr(List<TreeNode> path)
        {
            return string.Join("->", path.Select(item => item.val).ToArray());
        }

    }
}
