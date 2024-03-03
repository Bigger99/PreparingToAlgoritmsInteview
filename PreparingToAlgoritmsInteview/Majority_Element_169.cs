namespace PreparingToAlgoritmsInteview;

internal class Majority_Element_169
{
    public Majority_Element_169()
    {
        Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
        Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
    }

    public int MajorityElement(int[] nums)
    {
        // Моё решение
        if (nums.Length == 0)
            return 0;

        var dict = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num] += num;
            else
                dict.Add(num, num);
        }

        return dict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

        // Лучшее решение
        //Array.Sort(nums);
        //return nums[nums.Length / 2];
    }
}
