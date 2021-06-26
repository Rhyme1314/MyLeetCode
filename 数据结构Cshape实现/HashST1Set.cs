using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class HashST1Set<KeyT>:ISet<KeyT>
    {
        private HashST1<KeyT> hashST1;//哈希表作为底层

        public int Count { get { return hashST1.Count; } }

        public bool IsEmpty { get { return hashST1.isEmpty; } }

        public HashST1Set(int M)
        {
            hashST1 = new HashST1<KeyT>(M);
        }
        public HashST1Set() : this(97) { }

        public void Add(KeyT key)
        {
            hashST1.Add(key);
        }

        public void Remove(KeyT key)
        {
            hashST1.Remove(key);
        }

        public bool Contains(KeyT key)
        {
            return hashST1.Contains(key);
        }
    }
}
