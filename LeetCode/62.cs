using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//一个机器人位于一个 m x n网格的左上角 （起始点在下图中标记为 “Start” ）。

//机器人每次只能向下或者向右移动一步。机器人试图达到网格的右下角（在下图中标记为 “Finish” ）。

//问总共有多少条不同的路径？

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/unique-paths
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _62//不同路径 
    {
        public int UniquePaths(int m, int n)
        {
            int[,] Fn = new int[m, n];
            Fn[0, 0] = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i-1>=0 && j -1>=0)
                    {
                        Fn[i, j] = Fn[i - 1, j] + Fn[i, j - 1];
                    }
                    else if (i-1>=0)
                    {
                        Fn[i, j] = Fn[i - 1, j];
                    }
                    else if (j-1>=0)
                    {
                        Fn[i, j] = Fn[i, j - 1];
                    }
                }
            }
            return Fn[m - 1, n - 1];

        }
    }
}
