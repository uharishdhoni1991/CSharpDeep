namespace Bosscoder.Models
{
    public class TrieWithIndex
    {
        public TrieNodeWithIndex Root { get; set; }

        public TrieWithIndex()
        {
            Root = new TrieNodeWithIndex();
        }
    }
}
