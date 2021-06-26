using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _54//螺旋矩阵
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int left = 0;int right = matrix[0].Length;
            int top = 0;int bottom = matrix.Length;
            IList<int> res = new List<int>();
            while (left<=right&&top<=bottom)
            {
                bool turnRight = false;
                bool turnDown = false;
                bool turnLeft = false;
                //bool turnUP = false;
                for (int i = left; i < right; i++)
                {
                    res.Add(matrix[top][i]);
                    turnRight = true;
                }
                top++;
                if (!turnRight)
                {
                    break;
                }
                for (int i = top; i < bottom; i++)
                {
                    res.Add(matrix[i][right-1]);
                    turnDown = true;
                }
                right--;
                if (!turnDown)
                {
                    break;
                }
                for (int i = right-1; i>=left; i--)
                {
                    res.Add(matrix[bottom-1][i]);
                    turnLeft = true;
                }
                bottom--;
                if (!turnLeft)
                {
                    break;
                }
                for (int i = bottom-1; i>=top ; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left++;
            }
            return res;
        }
    }
}
