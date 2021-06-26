using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class Array1Stack<T> : IStack<T>
    {
        private Array01<T> arr;  //创建一个动态数组  作为数组栈的基本底层
        //由于该动态数组采用的是顺序存储，对尾部进行增删的时间复杂度为O(1)

        
        public Array1Stack(int capacity)
        {
            arr = new Array01<T>(capacity);
        }
        public Array1Stack()
        {
            arr = new Array01<T>();//默认为10
        }
        public int Count { get { return arr.Count; } }
        public bool IsEmpty { get { return arr.IsEmpty; } }
        public T Peek()
        {
            return arr.GetLast();
            
        }

        public T Pop()
        {
            return arr.RemoveLast();
        }

        public void Push(T e)
        {
            arr.AddLast(e);
        }
        public override string ToString()
        {
            return "Stack" + arr.ToString() + "top";//arr输出是正序输出 所以arr的最后一个元素是栈顶
        }
    }
}
