using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1828//统计一个圆中点的数目
    {
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            int n = queries.Length;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j   = 0; j < points.Length; j++)
                {
                    if ((points[j][0] - queries[i][0]) * (points[j][0] - queries[i][0]) +   //x^2 + y^2 <= r^2
                        (points[j][1] - queries[i][1]) * (points[j][1] - queries[i][1]) <=
                        queries[i][2] * queries[i][2])
                    {
                        res[i]++;
                    }
                }
            }
            return res;
        }
    }
}
