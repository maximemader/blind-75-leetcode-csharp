// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Word Search II
/// https://leetcode.com/problems/word-search-ii/
/// </summary>
public class P73_WordSearchII
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        var trie = new Trie();
        
        foreach (var word in words)
            trie.AddWord(word);    

        var result = new List<string>();

        for (var i = 0; i < board.Length; ++i)
            for(var j = 0; j < board[0].Length; ++j)
                DFS(board, i, j, trie.Root, result);
        
        return result;
    }

    private void DFS(char[][] board, int i, int j, TrieNode node, List<string> result)
    {
        var character = board[i][j];
        var characterIndex = character - 'a';
        
        if (character == '#' || node.Children[characterIndex] == null)
            return;
        
        if (node.Children[characterIndex].Word != null)
        {
            result.Add(node.Children[characterIndex].Word!);
            node.Children[characterIndex].Word = null;
        }

        node = node.Children[characterIndex];
        
        board[i][j] = '#';
        
        if(i > 0)
            DFS(board, i - 1, j, node, result);
        
        if(j > 0)
            DFS(board, i, j - 1, node, result);
        
        if(i < board.Length - 1)
            DFS(board, i + 1, j, node, result);
        
        if(j < board[0].Length - 1)
            DFS(board, i, j + 1, node, result);
        
        board[i][j] = character;
    }

    class Trie
    {
        private readonly TrieNode? _root = new();

        public TrieNode Root => _root;
    
        public void AddWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return;

            var current = _root;

            foreach (var character in word)
            {
                var index = character - 'a';
                
                current.Children[index] ??= new TrieNode();
                current = current.Children[index];
            }
            
            current!.Word = word;
        }
    }

    class TrieNode
    {
        public readonly TrieNode[] Children = new TrieNode[26];
        public string? Word;
    }
}