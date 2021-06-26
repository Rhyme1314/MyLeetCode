using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertSort
    {
        //插入排序 因为很像我们打扑克时候调整牌序  所以我们把arr的元素就当场是牌
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int e = arr[i];//取出索引为i的牌 和i之前的所有牌进行对比，如果大于e 则往后挪一格
                int j;//j是e最终插入的位置
                for ( j = i; j >0; j--)
                {
                    if (arr[j-1] > e)
                    {
                        arr[j] = arr[j-1];//往后挪一个
                    }
                    else  break;//如果某一个前面的元素不再比e大，那么说明这个元素之前的元素肯定也小于e，则不必再继续比较，跳出循环
                }
                arr[j] = e;
                //最后 将e也就是arr[i]插入到arr[j]中 不必担心元素丢失，因为arr[j]肯定是空了
            }
        }
        //对arr[l...r]
        public static void Sort1(int[] arr,int l,int r)
        {
            for (int i = l+1; i <= r; i++)
            {
                int e = arr[i];//取出索引为i的牌 和i之前的所有牌进行对比，如果大于e 则往后挪一格
                int j;//j是e最终插入的位置
                for (j = i; j > l; j--)
                {
                    if (arr[j - 1] > e)
                    {
                        arr[j] = arr[j - 1];//往后挪一个
                    }
                    else break;//如果某一个前面的元素不再比e大，那么说明这个元素之前的元素肯定也小于e，则不必再继续比较，跳出循环
                }
                arr[j] = e;
                //最后 将e也就是arr[i]插入到arr[j]中 不必担心元素丢失，因为arr[j]肯定是空了
            }
        }
    }
}
