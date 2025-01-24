namespace Blind75LeetCode;

/// <summary>
/// Decode Ways
/// https://leetcode.com/problems/decode-ways/
/// </summary>
public class P24_DecodeWays
{
    public int NumDecodings(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        if (s[0] == '0')
            return 0;

        var dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (var i = 2; i <= s.Length; ++i)
        {
            if (s[i - 1] != '0')
                dp[i] += dp[i - 1];

            var n = int.Parse(s[(i - 2)..i]);
            
            if(n is >= 10 and <= 26)
                dp[i] += dp[i - 2];
        }

        return dp[s.Length];
    }
}