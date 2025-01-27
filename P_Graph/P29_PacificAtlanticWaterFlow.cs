namespace Blind75LeetCode;

/// <summary>
/// Pacific Atlantic Water Flow
/// https://leetcode.com/problems/pacific-atlantic-water-flow/
/// </summary>
public class P29_PacificAtlanticWaterFlow
{
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var height = heights.Length;
        var width = heights[0].Length;

        var result = new List<IList<int>>();

        var canFlowToPacific = new bool[height, width];
        var canFlowToAtlantic = new bool[height, width];

        // We can start from the borders and check if we can reach the ocean
        // (see https://assets.leetcode.com/uploads/2021/06/08/waterflow-grid.jpg)

        // DFS from the borders
        for (var i = 0; i < height; ++i)
        {
            DFS(heights, canFlowToPacific, i, 0);
            DFS(heights, canFlowToAtlantic, i, width - 1);
        }

        // DFS from the borders
        for (var j = 0; j < width; ++j)
        {
            DFS(heights, canFlowToPacific, 0, j);
            DFS(heights, canFlowToAtlantic, height - 1, j);
        }

        for (var i = 0; i < height; ++i)
        for (var j = 0; j < width; ++j)
            if (canFlowToPacific[i, j] && canFlowToAtlantic[i, j])
                result.Add([i, j]);

        return result;
    }

    private static void DFS(int[][] heights, bool[,] canFlow, int row, int col)
    {
        if (canFlow[row, col])
            return;

        canFlow[row, col] = true;

        var directions = new[] { -1, 0, 1, 0, -1 };

        for (var direction = 0; direction < 4; ++direction)
        {
            var next = (Row: row + directions[direction], Col: col + directions[direction + 1]);

            if (next.Row >= 0 && next.Row < heights.Length &&
                next.Col >= 0 && next.Col < heights[0].Length &&
                heights[next.Row][next.Col] >= heights[row][col])
                DFS(heights, canFlow, next.Row, next.Col);
        }
    }
}