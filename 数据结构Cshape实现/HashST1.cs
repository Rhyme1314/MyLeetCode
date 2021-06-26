using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class HashST1<KeyT>
    {
        LinkedList1<KeyT>[] hashTables;
        private int N;
        private int M;
        public HashST1(int M)//M为质数，用来取余的
        {
            this.M = M; N = 0;
            hashTables = new LinkedList1<KeyT>[M];//那么就有M个链表
            for (int i = 0; i < M; i++)
            {
                hashTables[i] = new LinkedList1<KeyT>();
            }
        }
        public HashST1() : this(97) { } //如果不输入 默认M为97
        public int Count { get { return N; } }
        public bool isEmpty { get { return N == 0; } }
        private int Hash(KeyT key)//计算key的哈希值
        {
            return (key.GetHashCode() & 0x7fffffff) % M;//返回一个0到M-1的int
        }
        public void Add(KeyT key)
        {
            LinkedList1<KeyT> link = hashTables[Hash(key)];
            if (link.Contains(key))
                return;
            else
            { link.AddFirst(key); N++; }
        }
        public void Remove(KeyT key)
        {
            LinkedList1<KeyT> link = hashTables[Hash(key)];
            if (link.Contains(key))
            { link.Remove(key); N--; }
        }
        public bool Contains(KeyT key)
        {
            LinkedList1<KeyT> link = hashTables[Hash(key)];
            return link.Contains(key);
        }
    }
}
