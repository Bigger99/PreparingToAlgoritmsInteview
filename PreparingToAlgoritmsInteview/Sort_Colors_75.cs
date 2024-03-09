namespace PreparingToAlgoritmsInteview;

internal class Sort_Colors_75
{
    public Sort_Colors_75()
    {
        var arr1 = new int[] { 2, 0, 2, 1, 1, 0 };
        SortColors(arr1);
        Console.WriteLine($"Sorted array: {string.Join(',', arr1)}");

        var arr2 = new int[] { 2, 0, 1 };
        SortColors(arr2);
        Console.WriteLine($"Sorted array: {string.Join(',', arr2)}");
    }

    public void SortColors(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
    }

    private void QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            var pivotPosition = GetPivotPosition(array, leftIndex, rightIndex);
            QuickSort(array, leftIndex, pivotPosition - 1);
            QuickSort(array, pivotPosition + 1, rightIndex);
        }
    }

    private int GetPivotPosition(int[] array, int leftIndex, int rightIndex)
    {
        var pivotIndex = leftIndex - 1;
        var pivot = array[rightIndex];

        for (var i = leftIndex; i < rightIndex; i++)
        {
            if (array[i] < pivot)
            {
                pivotIndex++;
                Swap(ref array[pivotIndex], ref array[i]);
            }
        }

        pivotIndex++;
        Swap(ref array[pivotIndex], ref array[rightIndex]);
        return pivotIndex;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Реализация быстрой сортировки, которое я нашёл в интернете, а выше решение которое я сам написал, после того как освежил в голове алгоритм быстрой сортировки

    //public static void Sort(int[] array, int left, int right)
    //{
    //    if (left < right) 
    //    {
    //        var indexPivot = Partition(array, left, right);
    //        Sort(array, left, indexPivot - 1);
    //        Sort(array, indexPivot + 1, right);
    //    }
    //}

    //public static int Partition(int[] array, int left, int right)
    //{
    //    var pivot = array[right];
    //    var pivotIndex = left - 1;

    //    for (var i = left; i < right; i++ )
    //    {
    //        if (array[i] < pivot)
    //        {
    //            pivotIndex++;
    //            Swap(ref array[pivotIndex], ref array[i]);
    //        }
    //    }

    //    pivotIndex++;
    //    Swap(ref array[right], ref array[pivotIndex]);
    //    return pivotIndex;
    //}

    //public static void Swap(ref int a, ref int b)
    //{
    //    int temp = a;
    //    a = b;
    //    b = temp;
    //}
}
