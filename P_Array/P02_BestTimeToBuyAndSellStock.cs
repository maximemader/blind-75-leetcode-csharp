namespace Blind75LeetCode;

/// <summary>
/// Best Time to Buy and Sell Stock
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
/// </summary>
public class P02_BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices) 
    {
        var lowestPrice = prices[0];
        var highestProfit = 0;
        
        for (var i = 1; i < prices.Length; ++i)
        {
            // Only update profit if we find a new highest profit with
            // the last lowest price.
            var profit = prices[i] - lowestPrice;
            
            if (profit > highestProfit)
                highestProfit = profit;
            
            // Try finding a new lowest price.
            if(prices[i] < lowestPrice)
                lowestPrice = prices[i];
        }

        return highestProfit;
    }
}