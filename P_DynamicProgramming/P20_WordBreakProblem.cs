namespace Blind75LeetCode;

/// <summary>
/// Word Break
/// https://leetcode.com/problems/word-break/
/// </summary>
public class P20_WordBreakProblem
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var dp = new bool[s.Length + 1];
        dp[0] = true;
        
        var maxWordLength = wordDict.Max(x => x.Length);
        
        for(var i = 1; i <= s.Length; ++i)
        {
            for (var j = i - 1; j >= Math.Max(i - maxWordLength - 1, 0); --j)
            {
                if(dp[j] && wordDict.Contains(s[j..i]))
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        
        return dp[^1];
    }
}