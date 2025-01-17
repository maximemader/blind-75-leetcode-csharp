// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Invert Binary Tree
/// https://leetcode.com/problems/invert-binary-tree/
/// </summary>
public class P62_InvertFlipBinaryTree
{
    private TreeNode InvertTree(TreeNode root) 
    {
        if(root == null)
            return null;

        var temp = InvertTree(root.right);
        root.right = InvertTree(root.left);
        root.left = temp;

        return root;
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