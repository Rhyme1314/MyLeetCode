using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    //最大优先队列
    class MaxPQ<T> : IQueue<T> where T : IComparable<T>
    {
        MaxHeap<T> maxHeap;
        private int N;
        public MaxPQ(int capacity)
        {
            maxHeap = new MaxHeap<T>(capacity);
        }
        public MaxPQ() : this(10) { }
        public int Count { get { return maxHeap.Count; } }

        public bool IsEmpty { get { return maxHeap.IsEmpty; } }

        public void Enqueue(T e)
        {
            maxHeap.Insert(e);
        }

        public T Dequeue()
        {
            return maxHeap.RemoveMax();
        }

        public T Peek()
        {
            return maxHeap.GetMax();
        }

        public override string ToString()
        {
            return maxHeap.ToString();
        }
    }
}
