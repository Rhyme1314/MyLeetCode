using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _448//. 找到所有数组中消失的数字
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> res = new List<int>();
            int n = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                int x = (nums[i] - 1) % n;
                nums[x] += n;
            }
            for (int i = 0; i < n; i++)
            {
                if (nums[i]<n)
                    res.Add(i + 1);
            }
            return res;

            //HashSet<int> set = new HashSet<int>(nums);
            //for (int i = 1; i <= nums.Length; i++)
            //{
            //    if (!set.Contains(i))
            //        res.Add(i);

            //}
        }
    }
}
