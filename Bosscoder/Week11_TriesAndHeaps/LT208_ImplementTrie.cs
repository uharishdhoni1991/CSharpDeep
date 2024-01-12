using Bosscoder.Models;

namespace Bosscoder.Week11_TriesAndHeaps
{
    public class LT208_ImplementTrie
    {
        public (bool,bool) Solve()
        {
            Trie trie = new Trie();
            trie.Insert("word");
            bool p1 = trie.Search("word");
            bool p2 = trie.StartsWith("wo");

            return (p1, p2);
        }
    }
}
