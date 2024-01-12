using Bosscoder.Models;

namespace Bosscoder.Week_8_LinkedList.Assignment_Questions
{
    public class LinkedListCycle2
    {
        public int Solve(Node head)
        {
            Node slow = head;
            Node fast = head;

            while(fast!= null && fast.Next!=null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    break;
            }

            if (fast == null || fast.Next == null)
                return -1;

            Node newSlow = slow;
            Node newFast = fast;

            while(newSlow != newFast)
            {
                newSlow = newSlow.Next;
                newFast = newFast.Next;
            }

            return newSlow.Val;
        }
    }
}
