using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TrieNode
    {
        public char val;
        public int Count;//Count>0说明这个val是某个string的结尾 
        public TrieNode[] children;
        public TrieNode(char val, int count = 0)
        {
            this.val = val;
            this.Count = count;
            children = new TrieNode[26];//0--25
        }
    }

    class Trie//实现一个Trie(字典树)  用了个比较取巧的方式 26叉树
    {
        public TrieNode rootNode = null;

        public Trie()
        {
            rootNode = new TrieNode(' ');
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            if (word == null)
                return;
            TrieNode curNode = rootNode;
            for (int i = 0; i < word.Length; i++)
            {
                if (curNode.children[word[i]-'a']==null)
                {
                    curNode.children[word[i] - 'a'] = new TrieNode(word[i], 0);
                }
                curNode = curNode.children[word[i] - 'a'];
            }
            curNode.Count++;//单词插入结束 当前结点为结尾结点 count++;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            if (word == null)
                return false;
            TrieNode curNode = rootNode;
            for (int i = 0; i < word.Length; i++)
            {
                if (curNode.children[word[i] - 'a'] == null)
                    return false;
                curNode = curNode.children[word[i] - 'a'];
            }
            //遍历完毕
            return curNode.Count > 0 ? true : false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            if (prefix == null)
                return false ;
            TrieNode curNode = rootNode;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (curNode.children[prefix[i] - 'a'] == null)
                    return false;
                curNode = curNode.children[prefix[i] - 'a'];
            }
            return true;
        }
    }
}
