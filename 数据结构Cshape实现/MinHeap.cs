using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据结构Cshape实现;

namespace 数据结构Cshape实现
{
    class MinHeap<T> where T : IComparable<T>//最小堆
    {
        private T[] heap;
        private int N;
        public MinHeap(int capacity)
        {
            heap = new T[capacity + 1];//这个数组中 第0位是弃用的 所以要开辟capacity+1个空间
        }
        public MinHeap() : this(10) { }//默认capacity为10

        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }


        public void Insert(T value)
        {
            if (N == heap.Length - 1)
            {
                ResetCapacity(heap.Length * 2);
            }
            heap[N + 1] = value;
            N++;
            Swim(N);//元素上游


        }
       

        public T GetMin()
        {
            if (IsEmpty)
                throw new ArgumentException("堆为空!!");
            return heap[1];
        }
        public T RemoveMin()//删除只能删除堆顶元素
        {
            if (IsEmpty)
                throw new ArgumentException("堆为空!!");

            Swap(ref heap[1], ref heap[N]);
            T max = heap[N];
            heap[N] = default(T);
            N--;
            if (N <= (heap.Length - 1) / 4)
            {
                ResetCapacity(heap.Length / 2);
            }

            Sink(1);//将堆首元素下沉

            return max;
        }
        private void Swim(int k)
        {
            while (k > 1 && heap[k].CompareTo(heap[k / 2]) < 0)//如果k索引的值小于k/2 也就是k的父节点的值 那么交换这两个元素                                                   //还要加个k>1 因为1是堆首
            {
                Swap(ref heap[k], ref heap[k / 2]);
                k = k / 2;//更新k值
            }
        }
        private void Sink(int k)
        {
            while (2 * k <= N)//k的左孩子还在堆中 才能进行下沉操作
            {
                int j = 2 * k;//j为k的左孩子
                if (j + 1 <= N && heap[j].CompareTo(heap[j + 1]) > 0)//如果k还存在右孩子，且右孩子还比左孩子小 那么k就下沉到右孩子
                    j++;
                if (heap[j].CompareTo(heap[k]) < 0)//如果（左或右）孩子比k小
                    Swap(ref heap[j], ref heap[k]);
                else break;
                k = j;//更新k的值

            }
        }

        private void Swap(ref T t1, ref T t2)
        {
            T temp = t1; t1 = t2; t2 = temp;
        }
        private void ResetCapacity(int newCapacity)
        {
            T[] newHeap = new T[newCapacity];
            for (int i = 1; i <= N; i++)
                newHeap[i] = heap[i];
            heap = newHeap;
        }//数组自动扩容的方法
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format
            // ("Array01:  Capacity:{0}    Count:{1}\n", data.Length, N));
            res.Append("[");
            for (int i = 1; i <= N; i++)
            {
                res.Append(heap[i]);
                if (i != N)
                {
                    res.Append(" ,");
                }
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
