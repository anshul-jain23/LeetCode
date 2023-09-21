namespace LeetCode
{
    public static class CommonMethods
    {

        public static void PrintLine(this bool value)
        {
            Console.WriteLine(value ? "True" : "False");
        }

        public static void Print(this int[] nums)
        {
            Console.Write(string.Join(" ", nums));
        }

        public static void PrintLine(this int[] nums)
        {
            nums.Print();
            Console.WriteLine();
        }

        public static void Print(this IList<string> list)
        {
            Console.Write(string.Join(" ", list));
        }

        public static void PrintLine(this IList<string> list)
        {
            list.Print();
            Console.WriteLine();
        }

        public static void PrintLine(this int num)
        {
            Console.WriteLine(num);
        }
        public static void PrintLine(this int num, int result)
        {
            Console.WriteLine($"Output: {num}");
            Console.WriteLine($"Expected Output: {result}");
            Console.WriteLine();
        }

        public static void PrintLine(this IList<int> result)
        {
            Console.WriteLine($"Output: {string.Join(" ", result)}");
        }

        public static void PrintLine(this IList<int> result, IList<int> expected)
        {
            Console.WriteLine($"Output: {string.Join(" ", result)}");
            Console.WriteLine($"Expected Output: {string.Join(" ", expected)}");
            Console.WriteLine();
        }

        public static void Print(this ListNode head)
        {
            Console.Write(head.val);
        }
        public static void PrintLine(this ListNode head)
        {
            head.Print();
            Console.WriteLine();
        }

        public static void PrintList(this ListNode head)
        {
            while (head != null)
            {
                head.Print();
                if (head.next != null)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
                head = head.next;
            }
        }
    }
}
