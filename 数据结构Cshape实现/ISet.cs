using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    interface ISet<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Add(T e);
        void Remove(T e);
        bool Contains(T e);
    }
}
