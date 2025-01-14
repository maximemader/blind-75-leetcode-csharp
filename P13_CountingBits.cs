namespace Blind75LeetCode;

/// <summary>
/// Counting Bits
/// https://leetcode.com/problems/counting-bits/
/// </summary>
public class P13_CountingBits
{
    public int[] CountBits(int n) 
    {
        var result = new int[n + 1];
        result[0] = 0;

        // This is trickier than Convert.ToString(i, 2).Replace("0", "").Length ;)
        //
        // The number of 1 bit in a number is the number of 1 bit in the number divided by 2
        // plus the remainder of the number divided by 2.
        //
        // Since we need to get all the numbers from 0 to n, we can use the previous results
        // to calculate the current number of 1 bit instead of finding the nearest power of 2
        // or using a lookup table.
        for(var i = 1; i <= n; ++i)
            result[i] = result[i >> 1] + (i & 1);
        
        return result;
    }
}