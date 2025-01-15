namespace Blind75LeetCode;

/// <summary>
/// Longest Common Subsequence
/// https://leetcode.com/problems/longest-common-subsequence/
/// </summary>
public class P19_LongestCommonSubsequence
{
    public int LongestCommonSubsequence(string text1, string text2) 
    {
        var dp = new int[text1.Length + 1, text2.Length + 1];

        for (var i = text1.Length - 1; i >= 0; --i)
        {
            for (var j = text2.Length - 1; j >= 0; --j)
            {
                dp[i, j] = text1[i] == text2[j] ? 
                    1 + dp[i + 1, j + 1] : 
                    Math.Max(dp[i + 1, j], dp[i, j + 1]);
            }
        }
        
        return dp[0, 0];
    }
}