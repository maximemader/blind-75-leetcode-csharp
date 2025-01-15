namespace Blind75LeetCode;

/// <summary>
/// Climbing Stairs
/// https://leetcode.com/problems/climbing-stairs/
/// </summary>
public class P16_ClimbingStairs
{
    public int ClimbStairs(int n) 
    {
        // If we do it by hand, we can recognize the Fibonacci sequence.
        if (n == 1)
            return 1;
        
        var first = 1;
        var second = 2;
        
        for (var i = 3; i <= n; ++i)
        {
            var third = first + second;
            first = second;
            second = third;
        }
        
        return second;
    }
}