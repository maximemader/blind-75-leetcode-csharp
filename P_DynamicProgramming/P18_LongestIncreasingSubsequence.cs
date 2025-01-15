namespace Blind75LeetCode;

/// <summary>
/// Longest Increasing Subsequence
/// https://leetcode.com/problems/longest-increasing-subsequence/
/// </summary>
public class P18_LongestIncreasingSubsequence
{
    public int LengthOfLIS(int[] nums) 
    {
        // We can reuse the same array to store the longest increasing subsequence
        // since the current index is always greater than the subsequence.
        //var dp = new int[nums.Length];
        var length = 0;
        
        foreach (var num in nums)
        {
            var i = Array.BinarySearch(nums, 0, length, num);
            
            if (i < 0)
                i = ~i;
            
            nums[i] = num;
            
            if (i == length)
                ++length;
        }
        
        return length;
    }
}