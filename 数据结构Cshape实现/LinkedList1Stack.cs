using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList1Stack<T>:IStack<T>
    {
        
        private LinkedList1<T> linkedList1 = new LinkedList1<T>();
        //增删改查 都在首元节点的时间复杂度为O(1) 故将首元节点作为栈顶

        public int Count { get { return linkedList1.Count; } }

        public bool IsEmpty { get { return IsEmpty; } }

        public T Peek()//查看栈顶元素
        {
            return linkedList1.GetFirst();
        }

        public T Pop()//删除栈顶元素
        {
            return linkedList1.RemoveFirst();
        }

        public void Push(T e)
        {
            linkedList1.AddFirst(e);
        }
        public override string ToString()
        {
            return "top[" + linkedList1.ToString() + "]Stack";
        }
    }
}
