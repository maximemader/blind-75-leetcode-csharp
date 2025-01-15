namespace Blind75LeetCode;

/// <summary>
/// Valid Palindrome
/// https://leetcode.com/problems/valid-palindrome/
/// </summary>
public class P56_ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            // If bored we could benchmark a custom implementation since the input
            // is ASCII only.
            if (!char.IsLetterOrDigit(s[left]))
            {
                ++left;
            }
            else if (!char.IsLetterOrDigit(s[right]))
            {
                --right;
            }
            else if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            else
            {
                ++left;
                --right;
            }
        }

        return true;
    }

    // Easy mode ;)
    // public bool IsPalindrome(string s) 
    // {
    //     var sanitized = s
    //         .Where(char.IsLetterOrDigit)
    //         .Select(char.ToLower)
    //         .ToArray();
    //     
    //     for(var i = 0; i < sanitized.Length / 2; ++i)
    //     {
    //         if (sanitized[i] != sanitized[sanitized.Length - 1 - i])
    //             return false;
    //     }
    //
    //     return true;
    // }
}