using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class Array02<T>
    {
        private T[] data;
        private int N;//数组的Count
        private int First;//队首元素在data中的索引
        private int Last;//队尾元素在data中的索引
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }
        //构造函数
        public Array02(int capacity)
        {
            data = new T[capacity];
            N = 0;

            First = 0;
            Last = 0;
        }
        public Array02() : this(10) { }//默认capacity为10
        //实现一些操作方法
        public void AddLast(T e)//在data[Last]中添加元素
        {
            if (N == data.Length)
                ResetCapacity(2 * N);//扩容
            data[Last] = e;
            Last = (Last + 1) % data.Length;//完成循环的关键语句
            N++;
        }
        public T RemoveFirst()//移除data[First]并返回
        {
            if (IsEmpty)
                throw new InvalidOperationException("数组为空");
            T del = data[First];
            data[First] = default(T);
            First = (First + 1) % data.Length;
            N--;

            if (N == data.Length / 4)
                ResetCapacity(data.Length / 2);//缩容
            return del;
        }
        public T GetFirst()//查看队首元素
        {
            if (IsEmpty)
                throw new InvalidOperationException("数组为空");
            return data[First];
        }
        private void ResetCapacity(int newCapacity)//数组扩容
        {
            T[] newData = new T[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newData[i] = data[(First + i) % data.Length];
            }
            data = newData;
            First = 0; Last = N;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[(First + i) % data.Length]);
                if ((First + i ) % data.Length != Last)
                    res.Append(",");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
