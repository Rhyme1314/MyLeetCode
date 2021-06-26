using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _96//不同的搜索二叉树
    {
        public int NumTrees(int n)
        {
            int[] G = new int[n + 1];
            int[,] dp = new int[n + 1, n + 1];
            G[0] = 1;G[1] = 1;
            for (int i = 2; i < n+1; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    G[i] += G[i - j] * G[j-1];
                }
            }
            return G[n];
        }
    }
}
