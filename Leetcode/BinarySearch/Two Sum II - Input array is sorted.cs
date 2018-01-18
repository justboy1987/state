using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    class Two_Sum_II___Input_array_is_sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0, j = numbers.Length - 1; i < j;)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new[] {i + 1, j + 1};
                }else if (numbers[i] + numbers[j] < target)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return null;
        }
    }
}
