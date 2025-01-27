namespace Blind75LeetCode;

/// <summary>
/// House Robber
/// https://leetcode.com/problems/house-robber/
/// </summary>
public class P22_HouseRobber
{
    public int Rob(int[] nums) 
    {
        if (nums.Length == 0)
            return 0;

        // We can simplify even further by using two variables to store the previous
        // and previous previous values (i.e. Fibonacci).
        var prev = 0;
        var prevPrev = 0;
        
        foreach (var num in nums)
        {
            var temp = prev;
            prev = Math.Max(prev, prevPrev + num);
            prevPrev = temp;
        }
        
        return prev;
    }
}