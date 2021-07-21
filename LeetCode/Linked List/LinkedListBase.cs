using System;
using System.Collections.Generic;

namespace LeetCode.Linked_List
{
    public class LinkedListBase
    {   
        private int nodeCount;
        private Node _head;

        public Node Head
        {
            get
            {
                return _head;
            }
        }

        public LinkedListBase()
        {
            _head = null;               
            nodeCount = 0;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index >= nodeCount)
                return -1;

            Node p = GetPreviousNode(index);
            return p == null || p.Next == null ? -1 : p.Next.Val;
        }      

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            newNode.SetNext(_head);
            _head = newNode;
            nodeCount++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node node = Head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            node.SetNext(new Node(val, null));
            nodeCount++;
        }

        public void AddAtTail(Node node)
        {
            Node finalNode = Head;

            while (finalNode.Next != null)
            {
                finalNode = finalNode.Next;
            }

            finalNode.SetNext(node);
            nodeCount++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public Node AddAtIndex(int index, int val)
        {          
            if (index > nodeCount)
                return default(Node);

            Node prevNode = GetPreviousNode(index < 0 ? 0 : index);
            prevNode.SetNext(new Node(val, prevNode.Next));
            nodeCount++;

            return prevNode;
        }       

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index > nodeCount)
                return;

            Node prevNode = GetPreviousNode(index);

            if (prevNode.Next != null)
            {
                prevNode.SetNext(prevNode.Next.Next);
                nodeCount--;
            }
        }

        protected Node GetPreviousNode(int index)
        {
            Node node = Head;

            for (; index > 0 && node.Next != null; index--)
            {
                node = node.Next;
            }

            return node;
        }

        internal void SetHead(Node node)
        {
            _head = node;
        }
    }   

}
