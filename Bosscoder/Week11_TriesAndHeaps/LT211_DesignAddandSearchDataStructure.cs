using Bosscoder.Models;

namespace Bosscoder.Week11_TriesAndHeaps
{
    public class LT211_DesignAddandSearchDataStructure
    {
        public readonly TrieWithWildcards trie = new TrieWithWildcards();

        public LT211_DesignAddandSearchDataStructure()
        {

        }

        public void AddWord(string word)
        {
            trie.Insert(word);
        }

        public bool Search(string word)
        {
            return trie.Search(word);
        }
    }
}
