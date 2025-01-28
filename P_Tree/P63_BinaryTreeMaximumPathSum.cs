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
        var max = root.val;

        DFS(root, ref max);
        
        return max;
    }

    private int DFS(TreeNode node, ref int max)
    {
        if (node == null)
            return 0;
        
        var left = Math.Max(0, DFS(node.left, ref max));
        var right = Math.Max(0, DFS(node.right, ref max));
        
        max = Math.Max(max, left + right + node.val);
        
        return Math.Max(left, right) + node.val;
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