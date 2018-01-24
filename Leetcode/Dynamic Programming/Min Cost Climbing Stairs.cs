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
            for (int i = 2; i <= cost.Length - 1; i++)
            {
                cost[i] = cost[i] + Math.Min(cost[i - 1], cost[i - 2]);
            }

            return Math.Min(cost[cost.Length - 1], cost[cost.Length - 2]);
        }
    }
}
