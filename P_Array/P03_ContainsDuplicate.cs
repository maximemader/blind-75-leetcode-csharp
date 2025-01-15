namespace Blind75LeetCode;

/// <summary>
/// Contains Duplicate
/// https://leetcode.com/problems/contains-duplicate/
/// </summary>
public class P03_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        var data = new HashSet<int>();

        for (var i = 0; i < nums.Length; ++i)
        {
            if (!data.Add(nums[i]))
                return true;
        }

        return false;
    }
}