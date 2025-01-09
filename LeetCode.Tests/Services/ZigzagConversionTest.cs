namespace LeetCode.Tests;

public class ZigzagConversionTest
{
    [Fact]
    public void ZigzagConversion_ShouldReturnCorrectResult_WhenNumRowsIs3()
    {
        // Arrange
        var solution = new ZigzagConversion();
        string input = "PAYPALISHIRING";
        int numRows = 3;
        string expectedOutput = "PAHNAPLSIIGYIR";

        // Act
        string result = solution.Convert(input, numRows);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
    
    [Fact]
    public void ZigzagConversion_ShouldHandleEmptyString()
    {
        // Arrange
        var solution = new ZigzagConversion();
        string input = "";
        int numRows = 3;
        string expectedOutput = "";

        // Act
        string result = solution.Convert(input, numRows);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void ZigzagConversion_ShouldReturnOriginalString_WhenStringLengthIsLessThanNumRows()
    {
        // Arrange
        var solution = new ZigzagConversion();
        string input = "AB";
        int numRows = 5;
        string expectedOutput = "AB";

        // Act
        string result = solution.Convert(input, numRows);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
    
    [Fact]
    public void Convert_ShouldReturnOriginalString_WhenNumRowsIs1()
    {
        // Arrange
        var solution = new ZigzagConversion();
        string input = "AB";
        int numRows = 1;
        string expectedOutput = "AB";

        // Act
        string result = solution.Convert(input, numRows);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
}