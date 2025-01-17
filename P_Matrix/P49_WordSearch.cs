namespace Blind75LeetCode;

/// <summary>
/// Word Search
/// https://leetcode.com/problems/word-search/
/// </summary>
public class P49_WordSearch
{
    public bool Exist(char[][] board, string word) 
    {
        if(board.Length == 0 || board[0].Length == 0 || string.IsNullOrEmpty(word))
            return false;
                
        for (var i = 0; i < board.Length; ++i)
        {
            for (var j = 0; j < board[0].Length; ++j)
            {
                // Simple DFS
                if (board[i][j] == word[0] && Search(board, word, i, j, 0)) return true;
            }
        }

        return false;
    }
    
    private bool Search(char[][] board, string word, int i, int j, int index)
    {
        if (index == word.Length)
            return true;

        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[index])
            return false;

        var temp = board[i][j];
        board[i][j] = ' ';
        
        var found = Search(board, word, i + 1, j, index + 1) ||
                    Search(board, word, i - 1, j, index + 1) ||
                    Search(board, word, i, j + 1, index + 1) ||
                    Search(board, word, i, j - 1, index + 1);

        board[i][j] = temp;

        return found;
    }
}