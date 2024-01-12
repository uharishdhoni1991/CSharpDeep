namespace Bosscoder.Models
{
    public class NodeRandom : Node
    {
        public NodeRandom Random { get; set; }
        public new NodeRandom Next { get; set; }

        public NodeRandom(int val) : base(val)
        {
            Random = null;
        }        
    }
}