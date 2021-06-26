using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    给你两个 没有重复元素 的数组 nums1 和 nums2，其中nums1 是nums2 的子集。

//请你找出 nums1中每个元素在 nums2中的下一个比其大的值。

//nums1 中数字x 的下一个更大元素是指x 在nums2 中对应位置的右边的第一个比x 大的元素。如果不存在，对应位置输出 -1 。

 

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/next-greater-element-i
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _496
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            #region 用栈的暴力解法
            //Stack<int> stack = new Stack<int>();
            //Stack<int> temp = new Stack<int>();

            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    stack.Push(nums2[i]);
            //}
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    bool finding = true;
            //    int max = -1;
            //    while (finding)
            //    {
            //        int top = stack.Pop();
            //        if (top>nums1[i])
            //            max = top;
            //        else if (top==nums1[i])
            //            finding = false;
            //        temp.Push(top);
            //    }
            //    nums1[i] = max;
            //    while (temp.Count != 0)
            //        stack.Push(temp.Pop());

            //}
            //return nums1;
            #endregion
            #region 普通暴力解法
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    int max = -1; bool isFound = false;
            //    for (int j = 0; j < nums2.Length; j++)
            //    {
            //        //if (nums1[i]>nums2[j])
            //        if (nums1[i] == nums2[j])
            //        {
            //            isFound = true;
            //        }
            //        else if (nums1[i] < nums2[j] && isFound)
            //        {
            //            max = nums2[j];
            //            break;
            //        }
            //    }
            //    nums1[i] = max;
            //}
            //return nums1;
            #endregion
            #region 栈+字典解法
            int[] res = new int[nums1.Length];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Count != 0 &&nums2[i] > stack.Peek())
                {
                    dic[stack.Peek()] = nums2[i];
                    stack.Pop();
                }
                stack.Push(nums2[i]);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dic.ContainsKey(nums1[i]))
                    res[i] = -1;
                else
                    res[i] = dic[nums1[i]];
            }
            return res;
            #endregion

        }
    }
}
