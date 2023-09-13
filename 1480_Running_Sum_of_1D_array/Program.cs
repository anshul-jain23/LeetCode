using Common;

namespace _1480_Running_Sum_of_1D_array;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 1, 2, 3, 4 };
        RunningSum(nums).PrintLine();
        Console.ReadLine();
    }

    /// <summary>
    /// Time COmplexity: O(N)
    /// Space Complexity: O(1) as no other space is used
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    static int[] RunningSum(int[] nums)
    {
        if (nums.Length < 1)
            return new int[] { 0 };

        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }
        return nums;
    }


}
