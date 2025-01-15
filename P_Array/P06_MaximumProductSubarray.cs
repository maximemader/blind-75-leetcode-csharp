namespace Blind75LeetCode;

/// <summary>
/// Maximum Product Subarray
/// https://leetcode.com/problems/maximum-product-subarray/
/// </summary>
public class P06_MaximumProductSubarray
{
    public int MaxProduct(int[] nums) 
    {
        // We can adapt P05's Kadane's algorithm to keep track of the maximum product
        // as well as the minimum product. This is because a negative number can flip
        // the maximum product to the minimum product and vice versa.
        var min = nums[0];
        var max = nums[0];
        var result = nums[0];
        
        for (var i = 1; i < nums.Length; ++i)
        {
            // Negative number flips the min and max
            if(nums[i] < 0)
                (min, max) = (max, min);
            
            min = Math.Min(nums[i], min * nums[i]);
            max = Math.Max(nums[i], max * nums[i]);
            
            result = Math.Max(result, max);
        }

        return result;
    } 
}