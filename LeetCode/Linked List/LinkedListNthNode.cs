namespace LeetCode.Linked_List
{
    internal class LinkedListNthNode
    {    
        internal ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode pointerOne = head;
            ListNode pointerTwo = head;
            int counter = 0;

            while (counter < n)
            {               
                pointerOne = pointerOne.Next;
                counter++;
            }

            if (pointerOne == null)
                return head.Next;

            while (pointerOne.Next != null)
            {
                pointerOne = pointerOne.Next;
                pointerTwo = pointerTwo.Next;
            }

            pointerTwo.Next = pointerTwo.Next.Next;

            return head;
        }
    }
}
