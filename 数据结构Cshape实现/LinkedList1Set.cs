using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList1Set<T> : ISet<T>
    {
        LinkedList1<T> linkedList1;
        public LinkedList1Set()
        {
            linkedList1 = new LinkedList1<T>();
        }

        public int Count { get { return linkedList1.Count; } }

        public bool IsEmpty { get { return linkedList1.IsEmpty; } }

        public void Add(T e)
        {//在链表头部添加
            //判断是已经包含了E
            if (!linkedList1.Contains(e))
                linkedList1.AddFirst(e);
        }

        public bool Contains(T e)
        {
            return linkedList1.Contains(e);
        }

        public void Remove(T e)
        {
            linkedList1.Remove(e);
        }
        
    }
}
