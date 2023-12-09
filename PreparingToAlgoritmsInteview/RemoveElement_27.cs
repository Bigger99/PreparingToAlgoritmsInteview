namespace PreparingToAlgoritmsInteview;


// Подсмотрел, но был близок
internal class RemoveElement_27
{
    public RemoveElement_27()
    {
        var nums = new int[] { 3, 2, 2, 3 };
        Console.Write(RemoveElement(nums, 3) + ": ");

        foreach (int i in nums)
            Console.Write(i);

        Console.WriteLine();

        var nums2 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        Console.Write(RemoveElement(nums2, 2) + ": ");

        foreach (int i in nums2)
            Console.Write(i);
    }

    public int RemoveElement(int[] nums, int val)
    {
        int current = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[current] = nums[i];
                current++;
            }
        }
        return current;

        //var count = 0;

        //for (var i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] == val)
        //    {
        //        count++;
        //        var temp = i + 1;

        //        while (temp < nums.Length && nums[temp] == val)
        //        {
        //            temp++;
        //        }

        //        if (temp >= nums.Length)
        //            continue;

        //        var tempValue = nums[i];
        //        nums[i] = nums[temp];
        //        nums[temp] = tempValue;

        //    }
        //}

        //return count;
    }
}
