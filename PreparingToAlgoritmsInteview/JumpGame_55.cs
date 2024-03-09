namespace PreparingToAlgoritmsInteview;

internal class JumpGame_55
{
    public JumpGame_55()
    {
        Console.WriteLine(CanJump([2, 3, 1, 1, 4]));
        Console.WriteLine(CanJump([3, 2, 1, 0, 4]));
        Console.WriteLine(CanJump([1]));
        Console.WriteLine(CanJump([0, 1]));
        Console.WriteLine(CanJump([1, 0, 2]));
    }

    public bool CanJump(int[] nums)
    {
        return false;
        //var sum = 0;

        //while (true)
        //{
        //    sum += nums[i];
        //}

        //var sum = 0;

        //for (int i = 0; i < nums.Length;)
        //{
        //    if (nums[i] == 0 && (sum < nums.Length - 1))
        //        return false;

        //    sum += nums[i];

        //    if (sum > nums.Length) 
        //        return false;

        //    if (sum == nums.Length || sum == nums.Length - 1) 
        //        return true;

        //    i += nums[i];
        //}

        //return false;

        //var index = 0;

        //while (index < nums.Length)
        //{
        //    var currentValue = nums[index];
        //    var nextIndex = nums[index] + index;

        //    if (nextIndex == nums.Length - 1)
        //        return true;

        //    index = nextIndex;

        //    if (currentValue == 0 && currentValue != nums.Length - 1)
        //        return false;
        //}

        //return false;
    }
}
