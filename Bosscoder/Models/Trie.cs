namespace Bosscoder.Models
{
    public class Trie
    {
        public Trie()
        {
            Root = new TrieNode('*');
        }

        public TrieNode Root { get; }

        public virtual void Insert(string word)
        {
            var current = Root;

            foreach (var t in word)
            {
                if (!current.ChildNodes.TryGetValue(t, out var currchildNode))
                    current.ChildNodes[t] = currchildNode = new TrieNode(t);

                current = currchildNode;
            }

            current.IsEndOfWord = true;
        }

        public virtual bool Search(string word)
        {
            var current = Root;

            foreach (var t in word)
            {
                if (!current.ChildNodes.TryGetValue(t, out var currchildNode))
                    return false;

                current = currchildNode;
            }

            return current.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            var current = Root;

            foreach (var t in prefix)
            {
                if (!current.ChildNodes.TryGetValue(t, out var child))
                    return false;

                current = child;
            }

            return true;
        }
    }
}
