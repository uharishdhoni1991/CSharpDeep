using System.Collections.Generic;

namespace Bosscoder.Models
{
    public class TrieNode
    {    
        public TrieNode Root { get; set; }
        public char Key { get; set; }
        public Dictionary<char, TrieNode> ChildNodes { get; set; }
        public bool IsEndOfWord { get; set; }
        
        public TrieNode() : this ('*')
        {
        }

        public TrieNode(char key)
        {           
            Key = key;
            ChildNodes = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
        }       
    }
}
