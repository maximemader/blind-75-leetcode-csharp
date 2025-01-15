// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable InconsistentNaming
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
namespace Blind75LeetCode;

/// <summary>
/// Linked List Cycle
/// https://leetcode.com/problems/linked-list-cycle/
/// </summary>
public class P41_DetectCycleInALinkedList
{
    private bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;
        
        // Floyd's Cycle Detection Algorithm
        var tortoise = head;
        var hare = head;
        
        while(hare != null && hare.next != null)
        {
            tortoise = tortoise.next;
            hare = hare.next.next;
            
            if(tortoise == hare)
                return true;
        }

        return false;
    }
    
    private class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }
}