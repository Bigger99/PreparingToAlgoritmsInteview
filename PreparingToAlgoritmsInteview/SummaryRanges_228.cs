namespace PreparingToAlgoritmsInteview;

internal class SummaryRanges_228
{
    public SummaryRanges_228()
    {
        var arr1 = new[] { 0, 1, 2, 4, 5, 7 };
        foreach (var i in SummaryRanges(arr1))
            Console.WriteLine(i);

        var arr2 = new[] { 0, 2, 3, 4, 6, 8, 9 };
        foreach (var i in SummaryRanges(arr2))
            Console.WriteLine(i);

        var arr3 = new[] { -1 };
        foreach (var i in SummaryRanges(arr3))
            Console.WriteLine(i);
    }

    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
            return (IList<string>)Enumerable.Empty<string>();

        var list = new List<string>();
        int firstNum = nums[0];
        int lastNum = nums[0];

        if (nums.Length == 1)
            return new List<string>() { nums[0].ToString() };

        for (int i = 1; i < nums.Length; i++)
        {
            var currentNum = nums[i];

            if (currentNum > lastNum + 1)
            {
                if (firstNum == lastNum)
                    list.Add($"{firstNum}");
                else
                    list.Add($"{firstNum}->{lastNum}");

                firstNum = currentNum;
            }

            lastNum = currentNum;

            if (currentNum == nums[nums.Length - 1])
            {
                if (firstNum == currentNum)
                    list.Add($"{firstNum}");
                else
                    list.Add($"{firstNum}->{currentNum}");
            }
        }

        return list;
    }
}
