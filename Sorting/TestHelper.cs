using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class TestHelper
    {//生成有n个元素的随机数组，每个元素的随机范围为[0,maxValue]
      

        public static int[] RandomArray(int n ,int maxValue)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(maxValue + 1);
            }
            return arr;
        }
        public static int[] NearlyOrderedArray(int n,int swapTimes)//交换次数
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;//先做一个0到n-1的有序数组
            }
            Random random = new Random();
            for (int i = 0; i < swapTimes; i++)
            {
                int a = random.Next(n);//随机交换两个索引
                int b = random.Next(n);
                int temp = arr[a];arr[a] = arr[b];arr[b] = temp;
            }
            return arr;
        }
        private static void IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]>arr[i+1])
                    throw new ArgumentException("排序失败");
            }
        }
        public static int[] CopyArray(int[] arr)//拷贝一个数组 不能直接 int[] temp = arr 因为数组是引用类型 这样temp和arr是同一个数组
        {
            int[] temp = new int[arr.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }
        public static void TestSort(string sortClassName,int[] arr)//排序方法 和需要排序的数组
        {
            Type type = Type.GetType("Sorting." + sortClassName);
            MethodInfo sortMethod = type.GetMethod("Sort");
            object[] paramsarr = new object[] { arr };
            Stopwatch sw = new Stopwatch();
            sw.Start();
            sortMethod.Invoke(null,paramsarr);
            sw.Stop();
            IsSorted(arr);
            Console.WriteLine(type.Name+":"+sw.ElapsedMilliseconds+"ms");
        }

        public static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write( arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
