using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort3
    {
        private static Random rd = new Random();
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            Sort(arr, 0, n - 1);
        }
        private static void Sort(int[] arr,int left,int right)
        {
            if (right-left+1<=15)//递归终止条件
            {
                InsertSort.Sort1(arr, left, right);
                return;
            }

            int newLeft = left + rd.Next(right - left + 1);//其实不加1也不影响，因为随机数不缺这个right
            Swap(ref arr[left], ref arr[newLeft]);//将left换成新的随机left

            int lt = left;
            int rt = right;
            int v = arr[left];//需要排序的元素
            //arr[left....lt]<v  将arr分成三分  
            //arr[lt+1...i-1]=v
            //arr[rt+1...right]>v
            for (int i = left+1; i <= rt; i++)
            {
                if (arr[i] < v)
                {
                    lt++;
                    Swap(ref arr[i], ref arr[lt]);
                }
                else if (arr[i] > v)
                {
                    Swap(ref arr[i], ref arr[rt]);
                    i--;rt--;
                }
            }
            Swap(ref arr[lt], ref arr[left]);//将arr[left]插入到合适的位置后，可以开始递归了
            Sort(arr, left, lt);
            Sort(arr, rt + 1, right);
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;v1 = v2;v2 = temp;
        }
    }
}
