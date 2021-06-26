using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class Array1Queue<T> : IQueue<T>
    {
        private Array01<T> arr;
        //入队操作放在队尾O(1)  出队操作放在队首O(n)
        public int Count { get { return arr.Count; } }
        public bool IsEmpty { get { return arr.IsEmpty; } }


        //构造函数
        public Array1Queue(int capacity)
        {
            arr = new Array01<T>(capacity);
        }
        public Array1Queue()
        {
            arr = new Array01<T>();
        }

        public void Enqueue(T e)
        {
            arr.AddLast(e);
        }//O(1)
        public T Dequeue()
        {
            return  arr.RemoveFirst();
        }//O(n)
        public T Peek()//O(1)
        {
            return arr.GetFirst();
        }
        public override string ToString()
        {
            return "Queue:front  [" + arr.ToString() + "]  tail";
        }
    }
}
