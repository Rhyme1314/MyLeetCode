using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList1<T>
    {
        private class Node
        {
            public T e;//该节点存储的数据
            public Node next;//该节点指向下一节点的指针 
                             //Next并不是下一节点本身 可以理解成下一节点的变量名
            public Node(T e, Node next)
            {
                this.e = e;
                this.next = next;
            }
            public Node(T e) : this(e, null) { }

            public override string ToString()
            {
                return e.ToString();
            }
        }
        private int N;//该链表有多少个数据元素 
        private Node head;//= new Node(default(T), null);
        public LinkedList1()
        {
            this.N = 0;
            this.head = null;
        }
        public int Count
        {
            get { return N; }
        }
        public bool IsEmpty
        {
            get { return N == 0; }
        }
        public void Add(int index, T e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("非法索引");

            if (index == 0)
                head = new Node(e, head);
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }
                pre.next = new Node(e, pre.next);
            }
            N++;
        }
        public void AddFirst(T e)
        {
            Add(0, e);
        }
        public void AddLast(T e)
        {
            Add(N, e);
        }
        public T Get(int index)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("非法索引");
            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;
            return cur.e;

        }
        public T GetFirst()
        {
            return Get(0);
        }
        public T GetLast()
        {
            return Get(N - 1);
        }
        public void Set(int index, T Newe)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("非法索引");
            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;
            cur.e = Newe;
        }
        public bool Contains(T e)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.e.Equals(e))
                    return true;

                cur = cur.next;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            // res.Append(string.Format("LinkedList:          Count:{0}\n", N));
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur.e + "->");
                cur = cur.next;
            }
            res.Append("null");
            return res.ToString();
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("非法索引");
            Node pre = head;
            Node delNode;
            if (index == 0)
            {
                delNode = head;
                head = head.next;//首元节点下移
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    pre = pre.next;
                delNode = pre.next;
                pre.next = pre.next.next;
            }
            N--;
            return delNode.e;

        }
        public T RemoveFirst()
        {
            return RemoveAt(0);
        }
        public T RemoveLast()
        {
            return RemoveAt(N - 1);
        }
        public void Remove(T e)
        {
            if (head == null)
                return;
            if (head.e.Equals(e))
            {
                head = head.next;
                N--;
                return;
            }
            Node pre = null;
            Node cur = head;
            while (cur != null)
            {
                if (cur.e.Equals(e))//找到了要删除的节点
                    break;
                pre = cur;
                cur = cur.next;
            }
            if (cur != null)
            {
                pre.next = pre.next.next;
                N--;
            }
        }
    }
}
