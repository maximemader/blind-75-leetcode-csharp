// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
namespace Blind75LeetCode;

/// <summary>
/// Group Anagrams
/// https://leetcode.com/problems/group-anagrams/
/// </summary>
public class P54_GroupAnagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        if (strs == null || strs.Length == 0) {
            return new List<IList<string>>();
        }
        
        var map = new Dictionary<string, IList<string>>();
        
        // Since we have only ASCII lowercase letters, we can go a bit faster
        // by sorting characters instead of reusing P53_ValidAnagram.cs.
        foreach(var str in strs)
        {
            // Same thing, but slower.
            //var key = new string(str.OrderBy(c => c).ToArray());
            
            var strArray = str.ToCharArray();
            Array.Sort(strArray);
            var key = new string(strArray);
            
            if(!map.ContainsKey(key))
                map[key] = [];
            
            map[key].Add(str);
        }

        return map.Values.ToList();
    }
}