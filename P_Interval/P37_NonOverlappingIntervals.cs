namespace Blind75LeetCode;

/// <summary>
/// Non-Overlapping Intervals
/// https://leetcode.com/problems/non-overlapping-intervals/
/// </summary>
public class P37_NonOverlappingIntervals
{
    public int EraseOverlapIntervals(int[][] intervals) 
    {
        if(intervals.Length == 0)
            return 0;
        
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        
        var count = 1;
        var previous = 0;
        
        for (var i = 1; i < intervals.Length; ++i)
        {
            if (intervals[i][0] < intervals[previous][1]) 
                continue;
            
            previous = i;
            ++count;
        }

        return intervals.Length - count;
    }
}