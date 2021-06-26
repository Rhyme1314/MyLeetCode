using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _215
    {
        #region 堆解法
        //private int[] maxHeap;
        //int N = 0;

        //public int FindKthLargest(int[] nums, int k)
        //{
        //    if (nums.Length == 0)
        //        return 0;
        //    int max = nums[0];
        //    maxHeap = new int[nums.Length + 1];
        //    for (int i = 0; i < nums.Length; i++)
        //        Insert(nums[i]);
        //    for (int i = 1; i <= k; i++)
        //    {
        //        max = RemoveMax();
        //    }
        //    return max;
        //}
        //public void Insert(int value)
        //{

        //    maxHeap[N+1] = value;
        //    N++;
        //    Swim(N);//第N个元素上游
        //}
        //public int RemoveMax()
        //{
        //    if (N == 0)
        //        throw new ArgumentException("堆为空");
        //    Swap(maxHeap,1, N);
        //    int max = maxHeap[N];
        //    maxHeap[N] = default(int);
        //    N--;

        //    Sink(1);
        //    return max;
        //}

        //private void Sink(int k)
        //{
        //    while (2*k<=N)
        //    {
        //        int j = 2 * k;
        //        if (j+1<=N && maxHeap[j] < maxHeap[j + 1]) j++;//左孩子变右孩子
        //        if (maxHeap[k] < maxHeap[j])
        //        {
        //            Swap(maxHeap, k, j);
        //            k = j;
        //        }
        //        else break;
        //    }
        //}

        //private void Swim(int k)
        //{
        //    while (k>1 && maxHeap[k]>maxHeap[k/2])
        //    {
        //        Swap(maxHeap, k, k / 2);
        //        k = k / 2;
        //    }
        //}

        //private void Swap(int[] maxHeap, int k, int v)
        //{
        //    int temp = maxHeap[k];maxHeap[k] = maxHeap[v];maxHeap[v] = temp;
        //}
        #endregion
        #region 快排解法
        //public int FindKthLargest(int[] nums, int k)
        //{
        //    Array.Sort(nums);//直接快排
        //    return nums[nums.Length-k+1];

        //}
        #endregion
    }
}
