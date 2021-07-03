using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //给定一个不含重复数字的数组 nums ，返回其 所有可能的全排列 。你可以 按任意顺序 返回答案。
    class _46//全排列
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> empty = new List<int>();
            Queue<int> rest = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                rest.Enqueue(nums[i]);
            }
            int n = nums.Length;
            Backtracking(rest, n, res, empty);
            return res;
        }
        private void Backtracking(Queue<int> rest,  int n, IList<IList<int>> res, IList<int> curlist)
        {
            if (curlist.Count==n)
            {
                List<int> newlist = new List<int>(curlist);
                res.Add(newlist);
                return;
            }

            for (int i = 0; i < rest.Count; i++)
            {
                int temp = rest.Peek();
                curlist.Add(temp);
                rest.Dequeue();
                Backtracking(rest, n, res, curlist);
                curlist.Remove(temp);
                rest.Enqueue(temp);
            }
        }
    }
    
}
