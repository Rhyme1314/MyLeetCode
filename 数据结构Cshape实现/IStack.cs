using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    interface IStack<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Push(T e);//往栈中添加元素
        T Pop();//删除栈顶元素并返回
        T Peek();//查找栈顶元素
    }
}
