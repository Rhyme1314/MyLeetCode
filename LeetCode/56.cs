using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _56//合并区间
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (int[] a, int[] b) => { return a[0] - b[0]; });
            int n = intervals.Length;
            List<int[]> list = new List<int[]>();
            int[] curInterval = intervals[0];
            for (int i = 0; i < n; i++)
            {
                if (i+1<n&& curInterval[1] >= intervals[i + 1][0])
                {
                    curInterval = new int[] { curInterval[0], Math.Max(intervals[i + 1][1], curInterval[1]) };
                }
                else {
                    list.Add(curInterval);
                    if (i+1<n)
                        curInterval = intervals[i + 1];
                }
            }
            int[][] res = new int[list.Count][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = list[i];
            }
            return res;
        }
        public void Sort(int[][] intervals) {
            bool isBub = true;
            while (isBub)
            {
                isBub = false;
                for (int i = 0; i < intervals.Length-1; i++)
                {
                    if (intervals[i][0]> intervals[i+1][0])
                    {
                        int[] temp = intervals[i]; intervals[i] = intervals[i + 1];
                        intervals[i + 1] = temp; isBub = true;
                    }
                }
            }
        }
    }
}
