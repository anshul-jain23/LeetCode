namespace LeetCode
{
    internal static class IntSolutions
    {
        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> _412_FizzBuzz(int n)
        {
            IList<string> strArr = new string[n];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        strArr[i - 1] = ("FizzBuzz");
                        continue;
                    }
                    strArr[i - 1] = ("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    strArr[i - 1] = ("Buzz");
                    continue;
                }

                strArr[i - 1] = (i.ToString());
            }

            return strArr;
        }

        /// <summary>
        /// Time Complexity: O(LogN) as we are diving number by 2 so log base 2 N is TC
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int _1342_Steps_to_Reduce_Number_to_Zero(int n)
        {
            int steps = 0;
            while (n != 0 && n > 3)
            {
                steps++;
                if (n % 2 == 0)
                //if ((n & 1) == 0)//isEven number & 000001 if 0 means even otherwise odd, we can also use n%2 == 0
                {
                    n /= 2;
                }
                else
                {
                    n -= 1;
                }
            }

            return steps + n;//if n < 4, n steps will be required to reduce to 0
        }
    }
}
