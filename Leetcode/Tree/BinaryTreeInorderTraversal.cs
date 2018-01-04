using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Models;

namespace Leetcode.Tree
{
    /// <summary>
    /// 94. Binary Tree Inorder Traversal
    /// https://leetcode.com/problems/binary-tree-inorder-traversal/description/
    /// </summary>
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            Solution1(root, list);
            return list;
        }

        private void Solution1(TreeNode root, IList<int> list)
        {
            if (root == null)
            {
                return;
            }
            Solution1(root.left, list);
            list.Add(root.val);
            Solution1(root.right, list);
        }
    }
}
