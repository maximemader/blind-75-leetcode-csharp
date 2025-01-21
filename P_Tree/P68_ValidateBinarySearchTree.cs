// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Validate Binary Search Tree
/// https://leetcode.com/problems/validate-binary-search-tree/
/// </summary>
public class P68_ValidateBinarySearchTree
{
    private bool IsValidBST(TreeNode root)
    {
        var stack = new Stack<TreeNode>();

        int? leftValue = null;
        
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

            // If the current node's value is less than or equal to the previous node's value,
            // return false
            if (leftValue != null && leftValue >= current.val)
                return false;

            leftValue = current.val;
            current = current.right;
        }
        
        return true;
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