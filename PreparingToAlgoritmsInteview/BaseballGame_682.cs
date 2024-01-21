namespace PreparingToAlgoritmsInteview;

internal class BaseballGame_682
{
    public BaseballGame_682()
    {
        Console.WriteLine(CalPoints(new string[] { "5", "2", "C", "D", "+" }));
        Console.WriteLine(CalPoints(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }));
        Console.WriteLine(CalPoints(new string[] { "1", "C" }));
    }

    public int CalPoints(string[] operations)
    {
        var tempArr = new List<int>();

        for (var i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out var num))
            {
                tempArr.Add(num);
                continue;
            }

            switch (operations[i])
            {
                case "+":
                    tempArr.Add(tempArr[tempArr.Count - 1] + tempArr[tempArr.Count - 2]);
                    continue;
                case "C":
                    tempArr.RemoveAt(tempArr.Count - 1);
                    continue;
                case "D":
                    tempArr.Add(tempArr[tempArr.Count - 1] * 2);
                    continue;
            }
        }

        var result = 0;

        foreach (var item in tempArr)
            result += item;

        return result;
    }
}
