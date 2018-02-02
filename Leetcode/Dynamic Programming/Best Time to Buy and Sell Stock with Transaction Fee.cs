using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/description/
    /// </summary>
    class Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee
    {
        public int MaxProfit(int[] prices, int fee)
        {
            int cash = 0, hold = -prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                cash = Math.Max(cash, hold + prices[i] - fee);
                hold = Math.Max(hold, cash - prices[i]);
            }
            return cash;
        }

        public int MaxProfit2(int[] prices, int fee)
        {
            int s0 = 0, s1 = int.MinValue;
            foreach (var price in prices)
            {
                int tmp = s0;
                s0 = Math.Max(s0, s1 + price);
                s1 = Math.Max(s1, tmp - price - fee);
            }
            return s0;
        }
    }
}
