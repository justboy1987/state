using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    public class BinaryTreeTilt
    {
        public int FindTilt(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var l = TreeSum(root.left);
            var r = TreeSum(root.right);
            return (l > r ? l - r : r - l )+ FindTilt(root.left) + FindTilt(root.right);
        }

        public int TreeSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return root.val + TreeSum(root.left) + TreeSum(root.right);
        }
    }
}
