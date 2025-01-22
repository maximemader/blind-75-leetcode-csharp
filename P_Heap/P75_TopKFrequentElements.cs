using System.Collections.Immutable;

namespace Blind75LeetCode;

/// <summary>
/// Top K Frequent Elements
/// https://leetcode.com/problems/top-k-frequent-elements/
/// </summary>
public class P75_TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // Real world implementation
        // return nums
        //     .GroupBy(num => num)
        //     .OrderByDescending(num => num.Count())
        //     .Take(k)
        //     .Select(c => c.Key)
        //     .ToArray();
        
        // To beat the quicksort implementation of OrderByDescending, we have to use the
        // theme's problem, a heap. Here's a take using a priority queue.
        var frequencies = nums.GroupBy(num => num);

        var heap = new PriorityQueue<int, int>();
        
        foreach (var frequency in frequencies)
        {
            heap.Enqueue(frequency.Key, frequency.Count());
            
            if (heap.Count > k)
                heap.Dequeue();
        }
        
        return heap.UnorderedItems.Select(item => item.Element).ToArray();
    }
}