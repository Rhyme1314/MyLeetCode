using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _238//除自身以外数组的乘积
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            #region DP两个
            //int n = nums.Length;
            //int[] dpL = new int[n];//dpL[i]代表i的左边的所有乘积
            //int[] dpR = new int[n];//dpL[i]代表i的右边的所有乘积
            //int[] res = new int[n];
            //dpL[0] = 1; dpR[n - 1] = 1;
            //for (int i = 1; i < n; i++)
            //{
            //    dpL[i] = nums[i - 1] * dpL[i - 1];
            //}
            //for (int i = n - 2; i >= 0; i--)
            //{
            //    dpR[i] = nums[i + 1] * dpR[i + 1];
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    res[i] = dpL[i] * dpR[i];
            //}
            //return res;
            #endregion
            #region 既然能用DP  那肯定能优化成一维
            int n = nums.Length;
            int p = 1; int q = 1;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = p;
                p *= nums[i];
            }
            for (int i = n-1; i >=0; i--)
            {
                res[i] *= q;
                q *= nums[i];
            }
            return res;
            #endregion
          
        }
    }
}
