// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable InconsistentNaming
// ReSharper disable ConditionIsAlwaysTrueOrFalse
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
namespace Blind75LeetCode;

/// <summary>
/// Merge Two Sorted Lists
/// https://leetcode.com/problems/merge-two-sorted-lists/
/// </summary>
public class P42_MergeTwoSortedLists
{
    // Nothing tells us to create a new list, so we will merge the two lists in place
    // to keep the space complexity to O(1)
    private ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;

        if (list2 == null)
            return list1;
        
        ListNode current;
        if (list1.val < list2.val)
        {
            current = list1;
            list1 = list1.next;
        }
        else
        {
            current = list2;
            list2 = list2.next;
        }

        var head = current;

        while (list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            } else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }
        
        current.next = list1 ?? list2;

        return head;
    }
    
    private class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }
}