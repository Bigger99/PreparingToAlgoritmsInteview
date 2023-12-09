namespace PreparingToAlgoritmsInteview;

// До бинарного поиска додумался, но не смог реализовать
internal class SearchInsertPosition_35
{
    public SearchInsertPosition_35()
    {
        var x = 10;
        Console.WriteLine(~x);

        var nums = new int[4] { 1, 3, 5, 6 };
        Console.WriteLine(SearchInsert(nums, 5)); 
        var nums2 = new int[4] { 1, 3, 5, 6 };
        Console.WriteLine(SearchInsert(nums2, 7));
        var nums3 = new int[4] { 1, 3, 5, 6 };
        Console.WriteLine(SearchInsert(nums3, 2));
    }

    public int SearchInsert(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int target, int left, int right)
    {
        if (left > right)
            return left;

        var middleIndex = (left + right) / 2;

        if (nums[middleIndex] == target)
            return middleIndex;
            
        var middleValue = nums[middleIndex];

        if (middleValue > target)
        {
            return BinarySearch(nums, target, left, middleIndex - 1);
        }

        return BinarySearch(nums, target, middleIndex + 1, right);
    }
}
