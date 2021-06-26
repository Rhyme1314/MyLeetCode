using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //有 n 个城市，其中一些彼此相连，另一些没有相连。如果城市 a 与城市 b 直接相连，且城市 b 与城市 c 直接相连，那么城市 a 与城市 c 间接相连。

    //省份 是一组直接或间接相连的城市，组内不含其他没有相连的城市。

    //给你一个 n x n 的矩阵 isConnected ，其中 isConnected[i][j] = 1 表示第 i 个城市和第 j 个城市直接相连，而 isConnected[i][j] = 0 表示二者不直接相连。

    //返回矩阵中 省份 的数量。

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/number-of-provinces
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _547//省份数量
    {
        public int FindCircleNum(int[][] isConnected)
        {
            int res = 0;
            int cityNum = isConnected.Length;
            UnionFind547 unions = new UnionFind547(cityNum);
            for (int i = 0; i < cityNum; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        unions.Union(i, j);
                    }
                }
            }
            return res = cityNum - unions.unionCount;
        }
    }
    class UnionFind547//并查集
    {
        private int[] root;
        private int[] rank;//每个i的权重 //如果i的辈分特别高
        // 即有个root[j]=i 而root[k]=j 这时i就是k的爷爷辈
        public int unionCount = 0;
        public UnionFind547(int cityNum)
        {
            root = new int[cityNum];
            rank = new int[cityNum];
            //count = cityNum;
            for (int i = 0; i < root.Length; i++)
            {
                root[i] = i;
                rank[i] = 0;//初始每个i都没有后代 即没有root[j]指向i
            }
        }
        private int Find(int x)//并查集中的查
        {
            if (x == root[x])
            {
                return root[x];
            }
            return Find(root[x]);
        }
        private int Find2(int x)//并查集中的查（优化）
        {
            if (x == root[x])
            {
                return root[x];
            }
            return root[x] = Find2(root[x]);//在查找的时候 直接把当前的root 改成最终的root
        }
        public void Union(int x, int y)//并查集中的并(优化)
        {
            int rootX = Find2(x);
            int rootY = Find2(y);
            if (rootX != rootY)
            {
                if (rank[rootX] > rank[rootY])
                {//如果x的祖先辈分比y的祖先辈分高
                    root[rootY] = rootX;//那么y的祖先就被归为x的祖先的后辈
                }
                else if (rank[rootX] < rank[rootY])
                {
                    root[rootX] = rootY;
                }
                else//如果辈分相同
                {
                    root[rootY] = rootX;
                    rank[rootX]++;
                }
                unionCount++;
            }
        }
    }
}
