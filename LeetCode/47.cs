using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _47//全排列 II
    {
        IList<IList<int>> res;
        bool[] visited;
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            res = new List<IList<int>>();
            List<int> empty = new List<int>();
            int n = nums.Length;
            Array.Sort(nums);//像这种去重问题 就靠排序
            visited = new bool[n];
            DFS(nums, empty);
            return res;
        }
        private void DFS(int[] nums, List<int> curlist)
        {
            if (curlist.Count == nums.Length)
            {
                res.Add(new List<int>(curlist));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i]||(i>0&&nums[i]==nums[i-1]&&!visited[i]))
                    continue;
                curlist.Add(nums[i]);
                visited[i] = true;
                DFS(nums, curlist);
                visited[i] = false;
                curlist.Remove(nums[i]);
            }
        }
    }
}
