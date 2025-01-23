// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Subtree Of Another Tree
/// https://leetcode.com/problems/subtree-of-another-tree/
/// </summary>
public class P66_SubtreeOfAnotherTree
{
    private bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null || subRoot == null)
            return false;

        if (root.val == subRoot.val && CompareTrees(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool CompareTrees(TreeNode subRootNode, TreeNode subRoot)
    {
        if (subRootNode == null && subRoot == null)
            return true;

        if (subRootNode == null || subRoot == null)
            return false;

        if (subRootNode.val != subRoot.val)
            return false;

        return CompareTrees(subRootNode.left, subRoot.left) && CompareTrees(subRootNode.right, subRoot.right);
    }

    private class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}