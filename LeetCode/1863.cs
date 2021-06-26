using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1863//找出所有子集的异或总和再求和
    {
        
        public int SubsetXORSum(int[] nums)
        {
            //List<int> empty = new List<int>();
            int res = 0;
            DFS(nums, 0, 0,ref res);
            return res;
        }
        private void DFS(int[] nums, int index, int curVal,ref int res)
        {
            if (index==nums.Length)
            {
                res += curVal;
                return;
            }
            DFS(nums, index + 1, curVal ^ nums[index],ref res);
            DFS(nums, index + 1, curVal, ref res);
        }
    }
}
