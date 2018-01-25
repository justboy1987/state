using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Average_of_Levels_in_Binary_Tree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var ret = new List<double>();
            AverageLevelRecursive(new List<TreeNode>() {root}, ret);
            return ret;
        }

        private void AverageLevelRecursive(List<TreeNode> root, List<double> result)
        {
            var nextLevelRoots = new List<TreeNode>();
            long sum = 0;
            foreach (var r in root)
            {
                sum += r.val;
                if (r.left != null)
                {
                    nextLevelRoots.Add(r.left);
                }
                if (r.right != null)
                {
                    nextLevelRoots.Add(r.right);
                }
            }
            result.Add((double)sum/root.Count);
            if (nextLevelRoots.Count > 0)
            {
                AverageLevelRecursive(nextLevelRoots, result);
            }
        }
    }
}
