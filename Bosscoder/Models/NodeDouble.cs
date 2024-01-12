namespace Bosscoder.Models
{
    public class NodeDouble
    {
        public int Val;
        public NodeDouble Next;
        public NodeDouble Prev;
        public NodeDouble Child;

        public NodeDouble(int val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
