using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class HashST2Dic<KeyT,ValueT>:IDictionary<KeyT,ValueT>
    {
        private HashST2<KeyT, ValueT> hashST2;//用一个HashST2作底层

        public int Count { get { return hashST2.Count; } }

        public bool IsEmpty { get { return hashST2.isEmpty; } }
        //构造函数
        public HashST2Dic(int M)
        {
            hashST2 = new HashST2<KeyT, ValueT>(M);
        }
        public HashST2Dic() : this(97) { }

        public void Add(KeyT key, ValueT value)
        {
            hashST2.Add(key, value);
        }

        public void Remove(KeyT key)
        {
            hashST2.Remove(key);
        }

        public void Set(KeyT key, ValueT newValue)
        {
            hashST2.Set(key, newValue);
        }

        public ValueT Get(KeyT key)
        {
           return  hashST2.Get(key);
        }

        public bool ContainsKey(KeyT key)
        {
            return hashST2.Contains(key);
        }
    }
}
