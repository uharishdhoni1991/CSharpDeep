namespace LeetCode.Linked_List
{
    internal class LinkedListIntersection
    {        
        internal ListNode HeadOne { get; set; }
        internal ListNode HeadTwo { get; set; }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            ListNode pointerOne = headA;
            ListNode pointerTwo = headB;

            while (pointerOne != pointerTwo)
            {
                pointerOne = pointerOne != null ? pointerOne.Next : headB;
                pointerTwo = pointerTwo != null ? pointerTwo.Next : headA;
            }

            return pointerOne;
        }
    }
}
