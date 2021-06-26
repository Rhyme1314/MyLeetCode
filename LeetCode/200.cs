using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //非常经典的题
    //    给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。

    //岛屿总是被水包围，并且每座岛屿只能由水平方向和/或竖直方向上相邻的陆地连接形成。

    //此外，你可以假设该网格的四条边均被水包围。

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/number-of-islands
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _200//岛屿数量
    {
        //public int NumIslands(char[][] grid)
        //{
        //    #region DFS
        //    //int res = 0;
        //    //int column = grid.Length;//列
        //    //int row = grid[0].Length;//行
        //    //for (int i = 0; i < column; i++)
        //    //{
        //    //    for (int j = 0; j < row; j++)
        //    //    {
        //    //        if (grid[i][j]=='1')
        //    //        {
        //    //            res++;
        //    //            DFS(grid,i,j);//递归  把1周边的所有1都变成0  
        //    //        }
        //    //    }
        //    //}
        //    //return res;
        //    #endregion
        //    #region BFS
        //    //int res = 0;
        //    //int column = grid.Length;//列长度
        //    //int row = grid[0].Length;//行长度
        //    //Queue<int[]> bfsQ = new Queue<int[]>();
        //    //for (int i = 0; i < column; i++)
        //    //{
        //    //    for (int j = 0; j < row; j++)
        //    //    {
        //    //        if (grid[i][j] == '1')
        //    //        {
        //    //            res++;
        //    //            grid[i][j] = '0';
        //    //            bfsQ.Enqueue(new int[] { i, j });
        //    //           // BFS(grid, bfsQ);//递归  把1周边的所有1都变成0  
        //    //            while (bfsQ.Count > 0)
        //    //            {
        //    //                int y = bfsQ.Peek()[1];
        //    //                int x = bfsQ.Peek()[0];
        //    //               //先将队首元素同化为0
        //    //                bfsQ.Dequeue();
        //    //                if (x + 1 < grid.Length && grid[x + 1][y] == '1')//下
        //    //                {
        //    //                    bfsQ.Enqueue(new int[] { x + 1, y });
        //    //                    grid[x+1][y] = '0';
        //    //                }
        //    //                if (x - 1 >= 0 && grid[x - 1][y] == '1')//上
        //    //                {
        //    //                    bfsQ.Enqueue(new int[] { x - 1, y });
        //    //                    grid[x -1][y] = '0';
        //    //                }
        //    //                if (y + 1 < grid[0].Length && grid[x][y + 1] == '1')//右
        //    //                {
        //    //                    bfsQ.Enqueue(new int[] { x, y + 1 });
        //    //                    grid[x][y+1] = '0';
        //    //                }
        //    //                if (y - 1 >= 0 && grid[x][y - 1] == '1')//左
        //    //                {
        //    //                    bfsQ.Enqueue(new int[] { x, y - 1 });
        //    //                    grid[x ][y-1] = '0';
        //    //                }
        //    //            }
        //    //        }
        //    //    }
        //    //}
        //    //return res;
        //    #endregion
        //    #region 并查集 
        //    int res = 0;
        //    int islandCount = 0;
        //    int column = grid.Length;//列长度
        //    int row = grid[0].Length;//行长度
        //    UnionFind unions = new UnionFind(grid);
        //    for (int i = 0; i < column; i++)
        //    {
        //        for (int j = 0; j < row; j++)
        //        {
        //            if (grid[i][j] == '1')
        //            {
        //                UNF(unions, grid, i, j, column, row);
        //                islandCount++;//所有'1'的数量
        //            }
        //        }
        //    }
        //    int unionTimes = column * row - unions.count;//所有'1'中 合并的次数
        //    return res = islandCount - unionTimes;//
        //    //晚点再写 有点复杂
        //    #endregion
        //}
        private void UNF(UnionFind unions, char[][] grid, int i, int j, int col, int row)
        {
            int index = i * row + j;
            int downindex = (i + 1) * row + j ;
            int upindex = (i - 1) * row + j ;
            int leftindex = i * row + (j - 1) ;
            int rightindex = i * row + (j + 1) ;
            if (i + 1 < col && grid[i + 1][j] == '1')
            {
                unions.Union(index, downindex);
            }
            if (i - 1 >= 0 && grid[i - 1][j] == '1')
            {
                unions.Union(index, upindex);
            }
            if (j + 1 < row && grid[i][j + 1] == '1')
            {
                unions.Union(index, leftindex);
            }
            if (j - 1 >= 0 && grid[i][j - 1] == '1')
            {
                unions.Union(index, rightindex);
            }
        }



        private void DFS(char[][] grid, int i, int j)
        {
            if (i >= grid.Length || j >= grid[0].Length || i < 0 || j < 0)
                return;
            if (grid[i][j] == '0')//递归终止
                return;

            grid[i][j] = '0';//遍历过的格子同化为0
            DFS(grid, i + 1, j);//同化下方
            DFS(grid, i - 1, j);
            DFS(grid, i, j + 1);//同化右边
            DFS(grid, i, j - 1);
        }
    }
}
