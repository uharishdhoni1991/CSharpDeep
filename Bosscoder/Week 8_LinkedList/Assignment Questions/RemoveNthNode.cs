using Bosscoder.Models;

namespace Bosscoder.Week_8_LinkedList.Assignment_Questions
{
    public class RemoveNthNode
    {
        //Two pointer apporach
        public Node Solve(Node head, int target)
        {
            Node dummy = new Node(0);
            dummy.Next = head;

            Node fast = dummy;
            Node slow = dummy;

            for(int i =0; i < target; i++)
            {
                fast = fast.Next;
            }

            while(fast?.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            slow.Next = slow.Next.Next;

            return dummy.Next;
        }
    }
}
