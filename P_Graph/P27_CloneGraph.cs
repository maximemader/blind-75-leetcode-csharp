// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable InconsistentNaming
#pragma warning disable CS8603 // Possible null reference return.
// ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
namespace Blind75LeetCode;

/// <summary>
/// Clone Graph
/// https://leetcode.com/problems/clone-graph/
/// </summary>
public class P27_CloneGraph
{
    private Node CloneGraph(Node node)
    {
        if (node == null)
            return null;

        var copies = new Dictionary<Node, Node> {};

        return CloneGraph(node, copies);
    }
    
    private static Node CloneGraph(Node node, Dictionary<Node, Node> copies)
    {
        if(copies.TryGetValue(node, out var cloneGraph))
            return cloneGraph;
        
        var copy = new Node(node.val);
        copies[node] = copy;
        
        foreach (var neighbor in node.neighbors)
        {
            copy.neighbors.Add(CloneGraph(neighbor, copies));
        }
        
        return copy;
    }
    
    private class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int val) {
            this.val = val;
            neighbors = new List<Node>();
        }

        public Node(int val, List<Node> neighbors) {
            this.val = val;
            this.neighbors = neighbors;
        }
    }
}