using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SelectSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int min = i;//最小数的索引
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                Swap(ref arr[i], ref arr[min]);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
    }
}
