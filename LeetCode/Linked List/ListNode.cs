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

            while (null != this)
            {
                toPrint.Append(this.Val + ",");
                currentNode = currentNode.Next;
            }
            return toPrint.ToString();
        }
    }
}
