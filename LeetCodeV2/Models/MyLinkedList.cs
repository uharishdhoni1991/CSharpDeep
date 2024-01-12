using System;
using System.Text;

namespace LeetCodeV2.Models
{
    public class MyLinkedList
    {
        public SingleListNode Head { get; set; }

        public MyLinkedList()
        {
            Head = null;
        }

        public void AddAtHead(int val)
        {
            SingleListNode cur = new SingleListNode(val);
            cur.Next = Head;
            Head = cur;
        }

        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                AddAtHead(val);
                return;
            }

            SingleListNode prev = GetTail();
            SingleListNode cur = new SingleListNode(val);
            prev.Next = cur;
        }

        public void DeleteNode(int index)
        {
            SingleListNode node = GetNodeAt(index);

            if (node == null)
                return;

            SingleListNode next = node.Next;

            if (index == 0)
            {
                Head = next;
            }
            else
            {
                SingleListNode prev = GetNodeAt(index - 1);
                prev.Next = next;
            }
        }

        public SingleListNode GetNodeAt(int index)
        {
            SingleListNode cur = Head;

            for (int i = 0; i < index && cur.Next != null; ++i)
            {
                cur = cur.Next;
            }

            return cur;
        }

        public SingleListNode GetTail()
        {
            SingleListNode cur = Head;

            while (cur.Next != null)
            {
                cur = cur.Next;
            }

            return cur;
        }

        public SingleListNode ReverseLinkedList()
        {
            if (Head == null)
                return null;

            SingleListNode currentHead = Head;

            while (Head.Next != null)
            {
                SingleListNode pointer = Head.Next;
                Head.Next = pointer.Next;
                pointer.Next = currentHead;
                currentHead = pointer;
            }

            return currentHead;
        }

        public SingleListNode RemoveLinkedListElements(SingleListNode head, int val)
        {
            if (head == null) 
                return null;

            head.Next = RemoveLinkedListElements(head.Next, val);
            return (head.Val == val) ? head.Next : head;
        }

        public SingleListNode OddEvenLinkedList(SingleListNode head)
        {
            if (head == null || head.Next == null)
                return head;
            
            SingleListNode oddPointer = head;
            SingleListNode evenPointer = head.Next;
            SingleListNode even = head.Next;

            while (evenPointer != null && evenPointer.Next != null)
            {
                oddPointer.Next = evenPointer.Next;
                oddPointer = oddPointer.Next;
                evenPointer.Next = oddPointer.Next;
                evenPointer = evenPointer.Next;               
            }

            oddPointer.Next = even;

            return head;
        }

        public bool IsPalindrome(SingleListNode head)
        {
            if (head == null)
                return false;

            SingleListNode endOfFirstHalf = FindFirstHalfEnd(head);
            SingleListNode reverseSecondHalf = ReverseSecondHalf(endOfFirstHalf.Next);

            return true;
        }

        private SingleListNode ReverseSecondHalf(SingleListNode next)
        {
            Head = next;
            return ReverseLinkedList();
        }

        private SingleListNode FindFirstHalfEnd(SingleListNode head)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder listString = new StringBuilder();
            SingleListNode head = Head;

            while (head != null)
            {
                listString.Append($"-{head.Val}-");
                head = head.Next;
            }

            return listString.ToString();
        }
    }
}
