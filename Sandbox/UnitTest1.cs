using Blind75LeetCode;

namespace Sandbox;

public class SandboxTests
{
    [Fact]
    public void Sandbox()
    {
        P36_MergeIntervals sut = new();
        
        var actual = sut.Merge([[1,4],[0,2],[3,5]]);
        
        Assert.True(actual.SequenceEqual([[0,5]]));
    }
}