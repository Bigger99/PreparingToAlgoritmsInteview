namespace PreparingToAlgoritmsInteview;

internal class PascalsTriangle_118
{
    public PascalsTriangle_118()
    {
        var res = Generate(5);

        foreach (var arr in res)
        {
            foreach (var item in arr)
                Console.Write(item + " ");

            Console.WriteLine();
        }
    }

    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>
        {
            new List<int> { 1 }
        };

        for (int i = 1; i < numRows; i++)
        {
            var lastArr = result.Last();
            var subArr = new List<int>(i) { 1 };

            for (var j = 1; j < lastArr.Count; j++)
                subArr.Add(lastArr[j - 1] + lastArr[j]);

            subArr.Add(1);
            result.Add(subArr);
        }

        return result;
    }
}
