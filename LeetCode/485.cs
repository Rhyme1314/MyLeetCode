using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _485
    {
        //int[] nums = { 1,1,0,1,1,1};
        public static int Test(int[] nums)
        {
            #region 暴力解法
            int curNum = 0;
            int maxNum = 0;
            if (nums.Length == 0 || nums == null) return 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    curNum++;
                else 
                {
                    maxNum = Math.Max(curNum, maxNum);
                    curNum = 0;
                }
            }
            maxNum = Math.Max(curNum, maxNum);
            return maxNum;
            #endregion

            // Console.WriteLine(maxNum);
        }
    }
}
