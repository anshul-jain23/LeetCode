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

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// Constraint: 1 <= nums[i] <= 100000
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int _1295_FindNumbers(int[] nums) =>
            nums.Where(num => ((num > 9 && num < 100) || (num > 999 && num < 10000) || num == 100000)).Count();

        public static int _1295_FindNumbers(int[] nums, bool usingStringMethod) =>
            nums.Where(num => num.ToString().Length % 2 == 0).Count();

        public static int[] _1089_DuplicateZeros(int[] arr)
        {
            var tempArr = new int[arr.Length];
            Array.Copy(arr, tempArr, arr.Length);

            var index = 0;
            foreach (var num in tempArr)
            {
                if (index < arr.Length)
                {
                    if (num != 0)
                    {
                        arr[index] = num;
                        index++;
                        continue;
                    }
                    arr[index] = 0;
                    index++;
                    if (index < arr.Length)
                    {
                        arr[index] = 0;
                        index++;
                    }
                    continue;
                }
                break;
            }
            return arr;
        }

        /// <summary>
        /// Time Complexity: O(M+N)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] _88_MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0 && n > 0)
            {
                Array.Copy(nums2, nums1, n);
            }

            for (int i = (m + n) - 1; i >= 0; i--)
            {
                var ele1 = m > 0 ? nums1[m - 1] : int.MinValue;
                var ele2 = n > 0 ? nums2[n - 1] : int.MinValue;

                if (ele1 < ele2)
                {
                    nums1[i] = ele2;
                    n--;
                }
                else
                {
                    nums1[i] = ele1;
                    m--;
                }
            }
            return nums1;
        }

        /// <summary>
        /// Time Complexity: O()
        /// Space Complexity: O()
        /// </summary> 3 2 2 3
        public static int _27_RemoveElement(int[] nums, int val)
        {
            int index = 0;
            foreach (var num in nums)
            {
                if (num != val)
                {
                    nums[index] = num;
                    index++;
                }
            }

            return index;
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary> 3 2 2 3
        public static int _26_RemoveDuplicates(int[] nums)
        {
            int index = 0;
            foreach (var num in nums)
            {
                if (index > 0 && nums[index - 1] == num)
                {
                    continue;
                }
                nums[index] = num;
                index++;
            }
            return index;
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(N)
        /// </summary> 
        public static bool _1346_CheckIfDoubleExist(int[] arr)
        {
            var set = new HashSet<double>() { arr[0] };

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0 && set.Contains(arr[i]) || (arr[i] != 0 && set.Contains(arr[i] * 2)))
                    return true;

                set.Add(arr[i]);
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != 0 && set.Contains((double)arr[i] / 2))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary> 
        public static bool _941_ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            int peak = 0;
            int i = 0;
            var len = arr.Length;

            while (i < len - 1 && arr[i + 1] > arr[i])
            {
                peak++;
                i++;
            }

            while (i < len - 1 && arr[i + 1] < arr[i])
            {
                i++;
            }

            if (peak > 0 && peak < len - 1 && i == len - 1)
                return true;

            return false;

        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary> 
        public static int[] _1299_ReplaceWithGreatestElement(int[] arr)
        {
            var greatest = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var temp = arr[i];
                arr[i] = greatest;
                greatest = Math.Max(greatest, temp);
            }
            return arr;
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary> 
        public static int[] _283_MoveZeroes(int[] nums)
        {
            int nonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    if (i != nonZeroIndex)
                    {
                        nums[i] = 0;
                    }
                    nonZeroIndex++;
                }
            }
            return nums;
        }

        /// <summary>
        /// Time Complexity: O( )
        /// Space Complexity: O( )
        /// </summary> 
        /// 0 1
        public static int[] _905_SortArrayByParity(int[] nums)
        {
            var firstPtr = 0;
            while (firstPtr < nums.Length)
            {
                int secPtr = firstPtr;
                while (secPtr < nums.Length && nums[secPtr] % 2 != 0)
                {
                    //untill even number detected
                    secPtr++;
                }

                if (secPtr == nums.Length)
                    break;

                var temp = nums[firstPtr];
                nums[firstPtr] = nums[secPtr];
                nums[secPtr] = temp;


                firstPtr++;
            }
            return nums;
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(k)
        /// </summary> 
        public static int _1051_HeightChecker(int[] heights)
        {
            int k = 0, count = 0, max = 0;
            var arrCounter = new int[101]; // range: 1 to 100

            for (int i = 0; i < heights.Length; i++)
            {
                arrCounter[heights[i]] += 1;
                max = Math.Max(max, heights[i]);
            }

            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j < arrCounter[i]; j++)
                {
                    if (i != heights[k++])
                        count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary> 
        public static int _414_ThirdMax(int[] nums)
        {
            var arrMax = new long[3] { Int64.MinValue, Int64.MinValue, Int64.MinValue };
            foreach (var num in nums)
            {
                if (num == arrMax[0] || num == arrMax[1] || num == arrMax[2])
                    continue;

                long maxNum = num;
                if (maxNum > arrMax[2])
                {
                    (maxNum, arrMax[2]) = (arrMax[2], maxNum);
                }

                if (maxNum > arrMax[1])
                {
                    (maxNum, arrMax[1]) = (arrMax[1], maxNum);
                }

                if (maxNum > arrMax[0])
                {
                    arrMax[0] = maxNum;
                }
            }

            return (int)(arrMax[0] < int.MinValue ? arrMax[2] : arrMax[0]);
        }

        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(N)
        /// </summary> 
        public static IList<int> _448_FindDisappearedNumbers(int[] nums)
        {
            var arrCounter = new int[nums.Length + 1];

            for (var i = 0; i < nums.Length; i++)
            {
                arrCounter[nums[i]] = 1;
            }

            var res = new List<int>();
            for (int i = 1; i < arrCounter.Length; i++)
            {
                if (arrCounter[i] == 0)
                {
                    res.Add(i);
                }
            }
            return res;
        }

    }
}