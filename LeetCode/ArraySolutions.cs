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

        /// <summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] _977_SortedSquares(int[] nums)
        {
            var op = new int[nums.Length];
            var ptr1 = 0;
            var ptr2 = nums.Length - 1;

            for (int i = op.Length - 1; i >= 0 && (ptr1 <= ptr2); i--)
            {
                var sq1 = nums[ptr1] * nums[ptr1];
                var sq2 = nums[ptr2] * nums[ptr2];

                if (sq1 < sq2)
                {
                    op[i] = sq2;
                    ptr2--;
                }
                else
                {
                    op[i] = sq1;
                    ptr1++;
                }
            }
            return op;
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int _485_FindMaxConsecutiveOnes(int[] nums)
        {
            int ptr1 = 0, ptr2 = 0;
            int maxLength = 0;

            while (ptr2 < nums.Length)
            {
                if (nums[ptr2] != 1)
                {
                    maxLength = Math.Max(maxLength, ptr2 - ptr1);
                    ptr2++;
                    ptr1 = ptr2;
                    continue;
                }
                ptr2++;
            }
            maxLength = Math.Max(maxLength, ptr2 - ptr1);
            return maxLength;

        }
    }
}