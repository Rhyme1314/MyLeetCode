using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _401//二进制手表
    {
        IList<string> res = new List<string>();
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            int[] nums = { 8, 4, 2, 1, 32, 16, 8, 4, 2, 1 };
            DFS(turnedOn, nums, 0, 0, 0);
            return res;
        }
        private void DFS(int turnedOn, int[] nums, int index, int hours, int minutes)
        {
            if (turnedOn == 0)
            {
                StringBuilder str = new StringBuilder();
                str.Append(hours);
                str.Append(":");
                if (minutes<10)
                {
                    str.Append(0);
                }
                str.Append(minutes);
                res.Add(str.ToString());
            }
            for (int i = index; i < nums.Length; i++)
            {
                if (i<4&&hours+nums[i]<=11)
                {
                    DFS(turnedOn - 1, nums, i + 1, hours + nums[i], minutes);
                }
                if (i >= 4 && minutes + nums[i] <= 59)
                {
                    DFS(turnedOn - 1, nums, i + 1, hours, minutes+nums[i]);
                }
            }

        }
    }
}
