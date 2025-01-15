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
/// Remove Nth Node From End of List
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
/// </summary>
public class P44_RemoveNthNodeFromEndOfList
{
    private ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var node = head;
        var nStepForwardNode = head;
        
        // We can think of the tortoise and hare approach here
        // but with two tortoises, one of them with a head start
        // of n steps.
        for (var i = 0; i < n; ++i) 
            nStepForwardNode = nStepForwardNode.next;
        
        if (nStepForwardNode == null) 
            return head.next;
        
        while (nStepForwardNode.next != null) 
        {
            nStepForwardNode = nStepForwardNode.next;
            node = node.next;
        }
        
        node.next = node.next.next;
        
        return head;
    }
    
    private class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }

    public void Test()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var n = 2;
        var result = RemoveNthFromEnd(head, n);
    }
}