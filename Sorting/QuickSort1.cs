using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort1
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            Sort(arr, 0, n - 1);
        }
        private static void Sort(int[] arr,int left,int right)
        {
            if (right-left+1<=15)//递归结束 
            {
                InsertSort.Sort1(arr,left,right);
                return;
            }

            int j = left;//快排 通过ij两个索引 把arr分成 
            //arr[left+1.....j]<arr[left]
            //arr[j+1......i-1]>=arr[left]两部分  然后把arr[left]和arr[j]交换，就可以实现arr[left]在这个数组中的正确位置
            for (int i = left+1; i <= right; i++)
            {
                if (arr[i] < arr[left])
                {
                    j++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[j], ref arr[left]);//这样arr[j]就是在数组中的正确位置 那么就可以进行递归
            Sort(arr, left, j - 1);
            Sort(arr, j + 1, right);
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;v1 = v2;v2 = temp;
        }
    }
}
