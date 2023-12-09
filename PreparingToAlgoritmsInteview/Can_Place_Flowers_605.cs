namespace PreparingToAlgoritmsInteview;

internal class Can_Place_Flowers_605
{
    public Can_Place_Flowers_605()
    {
        var arr1 = new[] { 1, 0, 0, 0, 1 };
        Console.WriteLine(CanPlaceFlowers(arr1, 1)); 
        var arr2 = new[] { 1, 0, 0, 0, 1 };
        Console.WriteLine(CanPlaceFlowers(arr2, 2));

        var arr3 = new[] { 1, 0, 0, 0, 0, 1 };
        Console.WriteLine(CanPlaceFlowers(arr3, 2));

        var arr4 = new[] { 1, 0, 0, 0, 1, 0, 1 };
        Console.WriteLine(CanPlaceFlowers(arr4, 1));       

        var arr5 = new[] { 0, 0, 1, 0, 1 };
        Console.WriteLine(CanPlaceFlowers(arr5, 1));

        var arr6 = new[] { 1, 0, 0, 0, 1, 0, 0 };
        Console.WriteLine(CanPlaceFlowers(arr6, 2));

        var arr7 = new[] { 0 };
        Console.WriteLine(CanPlaceFlowers(arr7, 1));
    }

    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed is null || flowerbed.Length <= 0)
            return false;

        if (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1)
            return true;

        if (n == 0)
            return true;

        var lenght = flowerbed.Length;
        int prevNum = -1;

        for (var i = 0; i < flowerbed.Length; i++)
        {
            var currentNum = flowerbed[i];

            if (i + 1 > lenght - 1)
            {
                if (prevNum == 0 && currentNum == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }

                break;
            }
                

            var newxtNum = flowerbed[i + 1];

            if (prevNum == 0 && newxtNum == 0 && currentNum == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
            else if (prevNum == -1 && newxtNum == 0 && currentNum == 0)
            {
                flowerbed[i] = 1;
                n--;
            }

            if (n == 0)
                break;

            prevNum = flowerbed[i];
        }

        if (n == 0)
            return true;

        return false;

    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}