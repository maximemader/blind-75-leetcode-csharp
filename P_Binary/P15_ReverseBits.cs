using System.Collections;

namespace Blind75LeetCode;

/// <summary>
/// Reverse Bits
/// https://leetcode.com/problems/reverse-bits/
/// </summary>
public class P15_ReverseBits
{
    public uint reverseBits(uint n) 
    {
        var result = 0u;
        
        for (var i = 0; i < 32; ++i)
        {
            // Shift the result to the left and add the rightmost bit of n
            result <<= 1;
            result |= n & 1;
            n >>>= 1;
        }

        return result;
    }
}