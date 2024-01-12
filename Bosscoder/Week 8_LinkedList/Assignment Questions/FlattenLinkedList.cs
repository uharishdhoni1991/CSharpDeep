using Bosscoder.Models;

namespace Bosscoder.Week_8_LinkedList.Assignment_Questions
{
    //Copy paste - Revise and revisit
    public class FlattenLinkedList
    {
        public NodeDouble Flatten(NodeDouble head)
        {
            return Flat(head, null);
        }

        private NodeDouble Flat(NodeDouble node, NodeDouble append)
        {
            if (node == null)
            {
                return append;
            }
            NodeDouble right = Flat(node.Next, append);
            node.Next = Flat(node.Child, right);
            node.Child = null;
            if (node.Next != null)
            {
                node.Next.Prev = node;
            }
            return node;
        }
    }
}
