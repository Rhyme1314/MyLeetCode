using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 测试排序方法的泛型
            //int[] arr1 = { 4, 3, 6, 5, 1, 2, 0 };
            //string[] strs = { "C", "A", "D", "F", "B", "E" };
            //float[] flos = { 0.22f, 0.14f, 0.37f, 1.64f, 0.87f, 0.01f };
            //Data[] datas = {
            //    new Data (2021,12,24,"荧"),
            //    new Data (2021,7,27,"可莉"),
            //    new Data (2021,2,14,"北斗"),
            //   new Data (2021,6,16,"温迪"),
            //      new Data (2021,4,30,"迪卢克"),

            //   new Data (2021,2,29,"班尼特"),
            //       new Data (2021,4,17,"魈"),

            //   new Data (2021,7,5,"芭芭拉"),
            //   new Data (2021,5,27,"菲谢尔"),
            //   new Data (2021,6,9,"丽莎"),
            //     new Data (2021,3,3,"七七"),
            //   new Data (2021,3,14,"琴"),
            //   new Data (2021,3,21,"诺艾尔"),



            //};
            #endregion


            int N = 1000000;
            Console.WriteLine("对普通大随机数组排序性能");

            int[] arr1 = TestHelper.RandomArray(N, N);
            int[] arr2 = TestHelper.CopyArray(arr1);
            int[] arr3 = TestHelper.CopyArray(arr1);
            int[] arr4 = TestHelper.CopyArray(arr1);
            int[] arr5 = TestHelper.CopyArray(arr1);
            int[] arr6 = TestHelper.CopyArray(arr1);
            //TestHelper.TestSort("QuickSort1", arr1);
            //TestHelper.TestSort("QuickSort2", arr2);
            TestHelper.TestSort("QuickSort3", arr3);
            TestHelper.TestSort("MergeSort2", arr4);
            TestHelper.TestSort("HeapSort1", arr5);
            TestHelper.TestSort("HeapSort2", arr6);
            Console.WriteLine();


            Console.WriteLine("对大的近乎有序数组排序性能");
            int[] arr21 = TestHelper.NearlyOrderedArray(N, 100);//100W个元素只有 200个元素不在排序位置上
            int[] arr22 = TestHelper.CopyArray(arr21);
            int[] arr23 = TestHelper.CopyArray(arr21);
            int[] arr24 = TestHelper.CopyArray(arr21);
            int[] arr25 = TestHelper.CopyArray(arr21);
            //TestHelper.TestSort("QuickSort2", arr21);
            TestHelper.TestSort("QuickSort3", arr22);
            TestHelper.TestSort("MergeSort2", arr23);
            TestHelper.TestSort("HeapSort1", arr24);
            TestHelper.TestSort("HeapSort2", arr25);
            Console.WriteLine();

            Console.WriteLine("对大的有大量重复元素的数组排序性能");
            int[] arr31 = TestHelper.RandomArray(N, 10);//100W 个元素里面 只有10个数，所以肯定有大量重复的
            int[] arr32 = TestHelper.CopyArray(arr31);
            int[] arr33 = TestHelper.CopyArray(arr31);
            int[] arr34 = TestHelper.CopyArray(arr31);
            TestHelper.TestSort("QuickSort3", arr31);
            TestHelper.TestSort("MergeSort2", arr32);
            TestHelper.TestSort("HeapSort1", arr33);
            TestHelper.TestSort("HeapSort2", arr34);
            Console.WriteLine();

            //MaxHeap<int> maxHeap = new MaxHeap<int>();
            //int[] arr = { 3, 1, 5, 4, 2 };
            //HeapSort1.Sort(arr);//堆排序
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    maxHeap.Insert(arr[i]);
            //    Console.WriteLine(maxHeap);
            //}
            //maxHeap.RemoveMax();
            //Console.WriteLine(maxHeap);



















            Console.ReadKey();




            //排序性能测试
            


            //int N = 1000000;
            //int[] arr1 = TestHelper.RandomArray(N, 10);
            //int[] arr2 = TestHelper.NearlyOrderedArray(N, 100);//快排在排序近乎有序数组时，近乎是O(n^2)的时间复杂度
            //int[] arr3 = TestHelper.CopyArray(arr1);//arr 和 arr2两个一模一样的数组
            // TestHelper.TestSort("QuickSort1", arr3);
            //TestHelper.TestSort("QuickSort2", arr1);
            //TestHelper.TestSort("QuickSort3", arr1);//具有很多重复元素的数组， 看下随机化快排的性能

            // QuickSort1.Sort(arr1);
            //int[] arr2 = { 3, 3, 1, 7, 3, 3, 3, 3, 6, 3, 2, 8 };
            //QuickSort3.Sort(arr2);

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}


        }
    }
}
