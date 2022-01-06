namespace LeetCode.Linked_List
{
    internal class LinkedListReverse
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode next = null;
            ListNode prev = null;

            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;

            return head;
        }
    }
}
