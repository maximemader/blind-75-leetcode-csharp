namespace Blind75LeetCode;

/// <summary>
/// Jump Game
/// https://leetcode.com/problems/jump-game/
/// </summary>
public class P26_JumpGame
{
    public bool CanJump(int[] nums)
    {
        // Dynamic Programming theme but we can solve it with a greedy approach.
        // var dp = new bool[nums.Length];
        //
        // dp[^1] = true;
        //
        // for (var i = nums.Length - 2; i >= 0; --i)
        // {
        //     for (var j = 1; j <= nums[i]; ++j)
        //     {
        //         if (i + j < nums.Length && dp[i + j])
        //         {
        //             dp[i] = true;
        //             break;
        //         }
        //     }
        // }
        //
        // return dp[0];

        var max = 0;
        
        for (var i = 0; i < nums.Length; ++i)
        {
            if (i > max)
                return false;
            
            max = Math.Max(max, i + nums[i]);
        }

        return true;
    }
}