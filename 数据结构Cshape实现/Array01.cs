    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class Array01<T>
    {
        private T[] data;//
        private int N;//数组中实际的元素数量

        public Array01(int capacity)
        {
            data = new T[capacity];
            N = 0;
        }
        public Array01() : this(10) { }

        private void ResetCapacity(int newCapacity)
        {
            T[] newData = new T[newCapacity];
            for (int i = 0; i < N; i++)
                newData[i] = data[i];
            data = newData;
        }//数组自动扩容的方法
        public int Capacity
        {
            get { return data.Length; }
        }
        public int Count
        {
            get { return N; }
        }
        public bool IsEmpty
        {
            get { return N == 0; }
        }
        public void Add(int index, T e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
                ResetCapacity(2 * data.Length);//自动扩容

            for (int i = N - 1; i >= index; i--)
                data[i + 1] = data[i];

            N++;
            data[index] = e;
        }
        public void AddLast(T e)
        {
            Add(N, e);
        }
        public void AddFirst(T e)
        {
            Add(0, e);
        }
        public T Get(int index)
        {

            if (index < 0 || index >= N)
            {
                throw new ArgumentException("数组索引越界");
            }
            return data[index];
        }
        public T GetFirst()
        {
            return Get(0);
        }
        public T GetLast()
        {
            return Get(N - 1);
        }
        public void Set(int index, T e)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");
            data[index] = e;

        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format
            // ("Array01:  Capacity:{0}    Count:{1}\n", data.Length, N));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                {
                    res.Append(" ,");
                }
            }
            res.Append("]");
            return res.ToString();
        }
        public bool Contains(T e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))//比较他们在内存中的地址
                    return true;
            }
            return false;
        }
        public int IndexOf(T e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return -1;
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");
            T del = data[index];
            for (int i = index + 1; i < N; i++)
            {
                data[i - 1] = data[i];
            }
            data[N - 1] = default(T);//T是值类型 默认为0  引用类型默认为null
            N--;

            if (N == data.Length / 4)
            {
                ResetCapacity(data.Length / 2);
            }

            return del;
        }
        public T RemoveLast()
        {
            return RemoveAt(N - 1);
        }
        public T RemoveFirst()
        {
            return RemoveAt(0);
        }
        public void Remove(T e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    RemoveAt(i);
            }
        }
    }
}
