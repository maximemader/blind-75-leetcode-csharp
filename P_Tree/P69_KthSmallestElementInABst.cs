// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Kth Smallest Element In A BST
/// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
/// </summary>
public class P69_KthSmallestElementInABst
{
    private int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>();

        var current = root;

        while (current != null || stack.Count > 0)
        {
            // Traverse left up to the leftmost node
            while (current != null)
            {
                stack.Push(current);
                
                current = current.left;
            }
            
            current = stack.Pop();
            
            if (--k == 0)
                return current.val;

            current = current.right;
        }
        
        return root.val;
    }
    
    private class TreeNode 
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}