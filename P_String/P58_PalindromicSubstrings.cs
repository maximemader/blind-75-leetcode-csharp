namespace Blind75LeetCode;

/// <summary>
/// Palindromic Substrings
/// https://leetcode.com/problems/palindromic-substrings/
/// </summary>
public class P58_PalindromicSubstrings
{
    // Should have done this one before P57 ;)
    public int CountSubstrings(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        var palindromes = new bool[s.Length][];
        for (var i = 0; i < palindromes.Length; ++i)
            palindromes[i] = new bool[s.Length];

        var count = s.Length;

        // We can fill single characters
        for (var i = 0; i < s.Length; ++i)
            palindromes[i][i] = true;
        
        // We can fill pairs of characters
        for (var i = 0; i < s.Length - 1; ++i)
            if (s[i] == s[i + 1])
            {
                palindromes[i][i + 1] = true;
                ++count;
            }

        // We can fill the rest
        for (var l = 3; l <= s.Length; ++l)
        {
            for (var i = 0; i < s.Length - l + 1; ++i)
            {
                // If the first and last characters are the same and the inner substring is a palindrome
                // then the whole substring is a palindrome.
                if(s[i] == s[i + l - 1] && palindromes[i + 1][i + l - 2])
                {
                    palindromes[i][i + l - 1] = true;
                    ++count;
                }
            }
        }

        return count;
    }

    private int BruteForce_CountSubStrings(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        var count = 0;
        
        for (var i = 0; i < s.Length; ++i)
        {
            for (var j = i; j < s.Length; ++j)
            {
                if (IsPalindrome(s, i, j))
                {
                    ++count;
                }
            }
        }

        return count;
    }
    
    private bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            ++left;
            --right;
        }

        return true;
    }
}