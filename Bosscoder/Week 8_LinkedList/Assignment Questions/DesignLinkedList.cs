using Bosscoder.Models;

namespace Bosscoder.List.Assignment_Questions
{
    public class DesignLinkedList
    {
        public Node Head;
        private int _size;

        public DesignLinkedList()
        {
            _size = 0;
            Head = new Node(-1);
        }

        public int Get(int index)
        {
            if (index < 0 || index > _size)
                return -1;

            Node head = Head;

            for (int i = 0; i < index + 1 && head.Next!= null; ++i)
                head = head.Next;

            return head.Val;
        }

        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);           
        }

        public void AddAtTail(int val)
        {
            AddAtIndex(_size, val);            
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > _size)
                return;

            if (index < 0)
                index = 0;

            ++_size;

            Node curr = Head;

            for (int i = 0; i < index && curr.Next != null; ++i)
            {
                curr = curr.Next;
            }

            Node toAdd = new Node(val);

            toAdd.Next = curr.Next;
            curr.Next = toAdd;
        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= _size)
                return;

            Node curr = Head;

            for (int i = 0; i < index && curr.Next != null; ++i)
            {
                curr = curr.Next;
            }

            curr.Next = curr.Next.Next;
            --_size;
        }
    }
}