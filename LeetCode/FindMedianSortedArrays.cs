using System;

public class FindMedianSortedArrays
{
    public double DoProcess(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        result.AddRange(nums1);
        result.AddRange(nums2);
        result.Sort();
        if (result.Count % 2 == 0)
        {
            int target = result.Count / 2;
            double median = ((double)result[target - 1] + result[target]) / 2.0;
            return median;
        }
        else
        {
            return result[result.Count / 2];
        }
    }
}