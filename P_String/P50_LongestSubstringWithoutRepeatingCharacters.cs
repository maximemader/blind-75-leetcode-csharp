namespace Blind75LeetCode;

/// <summary>
/// Longest Substring Without Repeating Characters
/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
/// </summary>
public class P50_LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        if(string.IsNullOrEmpty(s))
            return 0;

        var chars = new HashSet<char>();

        var left = 0;
        var right = 0;
        var maxLength = 0;
        
        while (right < s.Length)
        {
            if(!chars.Add(s[right]))
            {
                chars.Remove(s[left]);
                ++left;
            }
            else
            {
                ++right;
                maxLength = Math.Max(maxLength, right - left);
            }
        }

        return maxLength;
    }
}