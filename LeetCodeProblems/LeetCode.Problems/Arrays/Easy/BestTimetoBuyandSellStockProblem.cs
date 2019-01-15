using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 121. Best Time to Buy and Sell Stock
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// Runtime: 160 ms, faster than 22.48% of C# online submissions for Best Time to Buy and Sell Stock.
    /// </summary>
    public class BestTimetoBuyandSellStockProblem
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;

            var minPrice = int.MaxValue;
            var maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if(prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
