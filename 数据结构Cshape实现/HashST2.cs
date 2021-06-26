using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class HashST2<KeyT,ValueT>
    {
        LinkedList3<KeyT,ValueT>[] hashTables;
        private int N;
        private int M;
        public HashST2(int M)//M为质数，用来取余的
        {
            this.M = M; N = 0;
            hashTables = new LinkedList3<KeyT,ValueT>[M];//那么就有M个链表
            for (int i = 0; i < M; i++)
            {
                hashTables[i] = new LinkedList3<KeyT, ValueT>();
            }
        }
        public HashST2() : this(97) { } //如果不输入 默认M为97
        public int Count { get { return N; } }
        public bool isEmpty { get { return N == 0; } }
        private int Hash(KeyT key)//计算key的哈希值
        {
            return (key.GetHashCode() & 0x7fffffff) % M;//返回一个0到M-1的int
        }
        public void Add(KeyT key,ValueT value)
        {
            LinkedList3<KeyT,ValueT> link = hashTables[Hash(key)];
            if (link.ContainsKey(key))
                link.Set(key, value);
            else
            { link.Add(key,value); N++; }
        }
        public void Remove(KeyT key)
        {
            LinkedList3<KeyT,ValueT> link = hashTables[Hash(key)];
            if (link.ContainsKey(key))
            { link.Remove(key); N--; }
        }
        public bool Contains(KeyT key)
        {
            LinkedList3<KeyT,ValueT> link = hashTables[Hash(key)];
            return link.ContainsKey(key);
        }
        public ValueT Get(KeyT key)
        {
            LinkedList3<KeyT, ValueT> link = hashTables[Hash(key)];
            if (link.ContainsKey(key))
                return link.Get(key);
            else throw new ArgumentException("该键不存在");
        }
        public void Set(KeyT key, ValueT value)
        {
            LinkedList3<KeyT, ValueT> link = hashTables[Hash(key)];
            if (link.ContainsKey(key))
                link.Set(key, value);
            else throw new ArgumentException("该键不存在");
        }
    }
}

