using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                    minprice = prices[i];
                else if (prices[i] - minprice > maxprofit)
                    maxprofit = prices[i] - minprice;
            }
            return maxprofit;
        }
    }
}
