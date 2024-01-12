namespace Bosscoder.Models
{
    public class Node
    {
        private readonly int _val;

        public Node(int val)
        {
            _val = val;         
        }

        public int Val { get { return _val; } }
        public Node Next { get; set; }

        public override string ToString()
        {
            return $"{Val}-{Next?.Val}";
        }
    }
}