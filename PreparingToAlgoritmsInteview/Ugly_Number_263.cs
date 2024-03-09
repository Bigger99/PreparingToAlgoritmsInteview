namespace PreparingToAlgoritmsInteview;

internal class Ugly_Number_263
{
    public Ugly_Number_263()
    {
        Console.WriteLine(IsUgly(6));
        Console.WriteLine(IsUgly(1));
        Console.WriteLine(IsUgly(14));
        Console.WriteLine(IsUgly(0));
    }

    public bool IsUgly(int n)
    {
        if (n == 0)
            return false;

        if (n == 1) 
            return true;

        if (n % 5 == 0)
            return IsUgly(n / 5);

        if (n % 3 == 0)
            return IsUgly(n / 3);

        if (n % 2 == 0)
            return IsUgly(n / 2);

        return false;
    }
}
