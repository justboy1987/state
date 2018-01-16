using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Minimum_Depth_of_Binary_Tree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null)
                return MinDepth(root.right) + 1;
            if (root.right == null)
                return MinDepth(root.left) + 1;
            return Math.Min(MinDepth(root.right), MinDepth(root.left)) + 1;
        }
    }
}
