// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Maximum Depth of Binary Tree
/// https://leetcode.com/problems/maximum-depth-of-binary-tree/
/// </summary>
public class P60_MaximumDepthOfBinaryTree
{
    private int MaxDepth(TreeNode root)
    {
        return root == null ? 
            0 : 
            1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
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