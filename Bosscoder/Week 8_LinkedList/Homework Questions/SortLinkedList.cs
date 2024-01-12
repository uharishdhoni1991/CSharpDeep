using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.Week_8_LinkedList.Homework_Questions
{
    //Todo : Using Merge sort
    public class SortLinkedList
    {
        public Node Solve(Node head)
        {
            if (head == null)
                return null;

            List<int> list = new List<int>();

            while(head != null)
            {
                list.Add(head.Val);

                head = head.Next;
            }

            list.Sort();

            Node res = new Node(0);
            head = res;

            foreach(var ele in list)
            {
                Node curr = new Node(ele);
                res.Next = curr;
                res = res.Next;
            }

            return head.Next;
        }
    }
}