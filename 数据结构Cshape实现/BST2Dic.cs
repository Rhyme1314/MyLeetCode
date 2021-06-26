using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class BST2Dic<KeyT,ValueT>:IDictionary<KeyT,ValueT> where KeyT:IComparable<KeyT>
    {
        private BST2<KeyT, ValueT> bst2;
        public BST2Dic()
        {
            bst2 = new BST2<KeyT, ValueT>();
        }

        public int Count { get { return bst2.Count; } }

        public bool IsEmpty { get { return bst2.IsEmpty; } }

        public void Add(KeyT key, ValueT value)
        {
            bst2.Add(key, value);
        }

        public bool ContainsKey(KeyT key)
        {
            return bst2.Contains(key);
        }

        public ValueT Get(KeyT key)
        {
            return bst2.GetValue(key);
        }

        public void Remove(KeyT key)
        {
            bst2.Remove(key);
        }

        public void Set(KeyT key, ValueT newValue)
        {

            bst2.Set(key, newValue);
        }
    }
}
