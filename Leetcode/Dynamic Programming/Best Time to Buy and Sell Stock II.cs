using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
    /// </summary>
    class Best_Time_to_Buy_and_Sell_Stock_II
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int i = 0;
            int valley = prices[0];
            int peak = prices[0];
            int maxprofit = 0;
            while (i < prices.Length - 1)
            {
                while (i < prices.Length - 1 && prices[i] >= prices[i + 1])
                    i++;
                valley = prices[i];
                while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
                    i++;
                peak = prices[i];
                maxprofit += peak - valley;
            }
            return maxprofit;
        }

        public int MaxProfit2(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }
            return maxprofit;
        }
    }
}
