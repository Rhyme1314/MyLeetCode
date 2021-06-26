using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class TestSearch
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (target > arr[mid])
                    l = mid + 1;
                else if (target < arr[mid])
                    r = mid - 1;
                else return mid;//target在数组中的索引
            }
            return -1;//没找到 返回一个无效值
        }
       
    }
}
