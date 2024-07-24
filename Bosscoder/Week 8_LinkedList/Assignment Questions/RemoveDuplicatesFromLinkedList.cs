using Bosscoder.Models;

namespace Bosscoder.List.Assignment_Questions
{
    public class RemoveDuplicatesFromLinkedList
    {
        public Node Solve(Node head)
        {
            Node res = head;

            if (head == null)
                return null;

            while(head != null && head.Next != null)
            {
                if (head.Val == head.Next.Val)
                    head.Next = head.Next.Next;
                else
                    head = head.Next;
            }

            return res;
        }
    }
}
