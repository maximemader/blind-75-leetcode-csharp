// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Binary Tree Maximum Path Sum
/// https://leetcode.com/problems/binary-tree-maximum-path-sum/
/// </summary>
public class P63_BinaryTreeMaximumPathSum
{
    private int MaxPathSum(TreeNode root)
    {
        throw new Exception();
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