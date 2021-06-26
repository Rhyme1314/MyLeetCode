using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _78//子集  中等题 好难啊
        //个人认为 拓展法 是最简单的
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            #region  动态规划 剽窃的别人的思路 代码自己写的
            //IList<IList<int>> res = new List<IList<int>>();
            //IList<int> empty = new List<int>();//空集
            //res.Add(empty);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int n = res.Count;
            //    for (int j = 0; j < n; j++)
            //    {
            //        IList<int> newlist = new List<int>(res[j]);
            //        newlist.Add(nums[i]);
            //        res.Add(newlist);
            //    }
            //}
            //return res;// IList<IList<int>>;
            #endregion
            #region 回溯法 递归终止条件和调用自己想的 细节方面抄别人的
            //IList<IList<int>> res = new List<IList<int>>();
            //IList<int> empty = new List<int>();
            //res.Add(empty);
            //for (int i = 1; i <= nums.Length; i++)
            //{
            //    Backtracking(nums, i, 0, res , empty );
            //}
            //return res;
            #endregion
            #region DFS
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> empty = new List<int>();
            //res.Add(empty);
            DFS(nums, 0, res, empty);
            return res;
            #endregion
        }
        private void DFS(int[] nums, int index, IList<IList<int>> res, IList<int> curlist)
        {
            List<int> newlist = new List<int>(curlist);
            res.Add(newlist);
            if (index==nums.Length)
            {
                return;
            }
            for (int i = index; i < nums.Length; i++)
            {
                curlist.Add(nums[i]);
                DFS(nums, i + 1, res, curlist);
                curlist.Remove(nums[i]);
            }

        }
        //n为子集长度 index为nums元素索引
        private void  Backtracking(int[] nums, int n,int index ,IList<IList<int>>res,  IList<int> curlist)
        {
            //递归终止条件
            if (curlist.Count==n)
            {
                List<int> newlist = new List<int>(curlist);
                res.Add(newlist);
                return;
            }
            for (int i = index; i < nums.Length; i++)
            {
                curlist.Add(nums[i]);
                Backtracking(nums, n, i + 1, res, curlist);
                curlist.Remove(nums[i]);
            }
        }
    }
}
