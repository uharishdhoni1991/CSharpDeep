using Bosscoder.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_8_LinkedList.Assignment_Questions
{
    public class CopyListWithRandomPointer
    {
        public NodeRandom Solve(NodeRandom head)
        {
            if (head == null) return null;

            Dictionary<NodeRandom, NodeRandom> oldToNew = new Dictionary<NodeRandom, NodeRandom>();

            NodeRandom curr = head;
            while (curr != null)
            {
                oldToNew[curr] = new NodeRandom(curr.Val);
                curr = curr.Next;
            }

            curr = head;
            while (curr != null)
            {
                oldToNew[curr].Next = curr.Next != null ? oldToNew[curr.Next] : null;
                oldToNew[curr].Random = curr.Random != null ? oldToNew[curr.Random] : null;
                curr = curr.Next;
            }

            return oldToNew[head];
        }
    }
}