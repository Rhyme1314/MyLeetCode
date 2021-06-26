using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _75//颜色分类
    {
        public void SortColors(int[] nums)
        {
            #region 遍历两遍
            //int n = nums.Length;
            //int head = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (nums[i] == 0)
            //    {
            //        int temp = nums[head];
            //        nums[head] = nums[i];
            //        nums[i] = temp;
            //        head++;
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (nums[i] == 1)
            //    {
            //        int temp = nums[head];
            //        nums[head] = nums[i];
            //        nums[i] = temp;
            //        head++;
            //    }
            //}
            #endregion
            int n = nums.Length;
            int zero = 0;
            int one = 0;
           for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    int temp = nums[zero];
                    nums[zero] = nums[i];
                    nums[i] = temp;
                    zero++;one++;
                    temp = nums[one];
                    nums[one] = nums[i];
                    nums[i] = temp;
                }
                if (nums[i]==1)
                {
                    int temp = nums[one];
                    nums[one] = nums[i];
                    nums[i] = temp;
                     one++;
                }
            }
        }
    }
}
