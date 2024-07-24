using Bosscoder.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.List.Assignment_Questions
{
    public class IntersectionOfSortedLinkedLists
    {
        public Node Solve(Node l1, Node l2)
        {
            HashSet<Node> nodes = new HashSet<Node>();

            while(l1 != null)
            {
                nodes.Add(l1);
                l1 = l1.Next;
            }

            while(l2 != null)
            {
                if (nodes.Contains(l2))
                    return l2;

                l2 = l2.Next;
            }

            return null;
        }
    }
}
