using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _773// 滑动谜题   //bfs的经典例题 要好好理解
    {
        public int SlidingPuzzle(int[][] board)
        {
            int column = board.Length;
            int row = board[0].Length;
            string start=""; string goal = "123450";
            for (int i = 0; i < column; i++)
                for (int j = 0; j < row; j++)
                    start += board[i][j].ToString();
            if (start == goal)
                return 0;
            Queue<string> BFS = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            BFS.Enqueue(start); visited.Add(start);
            int[][] dirs = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            int step = 0;
            while (BFS.Count != 0)
            {
                step++;
                int size = BFS.Count;
                while (size-- > 0)//BFS的固定写法
                {
                    string s = BFS.Dequeue(); int zeroIndex = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == '0')
                        {//查找0的位置
                            zeroIndex = i; break;
                        }
                    }
                    int x = zeroIndex % 3;//横向为x
                    int y = zeroIndex / 3;//纵向为y
                    for (int i = 0; i < 4; i++)
                    {
                        int nx = x + dirs[i][0];
                        int ny = y + dirs[i][1];

                        if (nx > 2 || nx < 0 || ny > 1 || ny < 0) continue;//越界 
                        int newIndex = ny * 3 + nx;
                        char[] tt = s.ToCharArray();
                        Swap(tt,zeroIndex,newIndex);//此时的t就是移动了一个0的状态
                        string t = new string(tt);
                        if (t == goal) return step;
                        if (visited.Contains(t)) continue;//一访问过了
                        visited.Add(t);
                        BFS.Enqueue(t);
                    }
                }
            }
            return -1;
        }

        private void Swap(char[] t, int v1,  int v2)
        {
            char temp = t[v1];t[v1] = t[v2];t[v2] = temp;
        }
    }
}
