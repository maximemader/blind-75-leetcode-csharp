namespace Blind75LeetCode;

/// <summary>
/// Longest Palindromic Substring
/// https://leetcode.com/problems/longest-palindromic-substring/
/// </summary>
public class P57_LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        // A traditional approach with memoization leads to time length exceeding.
        // After some research, I found Manacher's algorithm that solves the problem.
        // https://en.wikipedia.org/wiki/Longest_palindromic_substring
        
        // The idea is to transform the string into a new one with a special character
        // to handle both odd and even length palindromes.
        var transformedInput = "^#" + string.Join("#", s.ToCharArray()) + "#$";

        var palindromeRadii = new int[transformedInput.Length];
        var center = 0;
        var radius = 0;
        
        for (var i = 1; i < transformedInput.Length-1; ++i) 
        {
            palindromeRadii[i] = (radius > i) ? 
                Math.Min(radius - i, palindromeRadii[2 * center - i]) 
                : 0;
            
            while (transformedInput[i + 1 + palindromeRadii[i]] == transformedInput[i - 1 - palindromeRadii[i]])
                ++palindromeRadii[i];
            
            if (i + palindromeRadii[i] > radius) 
            {
                center = i;
                radius = i + palindromeRadii[i];
            }
        }
        
        var maxRadius = palindromeRadii.Max();
        var centerIndex = Array.IndexOf(palindromeRadii, maxRadius);
        var leftIndex = (centerIndex - maxRadius) / 2;
        
        return s[leftIndex..(leftIndex + maxRadius)];
    }
}