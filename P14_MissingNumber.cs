namespace Blind75LeetCode;

/// <summary>
/// Missing Number
/// https://leetcode.com/problems/missing-number/
/// </summary>
public class P14_MissingNumber
{
    public int MissingNumber(int[] nums) 
    {
        // Poor man's one-liner, but that's too slow.
        // return Enumerable.Range(0, nums.Length + 1).Sum() - nums.Sum();
        
        // Faster one-liner with Linq, but too slow on LeetCode.
        // return nums.Aggregate((nums.Length * (nums.Length + 1)) / 2, (current, t) => current - t);
        
        // Gauss' formula for the sum of the first n numbers.
        var sum = (nums.Length * (nums.Length + 1)) / 2;

        // Subtract all the numbers in the array from the sum.
        for (var i = 0; i < nums.Length; ++i)
            sum -= nums[i];
        
        // The missing number is the remaining sum.
        return sum;
    }
}