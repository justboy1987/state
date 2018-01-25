using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Find_Bottom_Left_Tree_Value
    {
        private int lastItem;
        public int FindBottomLeftValue(TreeNode root)
        {
            AverageLevelRecursive(new List<TreeNode>() {root});
            return lastItem;
        }

        private void AverageLevelRecursive(List<TreeNode> root)
        {
            var nextLevelRoots = new List<TreeNode>();
            lastItem = root[0].val;
            foreach (var r in root)
            {
                if (r.left != null)
                {
                    nextLevelRoots.Add(r.left);
                }
                if (r.right != null)
                {
                    nextLevelRoots.Add(r.right);
                }
            }
            if (nextLevelRoots.Count > 0)
            {
                AverageLevelRecursive(nextLevelRoots);
            }
        }

        /*
          public int findBottomLeftValue(TreeNode root) {
        return findBottomLeftValue(root, 1, new int[]{0,0});
    }
    public int findBottomLeftValue(TreeNode root, int depth, int[] res) {
        if (res[1]<depth) {res[0]=root.val;res[1]=depth;}
        if (root.left!=null) findBottomLeftValue(root.left, depth+1, res);
        if (root.right!=null) findBottomLeftValue(root.right, depth+1, res);
        return res[0];
    }
         */
    }
}
