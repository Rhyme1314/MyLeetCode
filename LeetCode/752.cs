using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _752// 打开转盘锁
    {
        public int OpenLock(string[] deadends, string target)
        {
            string begin = "0000";
            if (begin==target)
                return 0;
            HashSet<string> dead = new HashSet<string>(deadends);
            HashSet<string> visit = new HashSet<string>();
            Queue<string> BFS = new Queue<string>();
            BFS.Enqueue(begin); int step = 0;

            while (BFS.Count!=0)
            {
                step++;int size = BFS.Count;
                while (size-->0)
                {
                    string curStr = BFS.Dequeue();
                    char[] charArray = curStr.ToCharArray();
                    for (int i = 0; i < 4; i++)
                    {
                        char ch = charArray[i];
                        for (int j = 0; j < 2; j++)
                        {
                            if (j==0)
                            {
                                charArray[i] = (char)(ch + 1);
                            }
                            else charArray[i] = (char)(ch - 1);
                            if (charArray[i] < 0) charArray[i] = '9';
                            if (charArray[i] > 9) charArray[i] = '0';
                            string newStr = new string(charArray);
                            if (dead.Contains(newStr) || visit.Contains(newStr)) continue;
                            if (newStr == target) return step;
                            visit.Add(newStr);
                            BFS.Enqueue(newStr);
                        }
                       
                        charArray[i] = ch;
                    }
                }
            }
            return -1;
        }
    }
}
