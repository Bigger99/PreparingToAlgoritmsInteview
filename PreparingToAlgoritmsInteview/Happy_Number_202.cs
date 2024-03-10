using System.Collections.Generic;
using System.Linq;

namespace PreparingToAlgoritmsInteview;

internal class Happy_Number_202
{
    public Happy_Number_202()
    {
        Console.WriteLine(IsHappy(19));
        Console.WriteLine(IsHappy(2));
    }

    public bool IsHappy(int n)
    {
        var hashSet = new HashSet<double>();

        var total = PowNum(0, n, hashSet);

        return total == 1;
    }

    private double PowNum(double total, double n, HashSet<double> hashSet)
    {
        var strNum = n.ToString();

        var totalTemp = 0d;

        foreach (var item in strNum)
            totalTemp += Math.Pow(int.Parse(item.ToString()), 2);

        if (totalTemp == total)
            return totalTemp / total;

        total = totalTemp;

        if (hashSet.Contains(total))
            return 0;

        hashSet.Add(total);

        return PowNum(total, total, hashSet);
    }
}
