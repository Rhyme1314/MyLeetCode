using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList3Dictionary<KeyT,ValueT>:IDictionary<KeyT,ValueT>
    {
        private LinkedList3<KeyT, ValueT> list3;
        public LinkedList3Dictionary()
        {
            list3 = new LinkedList3<KeyT, ValueT>();
        }

        public int Count { get { return list3.Count; } }

        public bool IsEmpty { get { return list3.IsEmpty; } }

        public void Add(KeyT key, ValueT value)
        {
            list3.Add(key, value);
        }

        public bool ContainsKey(KeyT key)
        {
            return list3.ContainsKey(key);
        }

        public ValueT Get(KeyT key)
        {
            return list3.Get(key);
        }

        public void Remove(KeyT key)
        {
            list3.Remove(key);
        }

        public void Set(KeyT key, ValueT newValue)
        {
            list3.Set(key, newValue);
        }
    }
}
