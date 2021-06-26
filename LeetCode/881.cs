using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
// 第 i个人的体重为 people[i]，每艘船可以承载的最大重量为 limit。

//每艘船最多可同时载两人，但条件是这些人的重量之和最多为 limit。

//返回载到每一个人所需的最小船数。(保证每个人都能被船载)。

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/boats-to-save-people
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _881//救生艇
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);//对people快排
            int res = 0;
            int left = 0;
            int right = people.Length - 1;
            while (left<right)
            {
                if (people[left] + people[right] > limit)
                {
                    right--; res++;
                }
                else
                {
                    right--;left++;res++;
                }
            }
            if (left == right)
                res++;
            return res;
        }

    }
}
