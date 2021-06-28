using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _79//单词搜索
    {
        public bool Exist(char[][] board, string word)
        {
            char[] cArr = word.ToCharArray();
            int n = cArr.Length;
            int column = board.Length;
            int row = board[0].Length;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i][j] != cArr[0]) continue;
                    char[][] fadeBoard = new char[column][];
                    for (int x = 0; x < column; x++)
                        fadeBoard[x] = board[x];
                    if (DFS(fadeBoard, cArr, 0, i, j)) return true;
                }
            }
            return false;
        }
        private bool DFS(char[][] board,char[] arr, int index,int column,int row) {
            if (index == arr.Length) return true;
            if (board[column][row]!=arr[index]) return false;
          
            int column2 = board.Length;
            int row2 = board[0].Length;
            bool result = false;
            char ch = board[column][row];
            board[column][row] = '0';
            int[][] directions = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            for (int i = 0; i < 4; i++)
            {
                int newColumn = column + directions[i][0];
                int newRow = row + directions[i][1];
                if (newColumn >= 0 && newColumn < column2 && newRow >= 0 && newRow < row2)
                {
                    if (board[newColumn][newRow] != '0')
                    {
                        if (DFS(board, arr, index + 1, newColumn, newRow)) {
                            result = true;
                            break;
                        }
                           
                    }
                }
            }
            board[column][row] = ch;
            return result;
        }

    }
}
