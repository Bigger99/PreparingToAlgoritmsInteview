namespace PreparingToAlgoritmsInteview;

// Полностью сам
internal class PlusOne_66
{
	public PlusOne_66()
	{
        foreach (var i in PlusOne(new int[] { 1, 2, 3 }))
            Console.Write(i + ", ");

        Console.WriteLine();

        foreach (var i in PlusOne(new int[] { 4, 3, 2, 1 }))
            Console.Write(i + ", ");

        Console.WriteLine();

        foreach (var i in PlusOne(new int[] { 9 }))
            Console.Write(i + ", ");

        Console.WriteLine();

        foreach (var i in PlusOne(new int[] { 9, 9 }))
            Console.Write(i + ", ");
    }

    public int[] PlusOne(int[] digits)
    {
        var lastIndex = digits.Length - 1;
        var lastNumber = digits[lastIndex];

        if (lastNumber != 9)
        {
            digits[lastIndex]++;
            return digits;
        }

        var isAdd = false;
        digits[lastIndex] = 0;

        for (var i = lastIndex - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i]++;
                isAdd = true;
                break;
            }

            digits[i] = 0;
        }

        if (!isAdd)
        {
            var newArray = new int[digits.Length + 1];
            Array.Copy(digits, 0, newArray, 1, digits.Length);
            digits = newArray;
            digits[0] = 1;
        }

        return digits;
    }
}
