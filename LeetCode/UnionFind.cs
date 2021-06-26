using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class UnionFind//并查集
    {
        private int[] root;
        public int count = 0;//所有格子的总数
        public UnionFind(int[][] grid)
        {
            int column = grid.Length;
            int row = grid[0].Length;
             count = column * row;
            root = new int[column*row];
            for (int i = 0; i < root.Length; i++)
            {
                root[i] =i;
            }
           
        }
        public int Find(int x)//并查集中的查
        {
            if (x==root[x])
            {
                return root[x];
            }
            return Find(root[x]);
        }
        public void Union(int x,int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX!=rootY)
            {
                root[rootX] = rootY;
                count--;//每并一次 就相当于两个格子合并成一个格子 count--
            }
        }
    }
}
