using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList2Queue<T> : IQueue<T>
    {
        private LinkedList2<T> linkedList2;//带尾指针的链表
        public LinkedList2Queue()
        {
            linkedList2 = new LinkedList2<T>();
        }

        public int Count { get { return linkedList2.Count; } }

        public bool IsEmpty { get { return linkedList2.IsEmpty; } }

        public T Dequeue()
        {
            return linkedList2.RemoveFirst();
        }

        public void Enqueue(T e)
        {
            linkedList2.AddLast(e);
        }

        public T Peek()
        {
            return linkedList2.GetFirst();
        }
        public override string ToString()
        {
            return "Queue: front  [" + linkedList2.ToString() + "] tail";
        }
    }
}
