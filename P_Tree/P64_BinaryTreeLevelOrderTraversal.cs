// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Binary Tree Level Order Traversal
/// https://leetcode.com/problems/binary-tree-level-order-traversal/
/// </summary>
public class P64_BinaryTreeLevelOrderTraversal
{
    private IList<IList<int>> LevelOrder(TreeNode root) 
    {
        var result = new List<IList<int>>();
        
        if (root == null)
            return result;
        
        var queue = new Queue<(TreeNode Node, int Level)>();
        
        queue.Enqueue((root, 0));
        
        while (queue.TryDequeue(out var current))
        {
            if (result.Count == current.Level)
                result.Add([]);
            
            result[current.Level].Add(current.Node.val);
            
            if (current.Node.left != null)
                queue.Enqueue((current.Node.left, current.Level + 1));
            
            if (current.Node.right != null)
                queue.Enqueue((current.Node.right, current.Level + 1));
        }
        
        return result;
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