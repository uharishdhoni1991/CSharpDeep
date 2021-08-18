using System.Text;

namespace LeetCode.Linked_List
{
    public class Node
    {
        private readonly int _val;
        private Node _next;

        public Node Next { get { return _next; } }
        public int Val { get { return _val; } }

        public Node(int val) : this(val, null)
        {
        }

        public Node(int val, Node n)
        {
            _val = val;
            _next = n;
        }       

        public void SetNext(Node next)
        {
            _next = next;
        }

        public override string ToString()
        {
            return Val.ToString();
        }
    }
}
