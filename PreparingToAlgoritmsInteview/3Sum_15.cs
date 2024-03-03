using System;

namespace PreparingToAlgoritmsInteview;

internal class _3Sum_15
{
    public _3Sum_15()
    {
        Write(ThreeSum(new[] { -1, 0, 1, 2, -1, -4 }));
        Write(ThreeSum(new[] { 0, 1, 1 }));
        Write(ThreeSum(new[] { 0, 0, 0 }));
    }

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var resultList = new List<IList<int>>();
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            var left = i + 1;
            var right = nums.Length - 1;

            if (current == nums[left] || nums[left] == nums[right])
            {
                left++;
            }
            else if ( current == nums[right])
            {
                right++;
            }
        }

        return null;
    }

    private static void Write(IList<IList<int>> nums)
    {
        foreach (var subArr in nums)
        {
            foreach (var item in subArr)
            {
                Console.Write("[");
                Console.WriteLine(item);
                Console.Write("]");
            }
        }
    }
}
