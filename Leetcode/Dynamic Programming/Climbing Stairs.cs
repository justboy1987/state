using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/description/
    /// https://leetcode.com/problems/climbing-stairs/solution/
    /// </summary>
    class Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            int f0 = 1, f1 = 1;
            for (int i = 2; i <= n; i++)
            {
                var t = f0 + f1;
                f0 = f1;
                f1 = t;
            }
            return f1;
        }

        public int climbStairs(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double fibn = Math.Pow((1 + sqrt5) / 2, n + 1) - Math.Pow((1 - sqrt5) / 2, n + 1);
            return (int)(fibn / sqrt5);
        }
    }
}
