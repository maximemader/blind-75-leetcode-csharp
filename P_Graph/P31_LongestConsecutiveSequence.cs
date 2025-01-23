namespace Blind75LeetCode;

/// <summary>
/// Longest Consecutive Sequence
/// https://leetcode.com/problems/longest-consecutive-sequence/
/// </summary>
public class P31_LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        // We could avoid this by using dictionaries and do some merging.
        // This solution is easier to understand.
        var values = nums.ToHashSet();

        var longest = 0;

        for (var i = 0; i < nums.Length; ++i)
        {
            var lower = nums[i] - 1;
            var higher = nums[i] + 1;
            
            while (values.Remove(lower))
                --lower;
            while (values.Remove(higher))
                ++higher;
            
            longest = Math.Max(longest, higher - lower - 1);
            
            if(values.Count == 0)
                break;
        }

        return longest;
    }
}