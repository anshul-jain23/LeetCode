namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please Enter Problem Number...!");
            int pgrmNum = Convert.ToInt32(Console.ReadLine());

            switch (pgrmNum)
            {
                case 383:
                    stringSolutions._383_RansomNote("aa", "aab").PrintLine();
                    stringSolutions._383_RansomNote("aab", "aa").PrintLine();
                    stringSolutions._383_RansomNote("aa", "").PrintLine();
                    stringSolutions._383_RansomNote("", "aab").PrintLine();
                    break;

                case 412:
                    IntSolutions._412_FizzBuzz(15).PrintLine();
                    break;

                case 485:
                    ArraySolutions._485_FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }).PrintLine();
                    ArraySolutions._485_FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 }).PrintLine();
                    break;

                case 876:
                    //Case 1: 6 Nodes
                    var head = LinkedListSolutions.GetNListNodes(6);
                    head.PrintList();
                    Console.WriteLine("middle Node is");
                    LinkedListSolutions._876_MiddleNode(head).PrintLine();

                    //Case 2: 5 Nodes
                    head = LinkedListSolutions.GetNListNodes(5);
                    head.PrintList();
                    Console.WriteLine("middle Node is");
                    LinkedListSolutions._876_MiddleNode(head).PrintLine();

                    //Case 3: 1 Node
                    head = LinkedListSolutions.GetNListNodes(1);
                    head.PrintList();
                    Console.WriteLine("middle Node is");
                    LinkedListSolutions._876_MiddleNode(head).PrintLine();
                    break;

                case 977:
                    ArraySolutions._977_SortedSquares(new int[] { -4, -1, 0, 3, 10 }).PrintLine();
                    ArraySolutions._977_SortedSquares(new int[] { -7, -3, 2, 3, 11 }).PrintLine();
                    break;

                case 1342:
                    IntSolutions._1342_Steps_to_Reduce_Number_to_Zero(123).PrintLine();
                    break;

                case 1480:
                    int[] nums = { 1, 2, 3, 4 };
                    ArraySolutions._1480_RunningSum(nums).PrintLine();
                    break;

                case 1672:
                    int[][] accounts = new int[][] {
                                                    new int[] { 1,5},
                                                    new int [] {7,3},
                                                    new int [] {3,5}
                                                    };
                    ArraySolutions._1672_Richest_Customer_Wealth(accounts).PrintLine();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadLine();
        }
    }
}