using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/longest-univalue-path/description/
    /// </summary>
    class Longest_Univalue_Path
    {
        public int LongestUnivaluePath(TreeNode root)
        {
            if (root == null) return 0;
            int sub = Math.Max(LongestUnivaluePath(root.left), LongestUnivaluePath(root.right));
            return Math.Max(sub, Helper(root.left, root.val) + Helper(root.right, root.val));
        }
        int Helper(TreeNode root, int val)//Max Length from root path where each node in the path has the same value
        {
            if (root == null || root.val != val) return 0;
            return 1 + Math.Max(Helper(root.left, val), Helper(root.right, val));
        }
        
    }
}
