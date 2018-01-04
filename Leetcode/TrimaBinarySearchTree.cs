using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class TrimaBinarySearchTree
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if(root == null) { return null; }
            if (root.val >= L && root.val <= R)
            {
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
                return root;
            }
            else if (root.val < L)
            {
                return TrimBST(root.right, L, R);
               
            }
            else
            {
                return TrimBST(root.left, L, R);
            }

        }
    }
}
