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
                case 26:
                    ArraySolutions._26_RemoveDuplicates(new int[] { 1, 1, 1, 2 }).PrintLine();
                    ArraySolutions._26_RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }).PrintLine();

                    break;
                case 27:
                    ArraySolutions._27_RemoveElement(new int[] { 3, 2, 2, 3 }, 3).PrintLine();
                    break;
                case 88:
                    ArraySolutions._88_MergeSortedArray(new int[] { 2, 0 }, 1, new int[] { 1 }, 1).PrintLine();
                    ArraySolutions._88_MergeSortedArray(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3).PrintLine();
                    ArraySolutions._88_MergeSortedArray(new int[] { 1 }, 1, Array.Empty<int>(), 0).PrintLine();
                    ArraySolutions._88_MergeSortedArray(new int[] { 0 }, 0, new int[] { 1 }, 1).PrintLine();
                    break;

                case 283:
                    ArraySolutions._283_MoveZeroes(new int[] { 0, 1, 0, 3, 12 }).PrintLine();
                    ArraySolutions._283_MoveZeroes(new int[] { 0 }).PrintLine();
                    break;

                case 383:
                    stringSolutions._383_RansomNote("aa", "aab").PrintLine();
                    stringSolutions._383_RansomNote("aab", "aa").PrintLine();
                    stringSolutions._383_RansomNote("aa", "").PrintLine();
                    stringSolutions._383_RansomNote("", "aab").PrintLine();
                    break;

                case 412:
                    IntSolutions._412_FizzBuzz(15).PrintLine();
                    break;

                case 414:
                    ArraySolutions._414_ThirdMax(new int[] { 1, 2, -2147483648 }).PrintLine(-2147483648);
                    ArraySolutions._414_ThirdMax(new int[] { 1, 2 }).PrintLine(2);
                    ArraySolutions._414_ThirdMax(new int[] { -64, -100, 0, 1, 56 }).PrintLine(0);
                    ArraySolutions._414_ThirdMax(new int[] { -64, -100 }).PrintLine(-64);
                    ArraySolutions._414_ThirdMax(new int[] { 0, 1, 2, 3, 2, 1, 2 }).PrintLine(1);
                    break;

                case 448:
                    ArraySolutions._448_FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }).PrintLine(new int[] { 5, 6 });
                    ArraySolutions._448_FindDisappearedNumbers(new int[] { 0 }).PrintLine(new int[] { 1 });
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

                case 905:
                    ArraySolutions._905_SortArrayByParity(new int[] { 0, 1 }).PrintLine();
                    ArraySolutions._905_SortArrayByParity(new int[] { 0, 1, 2 }).PrintLine();
                    break;

                case 941:
                    ArraySolutions._941_ValidMountainArray(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }).PrintLine();
                    ArraySolutions._941_ValidMountainArray(new int[] { 9, 5, 4, 2, 1 }).PrintLine();
                    ArraySolutions._941_ValidMountainArray(new int[] { 0, 3, 2, 1 }).PrintLine();
                    ArraySolutions._941_ValidMountainArray(new int[] { 0, 2, 3, 3, 5, 2, 1, 0 }).PrintLine();
                    break;

                case 977:
                    ArraySolutions._977_SortedSquares(new int[] { -4, -1, 0, 3, 10 }).PrintLine();
                    ArraySolutions._977_SortedSquares(new int[] { -7, -3, 2, 3, 11 }).PrintLine();
                    break;

                case 1051:
                    ArraySolutions._1051_HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 }).PrintLine();
                    ArraySolutions._1051_HeightChecker(new int[] { 5, 1, 2, 3, 4 }).PrintLine();
                    ArraySolutions._1051_HeightChecker(new int[] { 1, 2, 3, 4, 5 }).PrintLine();
                    break;

                case 1089:
                    ArraySolutions._1089_DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }).PrintLine();
                    break;

                case 1295:
                    ArraySolutions._1295_FindNumbers(new int[] { 12, 345, 2, 6, 7896 }).PrintLine();
                    ArraySolutions._1295_FindNumbers(new int[] { 555, 901, 482, 1771 }).PrintLine();
                    break;

                case 1299:
                    ArraySolutions._1299_ReplaceWithGreatestElement(new int[] { 17, 18, 5, 4, 6, 1 }).PrintLine();
                    ArraySolutions._1299_ReplaceWithGreatestElement(new int[] { 400 }).PrintLine();
                    break;

                case 1342:
                    IntSolutions._1342_Steps_to_Reduce_Number_to_Zero(123).PrintLine();
                    break;

                case 1346:
                    ArraySolutions._1346_CheckIfDoubleExist(new int[] { 10, 2, 2, 3 }).PrintLine();
                    ArraySolutions._1346_CheckIfDoubleExist(new int[] { 10, 2, 5, 3 }).PrintLine();
                    ArraySolutions._1346_CheckIfDoubleExist(new int[] { -2, 0, 10, -19, 4, 6, -8 }).PrintLine();
                    ArraySolutions._1346_CheckIfDoubleExist(new int[] { 7, 1, 14, 11 }).PrintLine();
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