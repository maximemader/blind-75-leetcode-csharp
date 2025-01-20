namespace Blind75LeetCode;

/// <summary>
/// Merge Intervals
/// https://leetcode.com/problems/merge-intervals/
/// </summary>
public class P36_MergeIntervals
{
    public int[][] Merge(int[][] intervals) 
    {
        if(intervals.Length == 0)
            return [];
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var result = new List<int[]>();
        
        var previous = intervals[0];
        
        for (var i = 1; i < intervals.Length; ++i)
        {
            var current = intervals[i];
            
            if (previous[1] >= current[0])
            {
                previous[1] = Math.Max(previous[1], current[1]);
            }
            else
            {
                result.Add(previous);
                previous = current;
            }
        }
        
        result.Add(previous);
        
        return result.ToArray();
    }
}