using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _909//蛇梯棋  BFS
    {
        //唯一的难点在于编号转换成坐标
        public int SnakesAndLadders(int[][] board)
        {
            int column = board.Length;
            int row = board[0].Length;

            int N = column * row;
            if (board[0][0] != -1) return -1;
            Queue<int> queue = new Queue<int>();
            HashSet<int> visit = new HashSet<int>();
            visit.Add(1);
            queue.Enqueue(1); int step = 0;
            while (queue.Count != 0)
            {
                step++;
                int size = queue.Count;
                while (size-- > 0)
                {
                    int curNum = queue.Dequeue();
                    for (int i = 1; i <= 6; i++)
                    {
                        int nextNum = curNum + i;
                        int y = column - (nextNum / row) - 1;
                        int x = row - (nextNum % row);

                        if (((nextNum / row) & 1) == 0)//如果nextNum/row是偶数
                            x = nextNum % row - 1;
                        if (nextNum % row == 0)
                        {
                            y++;
                            if (((nextNum / row) & 1) == 0) x = 0;
                            else x = row - 1;
                        }
                        if (board[y][x] != -1)
                            nextNum = board[y][x];
                        if (visit.Contains(nextNum)) continue;
                        if (nextNum >= N) return step;
                        visit.Add(nextNum);
                        queue.Enqueue(nextNum);

                    }
                }
            }
            return -1;
        }
    }
}
