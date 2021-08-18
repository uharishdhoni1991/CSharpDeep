using System;

namespace LeetCode.Linked_List
{
    public class LinkedListCycle : LinkedListBase
    {
        public bool HasCycle(Node head)
        {          
            Node pointerSlow = head;
            Node pointerFast = head;

            while(pointerSlow != null && pointerFast != null && pointerFast.Next != null)
            {
                pointerSlow = pointerSlow.Next;
                pointerFast = pointerFast.Next.Next;

                if (pointerSlow == pointerFast)
                    return true;
            }

            return false;
        }

        public Node DetectCycle(Node head)
        {
            if (head == null || head.Next == null || head.Next.Next == null)
                return null;

            Node pointerSlow = head;
            Node pointerFast = head;

            while (pointerFast != null && pointerFast.Next != null)
            {
                pointerSlow = pointerSlow.Next;
                pointerFast = pointerFast.Next.Next;

                if (pointerSlow == pointerFast)
                    break;
            }

            if (pointerSlow == pointerFast)
            {
                pointerSlow = head;

                while(pointerSlow != pointerFast)
                {
                    pointerSlow = pointerSlow.Next;
                    pointerFast = pointerFast.Next;
                }

                return pointerSlow;
            }

            return null;
        }
    }
}
