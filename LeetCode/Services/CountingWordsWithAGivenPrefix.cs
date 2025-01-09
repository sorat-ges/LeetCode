namespace LeetCode;

public class CountingWordsWithAGivenPrefix
{
    public int PrefixCount(string[] words, string pref)
    {
        var count = words.Count(word => word.StartsWith(pref));
        return count;
    }
}