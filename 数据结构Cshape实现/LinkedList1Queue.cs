using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList1Queue<T> : IQueue<T>
    {
        private LinkedList1<T> linkedList1;
        public LinkedList1Queue()
        {
            linkedList1 = new LinkedList1<T>();
        }

        public int Count { get { return linkedList1.Count; } }

        public bool IsEmpty { get { return linkedList1.IsEmpty; } }

        public T Dequeue()//出队
        {
           return linkedList1.RemoveFirst();//O(1)
        }

        public void Enqueue(T e)
        {
            linkedList1.AddLast(e);//O(n)
        }

        public T Peek()
        {
           return  linkedList1.GetFirst();//O(1)
        }

        public override string ToString()
        {
            return "Queue: front  [" + linkedList1.ToString() + "]   tail";
        }
    }
}
