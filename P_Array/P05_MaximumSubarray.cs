namespace Blind75LeetCode;

/// <summary>
/// Maximum Subarray
/// https://leetcode.com/problems/maximum-subarray/
/// </summary>
public class P05_MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        // Kadane's algorithm
        var largestSum = int.MinValue;
        var currentSum = 0;
        
        for (var i = 0; i < nums.Length; ++i)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            largestSum = Math.Max(largestSum, currentSum);
        }

        return largestSum;
    }
}