using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _127// 单词接龙
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            #region 单向BFS 超时
            if (!wordList.Contains(endWord))
                return 0;
            int len = beginWord.Length;
            HashSet<string> visit = new HashSet<string>();
            Queue<string> BFS = new Queue<string>();
            BFS.Enqueue(beginWord); int step = 0;
            while (BFS.Count != 0)
            {
                step++; int size = BFS.Count;
                while (size-- > 0)
                {
                    string curStr = BFS.Dequeue();
                    char[] charArray = curStr.ToCharArray();
                    for (int j = 0; j < len; j++)
                    {
                        char ch = charArray[j];
                        for (char i = 'a'; i < 'z'; i++)
                        {
                            charArray[j] = i;
                            string newStr = new string(charArray);
                            if (!wordList.Contains(newStr)) continue;
                            if (visit.Contains(newStr)) continue;
                            if (newStr == endWord) return step;
                            visit.Add(newStr);
                            BFS.Enqueue(newStr);
                        }
                        charArray[j] = ch;
                    }

                }
            }
            return 0;
            #endregion


        }
    }
}
