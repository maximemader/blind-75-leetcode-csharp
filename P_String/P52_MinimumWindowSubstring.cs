namespace Blind75LeetCode;

/// <summary>
/// Minimum Window Substring
/// https://leetcode.com/problems/minimum-window-substring/
/// </summary>
public class P52_MinimumWindowSubstring
{
    public string MinWindow(string s, string t) 
    {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
            return string.Empty;
        
        var frequencyMap = new Dictionary<char, int>();

        foreach (var c in t)
        {
            if(!frequencyMap.TryAdd(c, 1))
                ++frequencyMap[c];
        }

        // We can't go map.Values.All() because it's too slow. So instead, we keep track
        // of the number of unique characters in t that don't match the right frequency.
        var count = frequencyMap.Count;

        var left = 0;
        var right = 0;

        var minWindowSize = int.MaxValue;
        var window = (Start: 0, Size: 0);

        while (right < s.Length)
        {
            if(frequencyMap.ContainsKey(s[right]))
            {
                --frequencyMap[s[right]];
                
                if(frequencyMap[s[right]] == 0)
                    --count;
            }
            
            if(count == 0)
            {
                var windowSize = right-left+1;

                if (windowSize < minWindowSize)
                {
                    minWindowSize = windowSize;
                    window = (left, right - left + 1);
                }
                
                while(!frequencyMap.ContainsKey(s[left]) || 
                      (frequencyMap.ContainsKey(s[left]) && frequencyMap[s[left]] < 0)) 
                {
                    if(frequencyMap.ContainsKey(s[left]) && frequencyMap[s[left]] < 0) 
                        ++frequencyMap[s[left]];
                    
                    ++left;
                    windowSize = right - left + 1;

                    if(windowSize < minWindowSize) 
                    {
                        window = (left, right - left + 1);
                        minWindowSize = windowSize;
                    }
                }
            }

            ++right;
        }

        return minWindowSize == int.MaxValue ? string.Empty : s.Substring(window.Start, window.Size);
    }
}