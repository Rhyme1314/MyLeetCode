using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MergeSort1
    {//递归+归并排序的时间复杂度为O(nlogn) 相当于把数组分成了一个树 递归操作为log2 n
        //归并排序操作为n 总体时间复杂度就是O(nlogn)
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            Sort(arr, temp, 0, n - 1);

        }
        private static void Sort(int[] arr, int[] temp, int l, int r)
        {
            //Console.WriteLine("Sort({0},{1})",l,r);
            if (l >= r) return;//递归结束

            int mid = l + (r - l) / 2;//防止整型溢出
            //Console.WriteLine("mid:{0}",mid);

            Sort(arr, temp, l, mid);
            Sort(arr, temp, mid + 1, r);//执行递归
            MergeSort(arr, temp, l, r,mid);
        }

        private static void MergeSort(int[] arr, int[] temp, int left, int right, int mid)
        {
            int i = left;int j = mid + 1;
            int k = left;
            while (i<=mid&&j<=right)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];k++;i++;
                }
                else//arr[i]>= arr[j]
                {
                    temp[k] = arr[j];k++;j++;
                }
            }
            while (i<=mid)//j先到达了right+1 超出了索引
            {
                temp[k] = arr[i];k++;i++;
            }
            while (j<=right)//i先到达了mid+1 超过了索引
            {
                temp[k] = arr[j];k++;j++;
            }
            //将temp 已经排好序的部分 重新赋值回去
            for (int z =left; z <=right; z++)
            {
                arr[z] = temp[z];
            }
            //TestHelper.Show(arr);
        }
    }
}
