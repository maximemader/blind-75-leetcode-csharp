namespace Blind75LeetCode;

/// <summary>
/// Rotate Image
/// https://leetcode.com/problems/rotate-image/
/// </summary>
public class P48_RotateImage
{
    public void Rotate(int[][] matrix) {
        // Matrix is a square matrix
        var length = matrix.Length;
        
        // Transpose the matrix
        for (var i = 0; i < length; ++i)
        {
            for (var j = i + 1; j < length; ++j)
            {
                (matrix[j][i], matrix[i][j]) = (matrix[i][j], matrix[j][i]);
            }
        }
        
        // Reverse each row
        for (var i = 0; i < length; ++i) {
            Array.Reverse(matrix[i]);
        }
    }
}