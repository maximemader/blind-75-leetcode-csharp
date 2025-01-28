// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Design Add And Search Words Data Structure
/// https://leetcode.com/problems/design-add-and-search-words-data-structure/
/// </summary>
public class P72_AddAndSearchWord
{
    private readonly TrieNode? _root = new();
    
    public void AddWord(string word)
    {
        if (string.IsNullOrEmpty(word))
            return;

        var current = _root;

        foreach (var character in word)
        {
            var index = character - 'a';
            
            current!.Children[index] ??= new TrieNode();
            current = current.Children[index];
        }
        
        current!.IsEndOfWord = true;
    }
    
    public bool Search(string word)
    {
        return RecursiveSearch(_root, word, 0);
    }

    private bool RecursiveSearch(TrieNode? node, string word, int index)
    {
        if (index == word.Length)
            return node!.IsEndOfWord;

        var character = word[index];

        if (character == '.')
        {
            for (var i = 0; i < 26; i++)
            {
                if (node?.Children[i] != null && RecursiveSearch(node.Children[i], word, index + 1))
                    return true;
            }
        }
        else
        {
            var i = character - 'a';
            
            if (node?.Children[i] != null && RecursiveSearch(node.Children[i], word, index + 1))
                return true;
        }

        return false;
    }

    class TrieNode
    {
        public readonly TrieNode?[] Children = new TrieNode?[26];
        public bool IsEndOfWord;
    }
}