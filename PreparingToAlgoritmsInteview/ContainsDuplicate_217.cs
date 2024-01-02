namespace PreparingToAlgoritmsInteview;

internal class ContainsDuplicate_217
{
    public ContainsDuplicate_217()
    {
        var nums = new int[] { 1, 2, 3, 1 };
        Console.Write(ContainsDuplicate(nums));

        var nums2 = new int[] { 1, 2, 3, 4 };
        Console.Write(ContainsDuplicate(nums2));

        var nums3 = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Console.Write(ContainsDuplicate(nums3));
    }

    public bool ContainsDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
                return true;

            dict.Add(num, 1);
        }

        return false;
    }
}
