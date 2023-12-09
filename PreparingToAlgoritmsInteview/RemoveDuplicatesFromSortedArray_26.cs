namespace PreparingToAlgoritmsInteview;

// Подсмотрел, но был близок
internal class RemoveDuplicatesFromSortedArray_26
{
    public RemoveDuplicatesFromSortedArray_26()
    {
        Console.WriteLine(RemoveDuplicates(new int[3] { 1, 1, 2 }));
        Console.WriteLine(RemoveDuplicates(new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
    }

    public int RemoveDuplicates(int[] nums)
    {
        var k = 1;
        var prevValue = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != prevValue)
            {
                nums[k] = nums[i];
                k++;
            }

            prevValue = nums[i];
        }

        return k;
    }
}
