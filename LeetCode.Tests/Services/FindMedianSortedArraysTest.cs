public class FindMedianSortedArraysTest
{
    private readonly FindMedianSortedArrays service;
    public FindMedianSortedArraysTest()
    {
        service = new FindMedianSortedArrays();
    }

    [Fact]
    public void FindMedianSortedArrays_ShouldReturn2_WhenInputIs_OneTwoThree()
    {
        // Given

        // When
        var result = service.DoProcess(new int[] { 1, 3 }, new int[] { 2 });

        // Then
        Assert.Equal(2, result);
    }

    [Fact]
    public void FindMedianSortedArrays_ShouldReturn2point5_WhenInputIs_1_2_3_4()
    {
         // Given

        // When
        var result = service.DoProcess(new int[] { 1, 2 }, new int[] { 3 ,4});

        // Then
        Assert.Equal(2.5, result);
    }

}