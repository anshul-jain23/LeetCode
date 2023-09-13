namespace _1672_Richest_Customer_Wealth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[][] accounts = new int[][] {
            new int[] { 1, 2, 3},
            new int [] { 3,2,1}
            };

            int maxWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                maxWealth = Math.Max(maxWealth, accounts[i].Sum(n => n));
            }

            Console.WriteLine(maxWealth);
            Console.ReadLine();

        }

    }
}