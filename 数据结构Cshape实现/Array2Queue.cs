using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class Array2Queue<T> : IQueue<T>
    {
        private Array02<T> arr;
        //入队操作放在队尾O(1)  出队操作放在队首O(1)
        public int Count { get { return arr.Count; } }
        public bool IsEmpty { get { return arr.IsEmpty; } }


        //构造函数
        public Array2Queue(int capacity)
        {
            arr = new Array02<T>(capacity);
        }
        public Array2Queue()
        {
            arr = new Array02<T>();
        }

        public void Enqueue(T e)
        {
            arr.AddLast(e);
        }//O(1)
        public T Dequeue()
        {
            return arr.RemoveFirst();
        }//O(1)
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
