namespace Blind75LeetCode;

/// <summary>
/// Unique Paths
/// https://leetcode.com/problems/unique-paths/
/// </summary>
public class P25_UniquePaths
{
    public int UniquePaths(int m, int n) 
    {
        // This is a classic DP problem, I've seen it before in
        // Project Euler: https://projecteuler.net/problem=15
        
        // This is the way intended by the problem's theme however
        // there's a mathematical way to solve it by using the formula
        // to find a specific element in Pascal's Triangle.
        var dp = new int[m, n];
        
        for (var i = 0; i < m; ++i) 
            dp[i, 0] = 1;
        
        for (var j = 0; j < n; ++j) 
            dp[0, j] = 1;
        
        for (var i = 1; i < m; ++i)
            for (var j = 1; j < n; ++j) 
                dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
        
        return dp[m - 1, n - 1];
    }
}