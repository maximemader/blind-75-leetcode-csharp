// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable InconsistentNaming
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
namespace Blind75LeetCode;

/// <summary>
/// Reverse A Linked List
/// https://leetcode.com/problems/reverse-linked-list/
/// </summary>
class P40_ReverseALinkedList
{
    private ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        var current = head;
        
        while (current != null)
        {
            var temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        
        return prev;             
    }

    private class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }
}


