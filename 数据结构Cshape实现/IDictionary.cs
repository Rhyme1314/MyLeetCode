using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    interface IDictionary<KeyT,ValueT>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Add(KeyT key, ValueT value);
        void Remove(KeyT key);//移除某个键上的值
        void Set(KeyT key, ValueT newValue);
        ValueT Get(KeyT key);
        bool ContainsKey(KeyT key);//是否包含某个键
        
        
    }
}
