using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    interface IQueue<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Enqueue(T e);//入队
        T Dequeue();//出队
        T Peek();//查看队首的元素
        
    }
}
