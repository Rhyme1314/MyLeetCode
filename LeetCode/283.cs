using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _283
    {//给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
     //示例:
     //输入: [0,1,0,3,12]
     //输出: [1,3,12,0,0]
     //        说明:
     //必须在原数组上操作，不能拷贝额外的数组。
     //尽量减少操作次数。
        public static void Test(int[] nums)
        {
            int n = nums.Length;

            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i]; j++;
                }
            }
            for (int i = j; i < n; i++)
            {
                nums[i] = 0;
            }
            //for (int i = 0; i < n; i++)
            //{
            //    if (nums[i] == 0)
            //    {
            //        int e = nums[i];
            //        for (int j = i; j < n - 1; j++)
            //        {
            //            nums[j] = nums[j + 1];
            //        }
            //        i--;
            //        nums[n - 1] = e;
            //    }
            //}
        }
        }
 }


