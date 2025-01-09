namespace LeetCode.Tests;

public class CountingWordsWithAGivenPrefixTest
{
    [Fact]
    public void PrefixCount_ShouldReturnCorrectCount_WhenPrefixExistsInMultipleWords()
    {
        CountingWordsWithAGivenPrefix solution = new CountingWordsWithAGivenPrefix();
        
        var result = solution.PrefixCount(new[] { "pay", "attention", "practice", "attend" }, "at");

        Assert.Equal(2, result);
    }
    
    [Fact]
    public void PrefixCount_ShouldReturnZero_WhenPrefixDoesNotExistInWords()
    {
        CountingWordsWithAGivenPrefix solution = new CountingWordsWithAGivenPrefix();
        
        var result = solution.PrefixCount(new[] { "leetcode", "win", "loops", "success" }, "code");

        Assert.Equal(0, result);
    }
}