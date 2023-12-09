namespace PreparingToAlgoritmsInteview;

// Решил сам, минут за 30
internal class MedianOfTwoSortedArrays_4
{
    public MedianOfTwoSortedArrays_4()
    {
        Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));
        Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3,4 }));
        Console.WriteLine(FindMedianSortedArrays(new int[0], new int[] { 1 }));
        Console.WriteLine(FindMedianSortedArrays(new int[0], new int[] { 1, 2, 3, 4, 5 }));
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var mergedArray = new int[nums1.Length + nums2.Length];
        var nums1Index = 0;
        var nums2Index = 0;

        // Merge two arrays
        for (var i = 0; i < mergedArray.Length; i++)
        {
            var value1 = 0;
            var value2 = 0;

            if (nums1Index < nums1.Length && nums2Index < nums2.Length)
            {
                value1 = nums1[nums1Index];
                value2 = nums2[nums2Index];
            }
            else if (nums1Index < nums1.Length)
            {
                value1 = nums1[nums1Index];
                value2 = value1 + 1;
            }
            else if(nums2Index < nums2.Length)
            {
                value2 = nums2[nums2Index];
                value1 = value2 + 1;
            }

            if (value1 > value2)
            {
                mergedArray[i] = value2;
                nums2Index++;
            }
            else
            {
                mergedArray[i] = value1;
                nums1Index++;
            }
        }

        if (mergedArray.Length == 1)
            return mergedArray[0];

        if (mergedArray.Length % 2 == 0)
        {
            var mid = mergedArray.Length / 2;
            return (double)(mergedArray[mid] + mergedArray[mid - 1]) / 2;
        }

        var middle = mergedArray.Length / 2;
        return mergedArray[middle];
    }
}
