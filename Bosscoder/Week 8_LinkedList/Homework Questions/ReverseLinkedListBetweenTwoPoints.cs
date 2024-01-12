using Bosscoder.Models;

namespace Bosscoder.Week_8_LinkedList.Homework_Questions
{
    public class ReverseLinkedListBetweenTwoPoints
    {
        public Node Solve(Node head, int left, int right)
        {
            if (head == null || left == right)
            {
                return head;
            }

            Node dummy = new Node(0);
            dummy.Next = head;
            Node prev = dummy;

            // Move prev to the node just before the left position
            for (int i = 1; i < left; i++)
            {
                prev = prev.Next;
            }

            Node current = prev.Next;
            Node next = null;

            // Reverse the nodes from left to right
            for (int i = left; i < right; i++)
            {
                next = current.Next;
                current.Next = next.Next;
                next.Next = prev.Next;
                prev.Next = next;
            }

            return dummy.Next;
        }
    }
}
