// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Lower Common Ancestor Of BST
/// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
/// </summary>
public class P70_LowestCommonAncestorOfBst
{
    private TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        while (true)
        {
            if (p.val > root.val && q.val > root.val)
            {
                root = root.right;
                continue;
            }

            if (p.val < root.val && q.val < root.val)
            {
                root = root.left;
                continue;
            }

            return root;
        }
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