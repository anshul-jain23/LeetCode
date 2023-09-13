namespace LeetCode
{
    public static class ArraySolutions
    {
        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] _1480_RunningSum(int[] nums)
        {
            if (nums.Length < 1)
                return new int[] { 0 };

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }
            return nums;
        }

        /// <summary>
        /// Time Complexity: O(m*n)
        /// Space Complexity: O(1)
        /// </summary>
        public static int _1672_Richest_Customer_Wealth(int[][] accounts)
        {
            int maxWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                maxWealth = Math.Max(maxWealth, accounts[i].Sum(n => n));
            }
            return maxWealth;
        }
    }
}