using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class SortedArray2<KeyT, ValueT> where KeyT : IComparable<KeyT>
    {
        private KeyT[] keys;
        private ValueT[] values;
        private int N;//有序数组的元素数量
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }
        public SortedArray2(int capacity)
        {
            keys = new KeyT[capacity];
            values = new ValueT[capacity];
        }
        public SortedArray2() : this(10) { }

        public int Rank(KeyT key)//key(这个key可以不是keys中的元素)在keys中的索引
        {
            int l = 0;
            int r = N - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (key.CompareTo(keys[mid]) > 0)
                    l = mid + 1;
                else if (key.CompareTo(keys[mid]) < 0)
                    r = mid - 1;
                else return mid;//找到了该key的索引 返回
            }
            return l;//没找到该key，返回最近的大于该key的key索引
        }
        public ValueT GetValue(KeyT key)
        {
            if (IsEmpty)
                throw new ArgumentException("数组为空");
            int i = Rank(key);
            if (i < N && key.CompareTo(keys[i]) == 0)
                return values[i];
            else
                throw new ArgumentException("要查找的键不存在");
        }
        public void Add(KeyT key, ValueT value)
        {
            if (N == keys.Length)
                ResetCapacity(2 * keys.Length);//自动扩容
            int i = Rank(key);
            if (i < N && key.CompareTo(keys[i]) == 0)
            {
                values[i] = value;
                return;
            }

            else
            {

                for (int j = N - 1; j >= i; j--)
                {
                    keys[j + 1] = keys[j];
                    values[j + 1] = values[j];
                }
                keys[i] = key;
                values[i] = value;
                N++;
            }

        }
        public void Remove(KeyT key)
        {
            if (IsEmpty)
                return;
            int i = Rank(key);
            if (i >= N || key.CompareTo(keys[i]) != 0)
                return;
            for (int j = i; j < N - 1; j++)
            {
                keys[j] = keys[j + 1];
                values[j] = values[j + 1];
            }
            N--;
            keys[N] = default(KeyT);
            values[N] = default(ValueT);
            if (N == keys.Length / 4)
                ResetCapacity(keys.Length / 2);//自动缩容
        }
        public KeyT Max()
        {
            return keys[N - 1];
        }
        public KeyT Min()
        {
            return keys[0];
        }
        public KeyT Select(int k)
        {
            if (k < 0 || k >= N)
                throw new ArgumentException("数组越界");
            return keys[k];
        }
        public bool ContainsKey(KeyT key)
        {
            int i = Rank(key);
            if (i < N && key.CompareTo(keys[i]) == 0)
                return true;

            return false;
        }
        public KeyT Floor(KeyT key)//找出小于或等于输入key的最大键
        {
            int i = Rank(key);
            if (i < N && key.CompareTo(keys[i]) == 0)
                return keys[i];
            if (i == 0)
                throw new ArgumentException("没有找到小于或等于" + key + "的最大键");
            return keys[i - 1];
        }
        public KeyT Ceiling(KeyT key)//找出大于或等于输入key的最小键
        {
            int i = Rank(key);

            if (i == N)
                throw new ArgumentException("没有找到大于或等于" + key + "的最小键");
            return keys[i];

        }


        private void ResetCapacity(int newCapacity)
        {
            KeyT[] newKeys = new KeyT[newCapacity];
            ValueT[] newValues = new ValueT[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newKeys[i] = keys[i];
                newValues[i] = values[i];
            }
            keys = newKeys;
            values = newValues;
        }//数组自动扩容的方法
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append("{"+ keys[i]+":"+values[i]+"}");
                if (i != N - 1)
                {
                    res.Append(" ,");
                }
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
