using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _720 //词典中最长的单词
    {
        public string LongestWord(string[] words)
        {
            Trie2 trie = new Trie2();
            string res = "";
            for (int i = 0; i < words.Length; i++)
            {
                trie.Insert(words[i]);
            }
            trie.FindLongestWord(trie.rootNode, ref res);
            return res;
        }
    }
    public class TrieNode2
    {
        public string val;
        public int deep;
        public bool isEnd;//Count>0说明这个val是某个string的结尾 
        public TrieNode2[] children;
        public TrieNode2(bool isEnd = false)
        {
            this.deep = 0;
            this.isEnd = isEnd;
            children = new TrieNode2[26];//0--25
        }
    }
    class Trie2//照搬208的树 稍做修改
    {
        public TrieNode2 rootNode = null;
        //public int 
        public Trie2()
        {
            rootNode = new TrieNode2();
        }
        public void FindLongestWord(TrieNode2 node,ref string res)
        {
            for (int i = 0; i < node.children.Length; i++)
            {
                if (node.children[i]!=null && node.children[i].isEnd)
                {
                    FindLongestWord(node.children[i], ref res);
                }
            }
            if (node.val==null)
                return;
            if (node.val.Length>res.Length)
                res = node.val;
        }
        public void Insert(string word)
        {
            TrieNode2 curNode = rootNode;
            for (int i = 0; i < word.Length; i++)
            {
                if (curNode.children[word[i] - 'a'] == null)
                {
                    curNode.children[word[i] - 'a'] = new TrieNode2();
                    curNode.children[word[i] - 'a'].deep = curNode.deep + 1;
                }
                curNode = curNode.children[word[i] - 'a'];
            }
            curNode.isEnd = true ;
            curNode.val = word;
        }
    }

}
