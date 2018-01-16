using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Path_Sum_II
    {
        IList<IList<int>> ret = new List<IList<int>>();

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            Helper(root, sum, new List<int>());
            return ret;
        }
        private void Helper(TreeNode root, int sum, IList<int> pathes)
        {
            if (root == null)
            {
                return;
            }
            pathes.Add(root.val);
            if (root.left == null && root.right == null)
            {
                if (sum == root.val)
                {
                    ret.Add(new List<int>(pathes));
                }
            }
            Helper(root.left, sum - root.val, pathes);
            Helper(root.right, sum - root.val, pathes);
            pathes.RemoveAt(pathes.Count - 1);
        }
    }
}
