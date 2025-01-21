// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable InconsistentNaming
#pragma warning disable CS8603 // Possible null reference return.
// ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
namespace Blind75LeetCode;

/// <summary>
/// Course Schedule
/// https://leetcode.com/problems/course-schedule/
/// </summary>
public class P28_CourseSchedule
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var adj = new List<List<int>>();
        
        for (var i = 0; i < numCourses; ++i) 
            adj.Add([]);
        
        foreach (var prerequisite in prerequisites) 
            adj[prerequisite[1]].Add(prerequisite[0]);
        
        return TopologicalSort(adj, numCourses).Count == numCourses;
    }
    
    /// <summary>
    /// Kahn's Algorithm
    /// </summary>
    static List<int> TopologicalSort(List<List<int> > adj, int V)
    {
        // Vector to store indegree of each vertex
        var indegree = new int[V];
        
        foreach (var vertex in adj.SelectMany(list => list))
            ++indegree[vertex];

        // Queue to store vertices with indegree 0
        var q = new Queue<int>();
        
        for (var i = 0; i < V; i++) 
            if (indegree[i] == 0)
                q.Enqueue(i);
        
        var result = new List<int>();
        
        while (q.Count > 0) 
        {
            var node = q.Dequeue();
            result.Add(node);
            
            // Decrease indegree of adjacent vertices as the current node is in topological order
            foreach(var adjacent in adj[node])
            {
                --indegree[adjacent];
                
                // If indegree becomes 0, push it to the queue
                if (indegree[adjacent] == 0)
                    q.Enqueue(adjacent);
            }
        }

        // Check for cycle
        return result.Count == V ? result : [];
    }
}