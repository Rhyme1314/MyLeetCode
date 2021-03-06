using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//用栈实现队列
    public class MyQueue
    {
        Stack<int> stack1;
        Stack<int> stack2;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack2.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (stack1.Count==0)
            {
                int size = stack2.Count;
                while (size-->0)
                {
                    stack1.Push(stack2.Pop());
                }
            }
            return stack1.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (stack1.Count == 0)
            {
                int size = stack2.Count;
                while (size-- > 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }
            return stack1.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }
    }

}
