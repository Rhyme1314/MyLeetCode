using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _169//多数元素
    {
        public int MajorityElement(int[] nums)
        {
            #region 哈希表
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(nums[i]))
            //        dic[nums[i]] += 1;
            //    else
            //        dic[nums[i]] = 1;
            //}
            //foreach (int key in dic.Keys)
            //{
            //    int times = dic[key];
            //    if (nums.Length/times <2)
            //        return times;
            //}
            //return 0;
            #endregion
            #region 步骤巨多巨麻烦的分治思想 递归
            //return GetMajority(nums, 0, nums.Length - 1);
            #endregion
            #region 大混战 
            //核心思想就是  不同的元素对对碰 剩下的一定是多数元素 
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (stack.Count==0)//栈为空
                    stack.Push(nums[i]);
                else if (stack.Peek()==nums[i])
                    stack.Push(nums[i]);
                else if (stack.Peek()!=nums[i])
                    stack.Pop();
            }
            return stack.Peek();
            #endregion
        }
        //递归
        private int GetMajority(int[] nums, int left, int right)
        {
            if (left == right) return nums[left];
            int mid = left + (right - left) / 2;//防止整型溢出
            int leftMajor = GetMajority(nums, left, mid);//左半边区域的多数元素
            int rightMajor = GetMajority(nums, mid + 1, right);//右半边区域的多数元素
            if (leftMajor == rightMajor)
                return leftMajor;
            int leftMajorCount = 0;
            int rightMajorCount = 0;
            for (int i = left; i <= right; i++)
            {
                if (nums[i]==leftMajor)
                {
                    leftMajorCount++;
                }
                if (nums[i]==rightMajor)
                {
                    rightMajorCount++;
                }
            }
            return leftMajorCount > rightMajorCount ? leftMajor : rightMajor;
        }
    }
}
