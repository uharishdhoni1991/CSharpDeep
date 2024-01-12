namespace Bosscoder.Models
{
    //Revisit and revise
    public class TrieWithWildcards : Trie
    {
        public TrieWithWildcards()
        {
        }

        public override void Insert(string word)
        {
            var current = Root;

            for (int i = 0; i < word.Length; i++)
            {
                if (!current.ChildNodes.ContainsKey(word[i]))
                {
                    TrieNode trieNode = new TrieNode();
                    current.ChildNodes[word[i]] = trieNode;
                }

                current = current.ChildNodes[word[i]];
            }

            current.IsEndOfWord = true;
        }

        public override bool Search(string word)
        {
            return DFS(Root, word);
        }

        private bool DFS(TrieNode node, string word)
        {
           for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == '.')
                {
                    foreach(var child in node.ChildNodes.Values)
                    {
                        if (DFS(child, word.Substring(i + 1)))
                            return true;
                    }

                    return false;
                }
                else
                {
                    if (!node.ChildNodes.ContainsKey(word[i]))
                        return false;

                    node = node.ChildNodes[word[i]];
                }
            }

            return node.IsEndOfWord;
        }
    }
}