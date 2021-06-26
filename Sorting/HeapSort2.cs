using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class HeapSort2//原地堆排序
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;//arr长度
                               //先用一个for循环 将arr变成堆
            for (int i = (n-1-1)/2; i>=0 ; i--)//从除了最底层的元素开始，每个元素实行下沉操作
            {
                Sink(arr, i, n - 1);
            }
            //经过上述操作 arr数组已经变成了一个MaxHeap  但是索引是从0开始的
            //下面开始排序 for循环 每次交换堆首元素和堆尾元素 每次交换过后 堆尾元素索引-1
            for (int i = n-1; i >=0; i--)
            {
                Swap(arr, 0, i);//堆首元素为arr[0],堆尾为arr[i] 
                //交换过后的堆首元素需要下沉 维护二叉树平衡
                Sink(arr, 0, i - 1);
            }
        }

        private static void Sink(int[] arr, int k, int N)//需要排序的数组 需要下沉的索引  边界条件
        {
            while (2 * k+1 <= N)//k的左孩子还在堆中 才能进行下沉操作
            {
                int j = 2 * k+1;//j为k的左孩子
                if (j + 1 <= N && arr[j].CompareTo(arr[j + 1]) < 0)//如果k还存在右孩子，且右孩子还比左孩子大 那么k就下沉到右孩子
                    j++;
                if (arr[j].CompareTo(arr[k]) > 0)//如果（左或右）孩子比k大
                    Swap(arr,k,j);
                else break;
                k = j;//更新k的值

            }
        }

        private static void Swap(int[] arr, int k, int j)
        {
            int temp = arr[k];arr[k] = arr[j];arr[j] = temp;
        }
    }
}
