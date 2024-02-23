public class TwoSumTest
{
    private readonly TwoSum _service;
    public TwoSumTest()
    {
        _service = new TwoSum();
    }

    [Fact]
    public void TwoSum_Return_Index_1_2()
    {
        // Given
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;

        // When
        var result = _service.DoProcess(nums, target);

        // Then
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_Return_Index_1_2_WhenTargetIsSix()
    {
        // Given
        int[] nums = new int[] { 3, 2, 4 };
        int target = 6;

        // When
        var result = _service.DoProcess(nums, target);

        // Then
        Assert.Equal(new int[] { 1, 2 }, result);
    }
}