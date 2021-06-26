using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            #region 哈希集合
            //HashSet<int> Set = new HashSet<int>(nums1);
            //HashSet<int> res = new HashSet<int>();
            //int n = Set.Count;
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    if (Set.Contains(nums2[i]))
            //        res.Add(nums2[i]);
            //}
            //int m = res.Count;
            //int[] resl = new int[m];
            //for (int i = 0; i < m; i++)
            //{
            //    resl[i] = res.First();
            //    res.Remove(resl[i]);
            //}
            //return resl;

            #endregion
            #region 双指针
            Array.Sort(nums1);
            Array.Sort(nums2);
            int[] res = new int[nums1.Length + nums2.Length];
            int index1 = 0;int index2 = 0;int index = 0;
            while (index1 < nums1.Length && index2 < nums2.Length)
            {
                if (nums1[index1]==nums2[index2])
                {
                    if (index==0|| nums1[index1]!=res[index-1])
                        res[index++] = nums2[index2];
                    index1++;
                    index2++;
                }
                else if(nums2[index2]>nums1[index1])
                    index1++;
                else
                    index2++;
            }
            int[] resTrue = new int[index];
            Array.Copy(res, 0, resTrue, 0, index);
            return resTrue;
            #endregion
        }
    }
}
