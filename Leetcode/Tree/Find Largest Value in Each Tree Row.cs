using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/find-largest-value-in-each-tree-row/description/
    /// </summary>
    class Find_Largest_Value_in_Each_Tree_Row
    {
        public IList<int> LargestValues(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<int> res = new List<int>();
            queue.Enqueue(root);
            int queueSize = root == null ? 0 : 1;
            while (queueSize > 0)
            {
                int largestElement = int.MinValue;
                for (int i = 0; i < queueSize; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    largestElement = Math.Max(cur.val, largestElement);
                    if (cur.left != null) queue.Enqueue(cur.left);
                    if (cur.right != null) queue.Enqueue(cur.right);
                }
                res.Add(largestElement);
                queueSize = queue.Count;
            }
            int[] resArray = new int[res.Count];
            for (int i = 0; i < res.Count; i++) resArray[i] = res[i];
            return resArray;
        }
    }
}
