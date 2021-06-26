using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _134//加油站 
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            #region 暴力法都是抄的
            //int n = gas.Length;
            //for (int i = 0; i < gas.Length; i++)
            //{
            //    int j = i; int remain = gas[i];
            //    while (remain - cost[j] >= 0)
            //    {
            //        remain = remain - cost[j] + gas[(j + 1) % n];
            //        j = (j + 1) % n;
            //        if (j == i)
            //            return i;
            //    }
            //}
            //return -1;
            #endregion
            int n = gas.Length;
            int SumGas = 0;int SumCost = 0;
            for (int i = 0; i < n; i++)
                SumGas += gas[i];
            for (int i = 0; i < n; i++)
                SumCost += cost[i];
            if (SumCost>SumGas)
                return -1;
            //int start = 0;int remain = gas[start];
            for (int i = 0; i < n;)
            {
                if (gas[i]<cost[i])
                {
                    i++;
                }
                else
                {
                    int remain = gas[i]-cost[i];//跑完起点后所剩下的油
                    int index = i + 1;//从索引 i+1个往后遍历
                    while (index!=i)
                    {
                        remain = remain + gas[index%n] - cost[index%n];
                        if (remain<0)
                            break;
                        index++;
                    }
                    if (index%n ==i)
                        return i;
                    i = index;
                }
            }
            return -1;
        }
    }
}
