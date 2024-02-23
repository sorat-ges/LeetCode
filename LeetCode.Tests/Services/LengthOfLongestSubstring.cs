
namespace LeetCode.Tests;

public class LengthOfLongestSubstringTest
{
    private LengthOfLongestSubstring service;
    public LengthOfLongestSubstringTest()
    {
        if (service == null)
        {
            service = new LengthOfLongestSubstring();
        }
    }

    [Fact]
    public void LengthOfLongestSubstring_ShouldReturn_1_WhenValueEqual_a()
    {
        var result = service.DoProcess("a");
        Assert.Equal(1, result);
    }


    [Fact]
    public void LengthOfLongestSubstring_ShouldReturn_2_WhenValueEqual_ab()
    {
        var result = service.DoProcess("ab");
        Assert.Equal(2, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ShouldReturn_1_WhenValueEqual_aa()
    {
        var result = service.DoProcess("aa");
        Assert.Equal(1, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ShouldReturn_3_WhenValueEqual_pwwkew()
    {
        var result = service.DoProcess("pwwkew");
        Assert.Equal(3, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ShouldReturn_4_WhenValueEqual_abac()
    {
        var result = service.DoProcess("abac");
        Assert.Equal(3, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ShouldReturn_3_WhenValueEqual_abcabcbb()
    {
        var result = service.DoProcess("abcabcbb");
        Assert.Equal(3, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_ShouldReturn_6_WhenValueEqual_ggububgvfk()
    {
        var result = service.DoProcess("ggububgvfk");
        Assert.Equal(6, result);
    }
}