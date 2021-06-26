using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _42//接雨水
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            Stack<int> stack = new Stack<int>();
            int index = 0;int res = 0;
            while (index < n)
            {
                while (index < n && (stack.Count == 0 || height[stack.Peek()] > height[index]))
                {
                    stack.Push(index++);//用来存索引
                }
                if (index >= n) break;//如果一直递减 那就没话说了
                while (stack.Count != 0 && height[stack.Peek()]<height[index])
                {
                    int lowerIndex =   stack.Pop();
                    if (stack.Count==0)
                        break;
                    int width = index - stack.Peek() - 1;
                    int high = Math.Min(height[stack.Peek()], height[index]) - height[lowerIndex];
                    res += width * high;
                }
                stack.Push(index++);
            }
            return res;
        }
    }
}
