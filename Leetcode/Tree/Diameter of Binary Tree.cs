using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class DiameterOfBinaryTreeSLN
    {
        int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            MaxDepth(root);
            return max;
        }


        private int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;
        }
    }
}
