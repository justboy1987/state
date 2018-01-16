using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    class Maximum_Binary_Tree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return Helper(nums, 0, nums.Length - 1);
        }

        public TreeNode Helper(int[] nums, int l, int r)
        {
            if (l > r)
            {
                return null;
            }
            var max = nums[l];
            var maxIndex = l;
            for (int i = l +1; i <= r; i++)
            {
                if (max < nums[i])
                {
                    maxIndex = i;
                    max = nums[i];
                }
            }
            var note = new TreeNode(max);
            note.left = Helper(nums, l, maxIndex - 1);
            note.right = Helper(nums, maxIndex + 1, r);
            return note;
        }

        /*  O（n） solution
        public TreeNode constructMaximumBinaryTree(int[] nums)
        {
            LinkedList<TreeNode> lklist = new LinkedList<>();
            TreeNode left = null;
            for (int num: nums)
            {
                TreeNode cur = new TreeNode(num);
                while (!lklist.isEmpty() && lklist.peekFirst().val < cur.val)
                {
                    cur.left = lklist.pop();
                }

                if (!lklist.isEmpty())
                {
                    lklist.peekFirst().right = cur;
                }
                lklist.push(cur);
            }

            return lklist.peekLast();
        }
        */
    }
}
