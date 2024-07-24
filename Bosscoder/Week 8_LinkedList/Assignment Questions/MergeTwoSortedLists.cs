using Bosscoder.Models;

namespace Bosscoder.List.Assignment_Questions
{
    public class MergeTwoSortedLists
    {
        public Node Solve(Node l1, Node l2)
        {
            if (l1 == null && l2 == null)
                return null;

            Node res = new Node(0);
            Node head = res;

            while(l1 != null && l2 != null)
            {
                if(l1.Val < l2.Val)
                {
                    res.Next = new Node(l1.Val);
                    res = res.Next;
                    l1 = l1.Next;
                }
                else
                {
                    res.Next = new Node(l2.Val);
                    res = res.Next;
                    l2 = l2.Next;
                }
            }

            if (l1 != null)            
                res.Next = l1;            
            else
                res.Next = l2;

            return head.Next;
        }
    }
}
