using Bosscoder.Models;

namespace Bosscoder.Week_8_LinkedList.Assignment_Questions
{
    public class MergeSortedLinkedLists
    {
        public Node Solve(Node l1, Node l2)
        {
            // maintain an unchanging reference to node ahead of the return node.
            Node prehead = new Node(-1);

            Node prev = prehead;
            while (l1 != null && l2 != null)
            {
                if (l1.Val <= l2.Val)
                {
                    prev.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    prev.Next = l2;
                    l2 = l2.Next;
                }
                prev = prev.Next;
            }

            // At least one of l1 and l2 can still have nodes at this point, so connect
            // the non-null list to the end of the merged list.
            prev.Next = l1 == null ? l2 : l1;

            return prehead.Next;
        }    
    }
}
