using Bosscoder.Models;

namespace Bosscoder.List.Homework_Questions
{
    public class RemoveDuplicatesFromLinkedList
    {
        public Node Solve(Node head)
        {
            Node res = head;            

            while(head!= null)
            {
                var curr = head.Val;

                if (head.Next == null)
                    break;

                var next = head.Next;

                if (curr == next.Val)
                {
                    head.Next = head.Next.Next;
                }
                else
                {                   
                    head = head.Next;
                }
            }

            return res;
        }
    }
}
