namespace Blind75LeetCode;

/// <summary>
/// Longest Repeating Character Replacement
/// </summary>
public class P51_LongestRepeatingCharacterReplacement
{
    public int CharacterReplacement(string s, int k) 
    {
        if(string.IsNullOrEmpty(s))
            return 0;

        var frequencies = new Dictionary<char, int>();
        var result = 0;
        var left = 0;
        var right = 0;
        var highestFrequency = 0;
        
        while (right < s.Length)
        {
            if(frequencies.ContainsKey(s[right]))
                ++frequencies[s[right]];
            else
                frequencies[s[right]] = 1;

            if (highestFrequency < frequencies[s[right]])
                highestFrequency = frequencies[s[right]];

            var length = right - left + 1;
            if(length - highestFrequency > k)
            {
                --frequencies[s[left]];
                ++left;
            }
            else
            {
                result = Math.Max(result, length);
            }
            
            ++right;
        }

        return result;
    }
}