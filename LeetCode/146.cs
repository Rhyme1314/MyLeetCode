using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class DLinkNode
    {
        public int key;
        public  int val;
       public DLinkNode pre;
        public DLinkNode next;
        public DLinkNode(int val,int key)
        {
            this.val = val;
            this.key = key;
        }
        public DLinkNode() 
        { }
    }
    class LRUCache//LRU 缓存机制
    {
        int capacity = 0;
        int count;//当前链表的结点数
        DLinkNode dummyhead = new DLinkNode();
        DLinkNode dummytail = new DLinkNode();
        Dictionary<int, DLinkNode> dic = new Dictionary<int, DLinkNode>();
        public LRUCache(int capacity)
        {
            count = 0;
            this.capacity = capacity;
            dummyhead.next = dummytail;
            dummytail.pre = dummyhead;
        }

        public int Get(int key)
        {
            DLinkNode node;
            if (!dic.TryGetValue(key, out node))
                return -1;
            else
            {
                movetoHead(node);
                return node.val;
            }
                
        }

        public void Put(int key, int value)
        {
            DLinkNode node;
            if (!dic.TryGetValue(key,out node))
            {
                DLinkNode newNode = new DLinkNode(key, value);
                dic[key] = newNode;
                AddtoHead(newNode);
                count++;
                if (count > capacity)
                {
                    //超过了 
                    DLinkNode tail = removeTail();
                    dic.Remove(tail.key);
                    count--;
                }
            }
            else
            {
                node.val = value;
                movetoHead(node);
            }
           
        }

        private DLinkNode removeTail()
        {
            DLinkNode tail = dummytail.pre;
            dummytail.pre = dummytail.pre.pre;
            dummytail.pre.next = dummytail;
            return tail;
        }


        private void AddtoHead(DLinkNode node)
        {
            node.pre = dummyhead;
            node.next = dummyhead.next;
            node.next.pre = node;
            dummyhead.next = node;
        }
        private void movetoHead(DLinkNode node)
        {
            node.pre.next = node.next;
            node.next.pre = node.pre;
            node.pre = dummyhead;
            node.next = dummyhead.next;
            node.next.pre = node;
            dummyhead.next = node;
        }
    }
}
