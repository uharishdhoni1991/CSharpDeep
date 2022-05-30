using System.Text;

namespace LeetCode.Linked_List
{
    internal class ListNode
    {
        public int Val { get; set; }
        public ListNode Next { get; set; }
        public ListNode(int val) { Val = val; }

        public override string ToString()
        {            
            StringBuilder toPrint = new StringBuilder();
            ListNode currentNode = this;

            while (currentNode != null)
            {
                toPrint.Append(currentNode.Val);

                if (currentNode.Next != null)
                    toPrint.Append(",");

                currentNode = currentNode.Next;
            }
            return toPrint.ToString();
        }
    }
}
