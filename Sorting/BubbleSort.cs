using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSort
    {
        public static void Sort(int[] arr)
        {
           // Console.WriteLine("执行了Sort");
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            #region 写法2
            //bool isBubble = true;
            //while (isBubble)
            //{
            //    isBubble = false;
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            Swap(ref arr[i], ref arr[i + 1]);
            //            isBubble = true;
            //        }
            //    }
            //}
            #endregion
        }

        private static void Swap(ref int a,ref  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
