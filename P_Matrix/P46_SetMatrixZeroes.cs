namespace Blind75LeetCode;

/// <summary>
/// Set Matrix Zeroes
/// https://leetcode.com/problems/set-matrix-zeroes/
/// </summary>
public class P46_SetMatrixZeroes
{
    public void SetZeroes(int[][] matrix) 
    {
        var markerRow = false;
        var markerColumn = false;

        // We're using the first column and the first row to mark the zeroes.
        // We keep track if we have to clear them later.
        for (var i = 0; i < matrix.Length; ++i)
        {
            if (matrix[i][0] == 0)
            {
                markerColumn = true;
                break;
            }
        }

        for (var j = 0; j < matrix[0].Length; ++j)
        {
            if (matrix[0][j] == 0)
            {
                markerRow = true;
                break;
            }
        }

        for (var i = 1; i < matrix.Length; ++i)
        {
            for (var j = 1; j < matrix[0].Length; ++j)
            {
                if(matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        for (var i = 1; i < matrix.Length; ++i)
            for (var j = 1; j < matrix[0].Length; ++j)
                if(matrix[i][0] == 0 || matrix[0][j] == 0)
                    matrix[i][j] = 0;
            
        // Clear the first row and the first column if we marked them.
        if(markerRow)
            for (var j = 0; j < matrix[0].Length; ++j)
                matrix[0][j] = 0;

        if(markerColumn)
            for (var i = 0; i < matrix.Length; ++i)
                matrix[i][0] = 0;
    }
}