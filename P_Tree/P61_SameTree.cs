// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Same Tree
/// https://leetcode.com/problems/same-tree/
/// </summary>
public class P61_SameTree
{
    private bool IsSameTree(TreeNode p, TreeNode q) 
    {
        if(p == null && q == null)
            return true;

        if (p == null || q == null)
            return false;
        
        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
    
    private class TreeNode {
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