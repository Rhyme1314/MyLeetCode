using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _486//预测赢家
    {
        public bool PredictTheWinner(int[] nums)
        {
            int n = nums.Length;
            int[,] dp = new int[n, n];//dp[i,j]表示从i-j中取i或j 能达到的最大净分差
            for (int i = 0; i < n; i++)
                dp[i, i] = nums[i];//当i=j时 只能取到num[i] 那么num[i]就是最大净分差
            for (int i =n-2; i >=0; i--)
            {
                for (int j = i+1; j < n; j++)
                {
                    dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
                }
            }
            return dp[0, n - 1] >= 0;


            //return DFS(nums,0,nums.Length-1)>0;
        }
        private int DFS(int[] nums,int left,int right) {//表示净分差
            if (left==right)
            {
                return nums[left];
            }
            return Math.Max(nums[left] - DFS(nums,left+1,right),
                            nums[right]  - DFS(nums,left,right-1));//肯定都要使净分差最大啦



            //if (left==right)
            //{
            //    return nums[left] * turn;//turn为1是我拿  turn为-1别人拿 我要减去别人拿的 只要>0了 就是我赢
            //}
            //int leftNum = nums[left] * turn + DFS(nums, left + 1, right, -turn);//我拿左边所获得的分
            //int RightNum = nums[right] * turn + DFS(nums, left, right-1, -turn);//我拿右边所获得的分
            //return Math.Max(leftNum*turn, RightNum*turn)*turn;

        }
    }
}
