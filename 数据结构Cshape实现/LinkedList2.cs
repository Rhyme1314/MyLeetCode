using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList2<T>
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
        private Node head;
        private Node tail;
        public LinkedList2()
        {
            this.N = 0;
            this.head = null;//初始化 头指针指向空
            this.tail = null;//尾指针指向空
        }
        public int Count
        {
            get { return N; }
        }
        public bool IsEmpty
        {
            get { return N == 0; }
        }
        public void AddLast(T e)
        {
            Node node = new Node(e);
            if (IsEmpty)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;//更新尾节点
            }
            N++;
        }
        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");
            T del = head.e;
            head = head.next;
            N--;
            if (head == null)//删到最后一个节点的时候 尾节点也要清空 要不然删不掉
                tail = null;
            return del;
        }
        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");
            return head.e;
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
    }
}
