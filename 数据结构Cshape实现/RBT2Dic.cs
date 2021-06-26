using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class RBT2Dic<KeyT,ValueT>:IDictionary<KeyT,ValueT> where KeyT:IComparable<KeyT>
    {
        private RBT2<KeyT, ValueT> rbt2;
        public RBT2Dic()
        {
            rbt2 = new RBT2<KeyT, ValueT>();
        }

        public int Count { get { return rbt2.Count; } }

        public bool IsEmpty { get { return rbt2.IsEmpty; } }

        public void Add(KeyT key, ValueT value)
        {
            rbt2.Add(key, value);
        }

        public bool ContainsKey(KeyT key)
        {
            return rbt2.Contains(key);
        }

        public ValueT Get(KeyT key)
        {
            return rbt2.GetValue(key);
        }

        public void Remove(KeyT key)
        {
            Console.WriteLine("删除方法待实现");
        }

        public void Set(KeyT key, ValueT newValue)
        {
            rbt2.Set(key, newValue);
        }
    }
}
