using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class LinkedList3<KeyT, ValueT> : IDictionary<KeyT, ValueT>
    {
        private class Node
        {
            public KeyT key;
            public ValueT value;
            public Node next;//该节点指向下一节点的指针 
                             //Next并不是下一节点本身 可以理解成下一节点的变量名
            public Node(KeyT key, ValueT value, Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }
            public Node(KeyT key, ValueT value) : this(key, value, null) { }

            public override string ToString()
            {
                return key.ToString() + " : " + value.ToString();
            }
        }
        private Node head;//首元节点的引用
        private int N;//键值对的个数
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }



        public LinkedList3()
        {
            this.N = 0;
            this.head = null;
        }
        private Node GetNode(KeyT key)//返回列表中键为key的节点
        { //根据键查找节点
            Node cur = head;
            while (cur != null)
            {
                if (cur.key.Equals(key))
                    return cur;
                cur = cur.next;
            }
            return null;
        }

        public void Add(KeyT key, ValueT value)
        {
            Node node = GetNode(key);
            if (node != null)
                node.value = value;
            else
            {
                node = new Node(key, value, head);
                head = node;
                N++;
            }
        }//添加方法 若该键存在 设置值，不存在 在头部添加节点

        public void Remove(KeyT key)
        {
            if (head == null)
                return;
            if (head == GetNode(key))
            {
                head = head.next;
                N--;
                return;
            }
            Node pre = null;
            Node cur = head;
            while (cur != null)
            {
                if (cur.key.Equals(key))//找到了要删除的节点
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

        public void Set(KeyT key, ValueT newValue)
        {
            Node node = GetNode(key);
            if (node == null)
                throw new ArgumentException("该键不存在");
            else
                node.value = newValue;
        }

        public ValueT Get(KeyT key)
        {
            Node node = GetNode(key);
            if (node == null)
                throw new ArgumentException("该键不存在");
            else
                return node.value;
        }

        public bool ContainsKey(KeyT key)
        {
            if (GetNode(key) == null)
                return false;
            return true;
        }

        public override string ToString()
        {

            StringBuilder res = new StringBuilder();
            // res.Append(string.Format("LinkedList:          Count:{0}\n", N));
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur.key + " : " + cur.value + "->");
                cur = cur.next;
            }
            res.Append("null");
            return res.ToString();
        }

    }
}
