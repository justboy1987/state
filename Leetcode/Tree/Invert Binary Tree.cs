using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Invert_Binary_Tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            var left = InvertTree(root.right);
            root.right = InvertTree(root.left);
            root.left = left;
            return root;
        }
    }
}
