namespace LeetCode;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s; // Special case
        
        var result = new string[numRows];
        var row = 0;
        var direction = 1;

        foreach (var c in s.ToCharArray())
        {
            result[row] += c.ToString();
            if (row == numRows - 1)
            {
                direction = -1;
            }
            if (row == 0)
            {
                direction = 1;
            }
            row += direction;
        }
       
        return string.Join("", result);
    }
}