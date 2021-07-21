using System;

namespace LeetCode.Linked_List
{
    public class LinkedListCycle : LinkedListBase
    {
        public bool HasCycle(Node Head)
        {          
            Node pointerSlow = Head;
            Node pointerFast = Head;

            while(pointerSlow != null && pointerFast != null && pointerFast.Next != null)
            {
                pointerSlow = pointerSlow.Next;
                pointerFast = pointerFast.Next.Next;

                if (pointerSlow == pointerFast)
                    return true;
            }

            return false;
        }        
    }
}
