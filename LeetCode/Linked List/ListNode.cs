namespace LeetCode.Linked_List
{
    internal class ListNode
    {
        public int Val { get; set; }
        public ListNode Next { get; set; }
        public ListNode(int val) { Val = val; }

        public override string ToString()
        {
            return Val.ToString();
        }
    }
}
