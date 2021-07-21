using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListBase myLinkedList = new LinkedListBase();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
            myLinkedList.Get(1);              // return 2
            myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
            myLinkedList.Get(1);              // return 3
        }
    }
}
