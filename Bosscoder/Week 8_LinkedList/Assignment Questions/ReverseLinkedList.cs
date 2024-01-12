using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.Week_8_LinkedList.Assignment_Questions
{
    public class ReverseLinkedList
    {
        public Node Solve(Node head)
        {
            if (head == null)
                return null;

            if (head.Next == null)
                return head;

            Stack<Node> nodes = new Stack<Node>();
            Node res = new Node(0);
            Node final = res;

            while(head != null)
            {
                nodes.Push(head);
                head = head.Next;
            }

            while(nodes.Count != 0)
            {
                res.Next = nodes.Pop();
                res = res.Next;
            }

            res.Next = null;

            return final.Next;
        }
    }
}
