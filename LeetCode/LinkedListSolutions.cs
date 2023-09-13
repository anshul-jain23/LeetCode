namespace LeetCode
{
    internal static class LinkedListSolutions
    {
        /// <summary>
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode _876_MiddleNode(ListNode head)
        {
            ListNode firstPtr = head;
            ListNode secondPtr = head;

            while (secondPtr.next != null)
            {
                firstPtr = firstPtr.next;
                secondPtr = secondPtr.next;
                if (secondPtr.next != null)
                {
                    secondPtr = secondPtr.next;
                }
            }
            return firstPtr;

        }

        public static ListNode GetNListNodes(int n)
        {
            if (n < 1)
                return null;

            ListNode head = new();
            ListNode ptr = head;
            for (int i = 1; i <= n; i++)
            {
                ptr.val = i;
                if (i < n)
                {
                    ptr.next = new ListNode();
                    ptr = ptr.next;
                }
            }

            return head;
        }
    }
}
