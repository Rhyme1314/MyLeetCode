using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LCP_07//传递信息
    {
        int res = 0;
        Dictionary<int, List<int>> dic;
        public int NumWays(int n, int[][] relation, int k)
        {
            #region DFS
            //dic = new Dictionary<int, List<int>>();
            //for (int i = 0; i < n; i++)
            //{
            //    dic[i] = new List<int>();
            //}
            //for (int i = 0; i < relation.Length; i++)
            //{
            //    dic[relation[i][0]].Add(relation[i][1]);
            //}
            //DFS(n, 0, k);
            #endregion
            #region BFS
            //dic = new Dictionary<int, List<int>>();
            //for (int i = 0; i < n; i++)
            //{
            //    dic[i] = new List<int>();
            //}
            //for (int i = 0; i < relation.Length; i++)
            //{
            //    dic[relation[i][0]].Add(relation[i][1]);
            //}
            //Queue<int> BFS = new Queue<int>();
            //BFS.Enqueue(0); int step = 0;
            //while (BFS.Count != 0 && step <= k)
            //{
            //    step++; int size = BFS.Count;
            //    while (size-- > 0)
            //    {
            //        int curNum = BFS.Dequeue();
            //        for (int i = 0; i < dic[curNum].Count; i++)
            //        {
            //            if (dic[curNum][i] == n - 1 && step == k) res++;
            //            BFS.Enqueue(dic[curNum][i]);
            //        }
            //    }
            //}
            #endregion
            int[,] dp = new int[n, k + 1];dp[0, 0] = 1;
            for (int i = 1; i < k + 1; i++)
            {
                foreach (int[] edges in relation)
                {
                    int right = edges[1];int left = edges[0];
                    dp[right, i] += dp[left, i - 1];
                }
            }
            return dp[n-1,k];

        }
        //DFS
        private void DFS(int n, int index, int steps)
        {
            if (index == n - 1 && steps == 0) { res++; return; }
            else if (steps == 0) return;
            for (int i = 0; i < dic[index].Count; i++)
            {
                DFS(n, dic[index][i], steps - 1);
            }

        }

    }
}
