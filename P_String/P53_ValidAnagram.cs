namespace Blind75LeetCode;

/// <summary>
/// Valid Anagram
/// https://leetcode.com/problems/valid-anagram/
/// </summary>
public class P53_ValidAnagram
{
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
            return false;

        var chars = new int[26];
        Array.Fill(chars, 0);

        for(var i = 0; i < s.Length; ++i)
        {
            ++chars[s[i] - 'a'];
            --chars[t[i] - 'a'];
        }

        // We could use a XOR operation to check if all elements are 0
        // but this is more readable.
        for (var i = 0; i < 26; i++) {
            if (chars[i] != 0) {
                return false;
            }
        }

        return true;
    }
}