namespace PreparingToAlgoritmsInteview;

// Решил сам (за пять минут)
internal class PalindromeNumber_9
{
    public PalindromeNumber_9()
    {
        Console.WriteLine(IsPalindrome(121));
        Console.WriteLine(IsPalindrome(-121));
        Console.WriteLine(IsPalindrome(10));
        Console.WriteLine(IsPalindrome(11));
    }

    public bool IsPalindrome(int x)
    {
        var stringNumber = x.ToString();

        for (int i = 0, j = stringNumber.Length - 1; i < j; i++, j--)
        {
            if (stringNumber[i] != stringNumber[j])
                return false;

            if (i == j)
                break;
        }

        return true;
    }
}
