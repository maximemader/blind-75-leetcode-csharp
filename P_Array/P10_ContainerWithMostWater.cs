namespace Blind75LeetCode;

/// <summary>
/// Container With Most Water
/// https://leetcode.com/problems/container-with-most-water/
/// </summary>
public class P10_ContainerWithMostWater
{
    public int MaxArea(int[] height) 
    {
        var maxArea = int.MinValue;
        
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            var containerWidth = right - left;
            var containerHeight = Math.Min(height[left], height[right]);
            
            maxArea = Math.Max(maxArea, containerHeight * containerWidth);
            
            if (height[left] < height[right])
                ++left;
            else
                --right;
        }

        return maxArea;
    }
}