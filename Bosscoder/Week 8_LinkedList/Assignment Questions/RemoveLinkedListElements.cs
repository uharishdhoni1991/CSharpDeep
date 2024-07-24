using Bosscoder.Models;

namespace Bosscoder.List.Assignment_Questions
{
    public class RemoveLinkedListElements
    {
        public Node Solve(Node head, int target)
        {
            while (head != null && head.Val == target) head = head.Next;

            if (head == null) return null;

            var node = head;

            while (node.Next != null)
            {
                if (node.Next.Val == target)
                {
                    node.Next = node.Next.Next;
                }
                else node = node.Next;
            }

            return head;
        }
    }
}
