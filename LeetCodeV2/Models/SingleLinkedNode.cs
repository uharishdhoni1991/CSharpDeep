namespace LeetCodeV2.Models
{
    public class SingleListNode
    {
        public int Val { get; set; }
        public SingleListNode Next { get; set; }

        public SingleListNode(int val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return Val.ToString();
        }
    }
}