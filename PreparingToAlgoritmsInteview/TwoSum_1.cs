// Изначально решил по другому, но полностью сам. Потом подглядел про это решение и оно понравилось больше всех
namespace PreparingToAlgoritmsInteview;

internal class TwoSum_1
{
    public TwoSum_1()
    {
        var nums = new int[] { 2, 7, 11, 15 };
        Console.WriteLine(TwoSum(nums, 9));
    }
        
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (dict.ContainsKey(diff))
            {
                return new int[] { dict[diff], i };
            }
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        return new int[] { 0, 0 };
    }
}
