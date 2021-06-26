using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSortGeneric
    {
        public static void Sort<T>(T[] arr) where T:IComparable<T>
        {
            // Console.WriteLine("执行了Sort");
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) >0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
