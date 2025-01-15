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
/// Merge K Sorted Lists
/// https://leetcode.com/problems/merge-k-sorted-lists/
/// </summary>
public class P43_MergeKSortedLists
{
    private ListNode MergeKLists(ListNode[] lists) 
    {
        if (lists.Length == 0)
            return null;

        // This is the naive approach, but it's too slow since lists[0] is growing with each merge
        // for (var i = 1; i < lists.Length; ++i)
        //     lists[0] = MergeTwoLists(lists[0], lists[i]);
        
        // Divide & conquer approach
        return DivideAndConquer(lists, 0, lists.Length - 1);
    }
    
    private ListNode DivideAndConquer(ListNode[] lists, int start, int end)
    {
        if (start == end)
            return lists[start];

        if (start > end) 
            return null;
        
        var mid = start + (end - start) / 2;
        var left = DivideAndConquer(lists, start, mid);
        var right = DivideAndConquer(lists, mid + 1, end);
        
        return MergeTwoLists(left, right);
    }
    
    // We can reuse P42_MergeTwoSortedLists.cs
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