namespace Blind75LeetCode;

/// <summary>
/// Number Of Islands
/// https://leetcode.com/problems/number-of-islands/
/// </summary>
public class P30_NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        var result = 0;

        // No TLE nor StackOverflow with DFS
        // if the grid is very large, we can use BFS.
        for (var i = 0; i < grid.Length; ++i)
        {
            for (var j = 0; j < grid[0].Length; ++j)
            {
                if (grid[i][j] == '1')
                {
                    ++result;

                    DFS(grid, i, j);
                }
            }
        }
        
        return result;
    }

    private void DFS(char[][] grid, int i, int j)
    {
        if(i < 0 || i > grid.Length - 1 ||
           j < 0 || j > grid[0].Length - 1 ||
           grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0';
        
        DFS(grid, i + 1, j);
        DFS(grid, i - 1, j);
        DFS(grid, i, j + 1);
        DFS(grid, i, j - 1);
    }
}