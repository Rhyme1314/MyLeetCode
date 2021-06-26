using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _933
    {
        Queue<int> queue;
        public _933()
        {
           queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            #region 严格控制t的大小顺序
            //bool flag = true;
            //if (queue.Count==0)
            //{
            //    queue.Enqueue(t);
            //    return 1;
            //}
            //foreach (int num in queue)
            //{
            //    if (t<num)
            //        flag = false;
            //}
            //if (flag)
            //{
            //    queue.Enqueue(t);//入队
            //    while (t - queue.Peek() > 3000)
            //    {
            //        queue.Dequeue();
            //    }

            //}


            //return queue.Count;
            #endregion
            #region 不控制t的大小顺序 
            if (queue.Count == 0)
            {
                queue.Enqueue(t);
                return 1;
            }
            queue.Enqueue(t);
            while (t - queue.Peek() > 3000)
            {
                queue.Dequeue();
            }

            return queue.Count;
            #endregion
        }
    }
}

