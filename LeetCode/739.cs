using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _739//每日温度
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            #region 暴力解法 超时
            //int n = temperatures.Length;
            //int[] res = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (temperatures[j] > temperatures[i])
            //        {
            //            res[i] = j - i; break;
            //        }
            //    }
            //}
            //return res;
            #endregion
            #region 单调栈
            int n = temperatures.Length;
            int[] res = new int[n];
            Stack<int> stack = new Stack<int>(); //存索引啊 SB！！！
            for (int i = 0; i < n; i++)
            {
                while (stack.Count!=0&& temperatures[stack.Peek()]<temperatures[i])
                {
                    int preIndex = stack.Pop();
                    res[preIndex] = i - preIndex;
                }
                stack.Push(i);
            }
            return res;
            #endregion

        }
    }
}
