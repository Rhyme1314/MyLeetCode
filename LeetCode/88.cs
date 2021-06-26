using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _88//合并两个有序数组
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            #region 合并+排序 
            //for (int i = m; i < m + n; i++)
            //{
            //    nums1[i] = nums2[i - m];
            //}
            //Array.Sort(nums1);
            #endregion
            #region 逆向双指针 妙啊 有点难想到
            int index1 = m - 1;
            int index2 = n - 1;
            for (int i = m+n-1; i >=0; i--)
            {
                if (index1>=0&&index2>=0&&nums1[index1]>=nums2[index2])
                {
                    nums1[i] = nums1[index1];
                    index1--;
                }
                else if (index1 >= 0 && index2 >= 0 && nums1[index1] <nums2[index2])
                {
                    nums1[i] = nums2[index2];
                    index2--;
                }
                else if (index1>=0)//index2已经被遍历完了
                {
                    nums1[i] = nums1[index1];
                    index1--;
                }
                else if (index2 >= 0)//index1已经被遍历完了
                {
                    nums1[i] = nums2[index2];
                    index2--;
                }
            }
            #endregion
        }
    }
}
