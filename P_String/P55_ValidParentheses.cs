namespace Blind75LeetCode;

/// <summary>
/// Valid Parentheses
/// https://leetcode.com/problems/valid-parentheses/
/// </summary>
public class P55_ValidParentheses
{
    public bool IsValid(string s) 
    {
        var stack = new Stack<char>();
        
        foreach (var c in s)
        {
            if (c is '(' or '[' or '{')
                stack.Push(c);
            else if (stack.Count == 0)
                return false;
            else switch (c)
            {
                case ')' when stack.Pop() != '(':
                case ']' when stack.Pop() != '[':
                case '}' when stack.Pop() != '{':
                    return false;
            }
        }
        
        return stack.Count == 0;
    }
}