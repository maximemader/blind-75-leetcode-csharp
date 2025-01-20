using System.Collections;

namespace Blind75LeetCode;

/// <summary>
/// Insert Interval
/// https://leetcode.com/problems/insert-interval/
/// </summary>
public class P35_InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval) 
    {
        var result = new List<int[]>();

        var index = 0;
        
        // Insert intervals below the new interval
        while (index < intervals.Length && intervals[index][1] < newInterval[0])
        {
            result.Add(intervals[index]);
            
            ++index;
        }
        
        // Merge overlapping intervals
        while (index < intervals.Length && intervals[index][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[index][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[index][1]);
            
            ++index;
        }
        
        result.Add(newInterval);
        
        // Add remaining intervals after new interval
        while (index < intervals.Length)
        {
            result.Add(intervals[index]);
            
            ++index;
        }
        
        return result.ToArray();
    }
}