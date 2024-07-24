using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.List.Assignment_Questions
{
    public class LinkedListCycle
    {
        public bool HasCycle(Node head)
        {
            HashSet<Node> hash = new HashSet<Node>();

            while(head != null)
            {
                if (hash.Contains(head))
                    return true;

                hash.Add(head);
                head = head.Next;
            }

            return false;
        }
    }
}
