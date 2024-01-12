namespace Bosscoder.Models
{
    public class TrieNodeWithIndex : TrieNode
    {
        public TrieNodeWithIndex[] Children;
        public int WordIndex;

        public TrieNodeWithIndex()
        {
            WordIndex = -1;
            Children = new TrieNodeWithIndex[27];
        }
    }
}
