using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _51//大名鼎鼎的 N皇后
    {
        int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };//皇后的攻击方向  从左上到右下
        int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };//皇后的攻击方向  从左上到右下

        IList<IList<string>> res = new List<IList<string>>();
        public IList<IList<string>> SolveNQueens(int n)
        {
            #region 递归 + 使用两个二维数组来判断是否能放入皇后
            //int[,] attack = new int[n, n];
            //char[,] queens = new char[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        queens[i, j] = '.';
            //    }
            //}//初始化皇后位置
            //Backtrack(n, 0, queens, attack);

            //return res;
            #endregion
            #region 自己尝试做一下
            int[] queens = new int[n];//每个皇后的位置
            Backtrack2(n, 0, queens);
            return res;
            #endregion
            //总结一下 感觉难点就两个 一个是如何进行判断 皇后位置是否合法
            //一个是如何输出结果 
            //递归倒是很常规的递归

        }

        private void PutQueen(int[,] attack, char[,] queens, int x, int y, int n)
        {
            attack[y, x] = 1;
            for (int i = 1; i < n; i++)//放置皇后 后  将8个方向更改成不可放置的地方
            {
                for (int j = 0; j < 8; j++)
                {
                    int nx = x + i * dx[j];
                    int ny = y + i * dy[j];
                    if (nx >= 0 && nx < n && ny >= 0 && ny < n)
                    {
                        attack[ny, nx] = 1;
                    }
                }
            }

        }//x为行  y为列

        private void Backtrack(int n, int k, char[,] queens, int[,] attack)//k代表当前行
        {
            if (k == n)//所有行都遍历完了 
            {
                IList<string> solov = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    string str = string.Empty;
                    for (int j = 0; j < n; j++)
                        str += queens[i, j];
                    solov.Add(str);
                }
                res.Add(solov);
                return;
            }


            for (int i = 0; i < n; i++)
            {
                if (attack[k, i] == 0)
                {
                    queens[k, i] = 'Q';
                    int[,] temp = new int[n, n];
                    Array.Copy(attack, temp, attack.Length);
                    PutQueen(attack, queens, i, k, n);
                    Backtrack(n, k + 1, queens, attack);
                    attack = temp;//回溯到之前的状态
                    queens[k, i] = '.';//已经遍历完了第K行第i个
                }
            }
        }

        private bool isMatch( int k, int[] queens)
        {
            for (int i = 0; i < k; i++)
            {
                if (queens[i]==queens[k]||Math.Abs(queens[k]-queens[i])==(k-i))//皇后不兼容
                {
                    return false;
                }
            }
            return true;
        }
        private void Backtrack2(int n, int k, int[] queens)
        {
            if (k == n)
            {
                string[] solove = new string[n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (queens[i] == j)
                            solove[i] += 'Q';
                        else
                            solove[i] += '.';
                    }
                }
                res.Add(solove);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                queens[k] = i;
                if (!isMatch(k, queens))
                {
                    queens[k] = n;
                    continue;
                }
                Backtrack2(n, k + 1, queens);
                queens[k] = n;
            }
        }
    }
}
