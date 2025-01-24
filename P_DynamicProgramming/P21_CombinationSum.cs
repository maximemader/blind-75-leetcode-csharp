namespace Blind75LeetCode;

/// <summary>
/// Combination Sum
/// https://leetcode.com/problems/combination-sum-iv/
/// </summary>
public class P21_CombinationSum
{
    public int CombinationSum4(int[] nums, int target) 
    {
        if (target == 0)
            return 0;
        
        if(nums.Length == 0)
            return -1;
        
        Array.Sort(nums);
        
        var dp = new int[target + 1];
        dp[0] = 1;

        for (var i = 1; i <= target; ++i)
        {
            foreach (var num in nums)
            {
                if (i - num >= 0)
                    dp[i] += dp[i - num];
            }
        }

        return dp[target];
    }
}