namespace LeetCode.Problems.Arrays.Easy
{
	public class BestTimeToSellAndBestTimeToBuyProblemV2
	{
		public int MaxProfit(int[] prices)
		{
			if (prices == null || prices.Length <= 1)
				return 0;

			int maxProfit = 0;
			int minElInd = 0;

			for (int i = 1; i < prices.Length; i++)
			{
				var max = prices[i] - prices[minElInd];
				maxProfit = System.Math.Max(maxProfit, max);

				if (prices[i] < prices[minElInd])
					minElInd = i;
			}

			return maxProfit;
		}
	}
}
