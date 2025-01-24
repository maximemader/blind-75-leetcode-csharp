// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToPrimaryConstructor
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
namespace Blind75LeetCode;

/// <summary>
/// Implement Trie (Prefix Tree)
/// https://leetcode.com/problems/implement-trie-prefix-tree/
/// </summary>
public class P71_ImplementTrie
{
    // This is good enough for this problem, we could make it faster by using an array of 26 elements since
    // word and prefix consist only of lowercase English letters.
    //
    // A dictionary is used here for simplicity otherwise we could use a sorted linked list for instance.
    //
    // The problem data set allows for an hashset based solution as well, but it would defeat the purpose
    // of the exercise.
    private readonly Dictionary<char, TrieNode> _root = new();

    class TrieNode
    {
        public readonly Dictionary<char, TrieNode> Children = new();
        public bool IsEndOfWord;
    }
    
    public void Insert(string word)
    {
        if (string.IsNullOrEmpty(word))
            return;
        
        var letters = word.ToCharArray();

        TrieNode? current = null;

        foreach (var character in letters)
        {
            if(current == null)
            {
                if (_root.TryGetValue(character, out current))
                {
                    continue;
                }
                
                current = new TrieNode();
                _root.Add(character, current);
            } 
            else if(current.Children.TryGetValue(character, out var child))
            {
                current = child;
            }
            else
            {
                child = new TrieNode();
                current.Children.Add(character, child);
                current = child;
            }
        }
        
        current!.IsEndOfWord = true;
    }

    public bool Search(string word) => SearchLetters(word, true);

    public bool StartsWith(string prefix) => SearchLetters(prefix);

    private bool SearchLetters(string lettersAsString, bool checkEndOfWord = false)
    {
        var letters = lettersAsString.ToCharArray();

        TrieNode? current = null;

        foreach (var character in letters)
        {
            if(current == null)
            {
                if(!_root.TryGetValue(character, out current))
                    return false;
            } 
            else if(current.Children.TryGetValue(character, out var next))
            {
                current = next;
            }
            else
            {
                return false;
            }
        }

        return !checkEndOfWord || current!.IsEndOfWord;
    }
}