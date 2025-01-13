namespace Blind75LeetCode;

/// <summary>
/// Two Sum.
/// https://leetcode.com/problems/two-sum/
/// </summary>
public class P01_TwoSum {
    public int[] TwoSum(int[] nums, int target)
    {
        var data = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; ++i)
        {
            var diff = target - nums[i];
            
            // while we're iterating, we're also checking if the difference is already in the dictionary
            if (data.TryGetValue(diff, out var value))
            {
                return [value, i];
            }
            
            data.TryAdd(nums[i], i);
        }

        return [];
    }
}