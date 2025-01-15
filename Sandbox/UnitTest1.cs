using Blind75LeetCode;

namespace Sandbox;

public class SandboxTests
{
    [Fact]
    public void Sandbox()
    {
        P53_ValidAnagram validAnagram = new();
        
        Assert.True(validAnagram.IsAnagram("anagram", "nagaram"));
    }
}