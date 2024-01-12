using Bosscoder.Models;

namespace Bosscoder.Week11_TriesAndHeaps
{
    //ToDo 
    public class LT745_SearchByPrefixAndSuffix
    {      
        public Trie Trie { get; set; }
        public string[] Words { get; }

        public LT745_SearchByPrefixAndSuffix(string[] words)
        {
           // Trie = new TrieNodeWithIndex();
            Words = words;

            foreach(var word in words)
            {
                //Trie.Insert(word);
            }
        }

        //public int Search(string pref, string suff)
        //{
        //    bool  = Trie.StartsWith(pref);
        //}
    }
}
