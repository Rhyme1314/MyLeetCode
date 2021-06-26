using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class SortedArray1Set<KeyT>:ISet<KeyT> where KeyT:IComparable<KeyT>
    {
        private SortedArray1<KeyT> sortedArray1;

        public int Count { get { return sortedArray1.Count; } }

        public bool IsEmpty { get { return sortedArray1.IsEmpty; } }

        public SortedArray1Set(int capacity)
        {
            sortedArray1 = new SortedArray1<KeyT>(10);
        }
        public SortedArray1Set() : this(10) { }

        public void Add(KeyT key)
        {
            sortedArray1.Add(key);
        }

        public void Remove(KeyT key)
        {
            sortedArray1.Remove(key);
        }

        public bool Contains(KeyT key)
        {
            return sortedArray1.ContainsKey(key);
        }
        public KeyT Get(int k)
        {
            return sortedArray1.Select(k);
        }
    }
}
