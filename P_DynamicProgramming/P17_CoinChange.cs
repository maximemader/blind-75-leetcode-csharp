namespace Blind75LeetCode;

/// <summary>
/// Coin Change
/// https://leetcode.com/problems/coin-change/
/// </summary>
public class P17_CoinChange
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount == 0)
            return 0;
        
        if(coins.Length == 0)
            return -1;
        
        var combination = new int[amount + 1];
        Array.Fill(combination, amount + 1);
        combination[0] = 0;

        foreach (var coin in coins)
        {
            for(var i = coin; i <= amount; ++i)
            {
                combination[i] = Math.Min(combination[i], combination[i - coin] + 1);
            }
        }

        return combination[amount] > amount ? -1 : combination[amount];
    }
}