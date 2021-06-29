using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _560//和为K的子数组  //前缀和
    {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int res = 0;int sum = 0;
            dic[0] = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dic.ContainsKey(sum - k))
                    res += dic[sum - k];
                if (!dic.ContainsKey(sum))
                    dic[sum] = 1;
                else dic[sum]++;
            }
            return res;
            
        }

       
        
    }
}
