using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _90//子集II
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();

            IList<int> empty = new List<int>();
            DFS(nums, 0, res, empty);
           
            return res;
        }
        private void DFS(int[] nums, int index, IList<IList<int>> res, IList<int> curList)
        {
            //IList<int> newlist = new List<int>(curList);
            res.Add(curList);
            if (index>=nums.Length)
                return;
           
            for (int i = index; i < nums.Length; i++)
            {
                if (i > index && nums[i] == nums[i-1])
                    continue;
                curList.Add(nums[i]);
                DFS(nums, i + 1, res, new List<int>(curList));
                curList.Remove(nums[i]);
            }
        }
    }
}
