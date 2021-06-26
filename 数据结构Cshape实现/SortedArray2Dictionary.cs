using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class SortedArray2Dictionary<KeyT,ValueT>:IDictionary<KeyT,ValueT> where KeyT:IComparable<KeyT>
    {
        private SortedArray2<KeyT, ValueT> sortedArray2;

        public int Count { get { return sortedArray2.Count; } }

        public bool IsEmpty { get { return sortedArray2.IsEmpty; } }

        public SortedArray2Dictionary(int capacity)
        {
            sortedArray2 = new SortedArray2<KeyT, ValueT>(capacity);
        }
        public SortedArray2Dictionary() : this(10) { }

        public void Add(KeyT key, ValueT value)
        {
            sortedArray2.Add(key, value);
        }

        public void Remove(KeyT key)
        {
            sortedArray2.Remove(key);
        }

        public void Set(KeyT key, ValueT newValue)
        {
            sortedArray2.Add(key, newValue);
        }

        public ValueT Get(KeyT key)
        {
           return  sortedArray2.GetValue(key);
        }

        public bool ContainsKey(KeyT key)
        {
            return sortedArray2.ContainsKey(key);
        }
    }
}
