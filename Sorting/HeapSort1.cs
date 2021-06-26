using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class HeapSort1
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            MaxHeap<int> maxHeap = new MaxHeap<int>(n);
            for (int i = 0; i < arr.Length; i++)
            {
                maxHeap.Insert(arr[i]);
            }
            for (int i = arr.Length-1; i >=0; i--)
            {
                arr[i] = maxHeap.RemoveMax();
            }
        }
    }
}
