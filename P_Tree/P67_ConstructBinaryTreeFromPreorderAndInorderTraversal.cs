// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Construct Binary Tree From Preorder And Inorder Traversal
/// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
/// </summary>
public class P67_ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    private TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if(preorder.Length == 0 || inorder.Length == 0)
            return null;
        
        var root = new TreeNode(preorder[0]);
        
        var mid = Array.IndexOf(inorder, preorder[0]);
        
        root.left = BuildTree(preorder[1..(mid + 1)], inorder[0..mid]);
        root.right = BuildTree(preorder[(mid + 1)..], inorder[(mid + 1)..]);

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

    public void TestBuildTree(int[] ints, int[] ints1)
    {
        BuildTree(ints, ints1);
    }
}