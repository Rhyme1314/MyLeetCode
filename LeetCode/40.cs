using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _40//组合总和 II
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            DFS(candidates, target, 0, new List<int>());
            return res;
        }

        private void DFS(int[] candidates,int target,int index,List<int> curlist)
        {
            if (target == 0)
            {
                res.Add(new List<int>(curlist));
                return;
            }
            if (index == candidates.Length||target<0) return;
            
            for (int i = index; i < candidates.Length; i++)
            {
                //if (i > 0 && candidates[i] == candidates[i - 1]) continue;
                if (target - candidates[i] < 0) break;
                curlist.Add(candidates[i]);
                DFS(candidates, target - candidates[i], i+1, curlist);
                curlist.RemoveAt(curlist.Count - 1);
            }
        }
    }
}
