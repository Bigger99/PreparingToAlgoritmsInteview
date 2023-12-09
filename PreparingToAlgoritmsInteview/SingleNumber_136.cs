namespace PreparingToAlgoritmsInteview;

// Решил сам, но не лучшее решение
internal class SingleNumber_136
{
    public SingleNumber_136()
    {
        Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
        Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        Console.WriteLine(SingleNumber(new int[] { 1 }));
    }

    public int SingleNumber(int[] nums)
    {
        var list = new List<int>();

        foreach (int num in nums)
        {
            if (list.Contains(num))
            {
                list.Remove(num);
                continue;
            }

            list.Add(num);
        }

        return list.First();
    }
}
