using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.BaseObjects
{
    /// <summary>
    /// Trie class
    /// </summary>
    public class Trie
    {
        /// <summary>
        /// Children
        /// </summary>
        public Dictionary<char, Trie> Children;
        
        /// <summary>
        /// endOfWord
        /// </summary>
        public bool endOfWord;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public Trie()
        {
            this.Children = new Dictionary<char, Trie>();
            this.endOfWord = false;
        }
    }

    public class TrieUsage
    {
        public static void CreateATrie()
        {
            var root = new Trie {endOfWord = false};
            root.Children.Add('b', new Trie());
            root.Children.Add('c', new Trie());
            root.Children.Add('a', new Trie());
            root.Children.Add('d', new Trie());
        }
    }
}
