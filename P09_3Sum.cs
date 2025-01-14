namespace Blind75LeetCode;

/// <summary>
/// 3 Sum
/// https://leetcode.com/problems/3sum/
/// </summary>
public class P09_3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);

        // In order to have a better score, we're not using HashSet nor Tuple to check for
        // duplicates, we're using the array sorted to check for duplicates.
        for (var i = 0; i < nums.Length - 2; ++i)
        {
            var left = i + 1;
            var right = nums.Length - 1;

            var target = -1 * nums[i];

            while (left < right)
            {
                var sum = nums[left] + nums[right];

                if(sum < target)                
                    ++left;
                else if (sum > target)
                    --right;
                else
                {
                    var leftValue = nums[left];
                    var rightValue = nums[right];

                    result.Add([nums[i], leftValue, rightValue]);
                    
                    if(leftValue == rightValue)
                        break;

                    while (left < right && nums[left] == leftValue)
                        ++left;
                
                    while (left < right && nums[right] == rightValue)  
                        --right;
                }
            }
            
            while (i < nums.Length - 2 && nums[i] == nums[i + 1])
                ++i;
        }

        return result;
    }   
}