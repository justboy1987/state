using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-climbing-stairs/description/
    /// </summary>
    class Min_Cost_Climbing_Stairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost == null || cost.Length <= 2)
            {
                return 0;
            }
            var sum = new int[cost.Length+1];
            sum[0] = 0;
            sum[1] = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                sum[i] = Math.Min(sum[i - 1] + cost[i - 1], sum[i - 2] + cost[i - 2]);
            }
            return sum.Last();
        }
    }
}
