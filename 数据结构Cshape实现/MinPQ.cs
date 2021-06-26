using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    //最大优先队列
    class MinPQ<T> : IQueue<T> where T : IComparable<T>
    {
        MinHeap<T> minHeap;
        private int N;
        public MinPQ(int capacity)
        {
            minHeap = new MinHeap<T>(capacity);
        }
        public MinPQ() : this(10) { }
        public int Count { get { return minHeap.Count; } }

        public bool IsEmpty { get { return minHeap.IsEmpty; } }

        public void Enqueue(T e)
        {
            minHeap.Insert(e);
        }

        public T Dequeue()
        {
            return minHeap.RemoveMin();
        }

        public T Peek()
        {
            return minHeap.GetMin();
        }
        public override string ToString()
        {
            return minHeap.ToString();
        }
    }
}
