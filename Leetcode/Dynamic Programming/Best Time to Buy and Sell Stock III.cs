using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    class Best_Time_to_Buy_and_Sell_Stock_III
    {
        public int MaxProfit(int[] prices)
        {
            int hold1 = int.MinValue, hold2 = int.MinValue;
            int release1 = 0, release2 = 0;
            foreach (var i in prices)
            {
                release2 = Math.Max(release2, hold2 + i);     // The maximum if we've just sold 2nd stock so far.
                hold2 = Math.Max(hold2, release1 - i);  // The maximum if we've just buy  2nd stock so far.
                release1 = Math.Max(release1, hold1 + i);     // The maximum if we've just sold 1nd stock so far.
                hold1 = Math.Max(hold1, -i);          // The maximum if we've just buy  1st stock so far. 
            }

            return release2; ///Since release1 is initiated as 0, so release2 will always higher than release1.
        }
    }
}
