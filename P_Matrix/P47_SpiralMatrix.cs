namespace Blind75LeetCode;

/// <summary>
/// Spiral Matrix
/// https://leetcode.com/problems/spiral-matrix/
/// </summary>
public class P47_SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        if(matrix.Length == 0 || matrix[0].Length == 0)
            return new List<int>();
        
        var result = new List<int>();
        
        var top = 0;
        var bottom = matrix.Length - 1;
        var left = 0;
        var right = matrix[0].Length - 1;

        while (true)
        {
            for(int i = left; i <= right; ++i)
                result.Add(matrix[top][i]);

            if(++top > bottom)
                break;
            
            for(int i = top; i <= bottom; ++i)
                result.Add(matrix[i][right]);

            if(left > --right)
                break;
            
            for(int i = right; i >= left; --i)
                result.Add(matrix[bottom][i]);

            if(top > --bottom)
                break;
            
            for(int i = bottom; i >= top; --i)
                result.Add(matrix[i][left]);
            
            if(++left > right)
                break;
        }

        return result;
    }
}