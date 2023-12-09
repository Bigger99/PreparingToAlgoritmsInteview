namespace PreparingToAlgoritmsInteview;

// Решил, но не самым оптимальным способом, потом узнал про лучшее решение и реализовал его
internal class MergeSortedArray_88
{
    public MergeSortedArray_88()
    {
        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        Merge(ref nums1, 3, new int[] { 2, 5, 6 }, 3);

        foreach (var item in nums1)
            Console.Write(item);

        Console.WriteLine();

        var nums2 = new int[] { 1 };
        Merge(ref nums2, 1, new int[0], 0);

        foreach (var item in nums2)
            Console.Write(item);

        Console.WriteLine();

        var nums3 = new int[] { 0 };
        Merge(ref nums3, 0, new int[] { 1 }, 1);

        foreach (var item in nums3)
            Console.Write(item);
    }

    public void Merge(ref int[] nums1, int m, int[] nums2, int n)
    {
        var index1 = m - 1;
        var index2 = n - 1;
        var mainIndex = m + n - 1; 

        while (index2 >= 0)
        {
            if (index1 >= 0 && nums1[index1] > nums2[index2])
            {
                nums1[mainIndex] = nums1[index1];
                index1--;
            }
            else
            {
                nums1[mainIndex] = nums2[index2];
                index2--;
            }

            mainIndex--;
        }
    }
}
