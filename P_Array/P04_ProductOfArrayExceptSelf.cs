namespace Blind75LeetCode;

/// <summary>
/// Product of Array Except Self
/// https://leetcode.com/problems/product-of-array-except-self/
/// </summary>
/// <remarks>
/// Great "off by one error" source material. ;)
/// </remarks>
public class P04_ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        // With the follow-up O(1) space complexity, we can't use arrays for the left and
        // right products of the current index. The idea is to use the answer array as
        // temporary storage for the left products and then multiply the right products as
        // we go backward.
        var length = nums.Length;
        
        var output = new int[length];
        output[0] = 1;
        
        var i = 1;

        for (; i < length; ++i)
            output[i] = output[i - 1] * nums[i - 1];
        
        var previous = 1;
        
        for (i = length - 2; i >= 0; --i)
        {
            previous *= nums[i + 1];
            output[i] *= previous;
        }

        return output;
    }    
}