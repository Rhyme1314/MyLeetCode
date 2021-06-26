using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _59//螺旋矩阵 II
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] res = new int[n][];
            for (int i = 0; i < n; i++)
            {
                res[i] = new int[n];
            }
            int left = 0;int right = n;
            int top = 0; int bottom = n;int num = 0;
            while (left<=right&&top<=bottom)
            {
                //bool turnRight = false;
                //bool turnDown = false;
                //bool turnLeft = false;
                for (int i = left; i < right; i++)
                {
                    res[top][i] = ++num; //turnRight = true;
                }
                top++;
                for (int i = top; i < bottom; i++)
                {
                    res[i][right-1] = ++num;
                    //turnDown = true;
                }
                right--;
                for (int i = right-1; i >=left; i--)
                {
                    res[bottom-1][i] = ++num;
                    //turnLeft = true;
                }
                bottom--;
                for (int i = bottom - 1; i >= top; i--)
                {
                    res[i][left] = ++num;
                }
                left++;
            }
            return res;
        }
    }
}
