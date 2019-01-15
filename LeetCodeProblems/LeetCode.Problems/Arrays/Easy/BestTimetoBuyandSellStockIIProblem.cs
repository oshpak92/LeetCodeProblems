using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 122. Best Time to Buy and Sell Stock II
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
    /// Runtime: 112 ms, faster than 89.13% of C# online submissions for Best Time to Buy and Sell Stock II.
    /// </summary>
    public class BestTimetoBuyandSellStockIIProblem
    {
        //can we sell first?
        //Input: [ 7, 1, 5, 3, 6, 4 ]
        //Output: 7
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            var maxProfit = 0;
            
            var peak = prices[0];
            var valey = prices[0];
            int i = 0;
            while (i < prices.Length - 1)
            {
                //find waley value to by
                while(i < prices.Length - 1 && prices[i] >= prices[i + 1])
                {
                    i++;
                }
                valey = prices[i];
                //look for peek to sell
                while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
                {
                    i++;
                }
                peak = prices[i];

                maxProfit += peak - valey;
            }

            return maxProfit;
        }
    }
}
