using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _15//三数之和
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            #region 普通DFS  超时 不会剪枝
            //if (nums.Length < 3)
            //    return res;
            //Array.Sort(nums);
            //List<int> empty = new List<int>();
            //DFS(nums, 0, 0, empty);
            //return res;
            #endregion
            Array.Sort(nums);
            int len = nums.Length;
            if (nums.Length < 3||nums[0]>0||nums[len-1]<0)
                return res;
            List<int> empty = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if (i>0&&nums[i]==nums[i-1])//去除重复
                {
                    continue;
                }
                TwoSum(nums, -nums[i], i);
            }
            return res;

        }


        private void TwoSum(int[] nums, int target,int index)
        {
            int left = index+1;int right = nums.Length - 1;
            while (right>left)
            {
                if (nums[left]==nums[left+1])
                    left++;
                else if (nums[right]==nums[right-1])
                    right--;
                else if (nums[left] + nums[right] > target)
                    right--;
                else if (nums[left] + nums[right] < target)
                    left++;
                else
                {
                    res.Add(new int[3] { nums[left], nums[right], -target });
                    left++;
                }
            }
        }
        private void DFS(int[] nums, int index, int sum, List<int> curlist)
        {
            if (curlist.Count == 3 && sum == 0)
            {
                res.Add(new List<int>(curlist));
                return;
            }
            else if(curlist.Count==3)
            {
                return;
            }

          


            for (int i = index; i < nums.Length; i++)
            {
                if (curlist.Count == 2 && sum + nums[i] > 0)
                    return;
                if (i>index&&nums[i]==nums[i-1])
                    continue;
                curlist.Add(nums[i]);
                DFS(nums, i + 1, sum + nums[i], curlist);
                curlist.Remove(nums[i]);
            }
        }
    }
}
