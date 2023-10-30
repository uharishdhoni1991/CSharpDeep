namespace Bosscoder.Models
{
    public class Node
    {
        public Node(int val, Node node)
        {
            Val = val;
            Next = node;
        }

        public int Val { get; set; }
        public Node Next { get; set; }
    }
}
