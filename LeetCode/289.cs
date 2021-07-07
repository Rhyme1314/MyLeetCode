using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _289//生命游戏
    {
        public void GameOfLife(int[][] board)
        {
            int[][] originBoard = new int[board.Length][];
            for (int i = 0; i < board.Length; i++)//复制一份数组
            {
                originBoard[i] = new int[board[0].Length];
                 Array.Copy(board[i], originBoard[i],board[0].Length);
            }
            int column = board.Length;
            int row = board[0].Length;
            int[][] dir = { new int[2] { -1, -1 }, new int[2] { -1, 0 }, new int[2] { -1, 1 }, new int[2] { 0, -1 },
                             new int[2] { 0, 1 }, new int[2] { 1, -1 }, new int[2] { 1, 0 }, new int[2] { 1, 1 }
            };
            for (int i = 0; i <column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    int oneCount = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int newI = i + dir[k][0];
                        int newJ = j + dir[k][1];
                        if (newI < 0 || newI >= column || newJ < 0 || newJ >= row) continue;
                        if (originBoard[newI][newJ] == 1) oneCount++;
                    }
                    if (originBoard[i][j] == 0 && oneCount == 3) board[i][j] = 1; //复活
                    else if (originBoard[i][j] == 1 && (oneCount > 3 || oneCount < 2)) board[i][j] = 0;
                }
            }
        }
    }
}
