namespace LeetCode;
public class LengthOfLongestSubstring
{
    public int DoProcess(string s)
    {
        string maxCharactor = string.Empty;
        string currentCharactor = string.Empty;
        char[] charactor = s.ToCharArray();

        for (int i = 0; i <= s.Length - 1; i++)
        {
            currentCharactor = charactor[i].ToString();
            if (currentCharactor.Length >= maxCharactor.Length)
            {
                maxCharactor = currentCharactor;
            }
            if (currentCharactor.Length + (s.Length - 1 - i) <= maxCharactor.Length)
            {
                return maxCharactor.Length;
            }
            for (int next = i + 1; next <= s.Length - 1; next++)
            {
                if (!currentCharactor.Contains(charactor[next]))
                {
                    currentCharactor += charactor[next];
                    if (currentCharactor.Length >= maxCharactor.Length)
                    {
                        maxCharactor = currentCharactor;
                    }
                }
                else
                {
                    if (currentCharactor.Length >= maxCharactor.Length)
                    {
                        maxCharactor = currentCharactor;
                    }
                    break;
                }
            }
        }
        return maxCharactor.Length;
    }
}
