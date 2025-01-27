namespace Blind75LeetCode;

/// <summary>
/// House Robber 2
/// https://leetcode.com/problems/house-robber-ii/
/// </summary>
public class P23_HouseRobber2
{
    public int Rob(int[] nums)
    {
        return nums.Length switch
        {
            0 => 0,
            1 => nums[0],
            _ => Math.Max(HouseRobber1(nums[1..]), HouseRobber1(nums[..^1]))
        };
    }
    
    // House Robber 1
    private int HouseRobber1(int[] nums) 
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