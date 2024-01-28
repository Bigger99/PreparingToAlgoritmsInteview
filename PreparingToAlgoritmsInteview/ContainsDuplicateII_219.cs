namespace PreparingToAlgoritmsInteview;

internal class ContainsDuplicateII_219
{
    public ContainsDuplicateII_219()
    {
        Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3));
        Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
        Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
    }

    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]) && i - dict[nums[i]] <= k)
                return true;

            dict[nums[i]] = i;
        }

        return false;
    }
}
