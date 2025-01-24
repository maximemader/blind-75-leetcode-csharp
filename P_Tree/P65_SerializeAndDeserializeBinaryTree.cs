// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract

using System.Collections;
using System.Text;

#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Serialize and Deserialize Binary Tree
/// https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
/// </summary>
public class P65_SerializeAndDeserializeBinaryTree
{
    // Encodes a tree to a single string.
    private string serialize(TreeNode root)
    {
        if (root == null)
            return "null";

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        var sb = new StringBuilder();

        while (queue.TryDequeue(out var current))
        {
            if (current == null)
            {
                sb.Append("null,");
            }
            else
            {
                sb.Append(current.val);
                sb.Append(",");
                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }
        }

        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    private TreeNode deserialize(string data)
    {
        if(string.IsNullOrEmpty(data) || data == "null")
            return null;
        
        var nodes = data.Split(',', StringSplitOptions.RemoveEmptyEntries);

        var queue = new Queue<TreeNode>();
        var root = new TreeNode(int.Parse(nodes[0]));
        queue.Enqueue(root);

        for (var i = 1; i < nodes.Length; ++i)
        {
            var current = queue.TryDequeue(out var node) ? node : null;
            
            if (nodes[i] != "null")
            {
                var left = new TreeNode(int.Parse(nodes[i]));
                current.left = left;
                queue.Enqueue(left);
            }
            
            if (nodes[++i] != "null")
            {
                var right = new TreeNode(int.Parse(nodes[i]));
                current.right = right;
                queue.Enqueue(right);
            }
        }

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

    public void Test()
    {
        var root = new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5)));
        var serialized = serialize(root);
        var deserialized = deserialize(serialized);
    }
}