namespace PreparingToAlgoritmsInteview;

internal class PascalsTriangleII_119
{
    public PascalsTriangleII_119()
    {
        var res = GetRow(3);

        foreach (var item in res)
        {
            Console.Write(item + " ");
        }
    }

    public IList<int> GetRow(int rowIndex)
    {
        rowIndex++;

        var result = new List<IList<int>>
        {
            new List<int> { 1 }
        };

        for (int i = 1; i < rowIndex; i++)
        {
            var lastArr = result.Last();
            var subArr = new List<int>(i) { 1 };

            for (var j = 1; j < lastArr.Count; j++)
                subArr.Add(lastArr[j - 1] + lastArr[j]);

            subArr.Add(1);
            result.Add(subArr);
        }

        return result[rowIndex - 1];
    }
}
