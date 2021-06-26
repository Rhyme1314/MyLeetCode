using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _189
    {
        public void Rotate(int[] nums, int k)
        {
            #region 哈希表 暴力解法  其实没必要用哈希表 开个额外数组也是一样的
            //int n = nums.Length;
            //if (n == 1)
            //    return;
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < n; i++)
            //{
            //    if (i + k >= n)
            //        dic[i + k - n * ((i + k) / n)] = nums[i];
            //    else
            //        dic[i + k] = nums[i];
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    nums[i] = dic[i];
            //}
            #endregion
            #region 数组翻转
            //int n = nums.Length;
            //if (n == 1)
            //    return;
            //if (k>=n)
            //    k =k- n * (k / n);
            //Array.Reverse(nums);
            //Array.Reverse(nums, 0, k);
            //Array.Reverse(nums, k, n - k);
            #endregion
            #region 移动K次
            int n = nums.Length;
            k = k % n;
            for (int i = 0; i < k; i++)
            {
                int temp = nums[n - 1];
                for (int j = n-1; j >0; j--)//向后移动一次
                    nums[j] = nums[j - 1];
                nums[0] = temp;
            }
            #endregion

        }
    }
}
