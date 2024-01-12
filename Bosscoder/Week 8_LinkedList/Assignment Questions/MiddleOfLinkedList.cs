using Bosscoder.Models;

namespace Bosscoder.Week_8_LinkedList.Assignment_Questions
{
    public class MiddleOfLinkedList
    {
        public int Solve(Node head)
        {
            Node slowPointer = head;
            Node fastPointer = head;

            while(slowPointer.Next != null && fastPointer.Next != null && fastPointer.Next.Next != null)
            {
                fastPointer = head.Next.Next;
                slowPointer = head.Next;
            }

            return slowPointer.Val;
        }
    }
}