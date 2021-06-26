using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class BST2<KeyT,ValueT> where KeyT:IComparable<KeyT> 
    {
        private class Node
        {
            public KeyT key;
            public ValueT value;
            public Node left;//左子节点
            public Node right;//右子节点

            public Node(KeyT key,ValueT value)
            {
                this.key = key;
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }
        private Node root;//根节点
        private int N;//节点数

        public BST2()
        {
            this.root = null;
            N = 0;
        }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        public void add(KeyT key,ValueT value)//非递归添加方式
        {
            if (root == null)
            {
                root = new Node(key,value);
                N++;
                return;
            }
            Node cur = root;
            Node pre = null;//cur的父节点

            while (cur != null)
            {
                if (cur.key.CompareTo(key) == 0)
                    return;
                if (cur.key.CompareTo(key) > 0)//cur当前的值大于传进来的key
                {
                    pre = cur;
                    cur = cur.left;
                }
                if (cur.key.CompareTo(key) > 0)//cur当前的值小于传进来的key
                {
                    pre = cur;
                    cur = cur.right;
                }
            }
            if (cur == null)
            {
                if (pre.key.CompareTo(key) > 0)
                    pre.left = new Node(key,value);
                else
                    pre.right = new Node(key, value);
            }
            N++;
        }
        public void Add(KeyT key,ValueT value)
        {
            root = Add(root, key,value);
        }//递归添加方法
        private Node Add(Node node, KeyT key, ValueT value)
        {//这个node就是根节点
            if (node == null)
            {
                N++;
                return new Node(key,value);
            }
            if (node.key.CompareTo(key) > 0)
                node.left = Add(node.left, key, value);
            else if (node.key.CompareTo(key) < 0)
                node.right = Add(node.right, key, value);
            else if (node.key.CompareTo(key) == 0)
                node.value = value;

            return node;
        }
        public bool Contains(KeyT key)
        {


            return Contains(root, key);


        }
        private bool Contains(Node node, KeyT key)
        {
            if (node == null)
                return false;
            if (node.key.CompareTo(key) == 0)
                return true;
            else if (node.key.CompareTo(key) > 0)
                return Contains(node.left, key);
            else //(node.data.CompareTo(data) <0)
                return Contains(node.right, key);

            //}
        }
        //前序遍历
        public void PreOrder()
        {
            PreOrder(root);
        }
        private void PreOrder(Node node)

        {
            if (node == null)
                return;
            Console.WriteLine(node.key+":"+node.value);


            PreOrder(node.left);
            PreOrder(node.right);

        }
        //中序遍历 从左往右
        public void InOrder()
        {
            InOrder(root);
        }
        private void InOrder(Node node)
        {
            if (node == null)
                return;
            InOrder(node.left);
            Console.WriteLine(node.key + ":" + node.value);
            InOrder(node.right);
        }
        //后序遍历
        public void PostOrder()
        {
            PostOrder(root);
        }
        private void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine(node.key + ":" + node.value);
        }
        //层序遍历 需要用的队列
        public void LevelOrder()
        {
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);//将根节点入队

            while (nodes.Count != 0)
            {
                Node node = nodes.Dequeue();
                Console.WriteLine(node.key + ":" + node.value);
                if (node.left != null) nodes.Enqueue(node.left);
                if (node.right != null) nodes.Enqueue(node.right);

            }





        }
        //找出二叉树key最小的value
        public KeyT Min()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            return Min(root).key;
        }
        private Node Min(Node node)
        {
            if (node.left == null)//说明当前node就是最小节点
                return node;
            return Min(node.left);
        }
        //找出二叉树最大值
        public KeyT Max()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            return Max(root).key;
        }
        private Node Max(Node node)
        {
            if (node.right == null)
                return node;
            return Max(node.right);
        }
        //删除二叉树最小值
        public KeyT RemoveMin()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            KeyT del = Min();//找到最小值
            root = RemoveMin(root);
            return del;
        }
        private Node RemoveMin(Node node)
        {
            if (node.left == null)
            {
                N--;
                return node.right;
            }
            node.left = RemoveMin(node.left);
            return node;
        }
        public KeyT RemoveMax()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            KeyT del = Max();
            root = RemoveMax(root);
            return del;
        }
        private Node RemoveMax(Node node)
        {
            if (node.right == null)
            {
                N--;
                return node.left;
            }
            node.right = RemoveMax(node.right);
            return node;
        }
        public void Remove(KeyT key)//删除键为key的节点
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            root = Remove(root, key);

        }
        private Node Remove(Node node, KeyT key)
        {
            if (node == null)
                return null;
            if (node.key.CompareTo(key) > 0)
            {
                node.left = Remove(node.left, key);
                return node;
            }
            else if (node.key.CompareTo(key) < 0)
            {
                node.right = Remove(node.right, key);
                return node;
            }
            else //node.data.CompareTo(data) = 0
            {
                //实行删除操作
                if (node.left == null)
                { N--; return node.right; }

                if (node.right == null)
                { N--; return node.left; }

                Node s = Min(node.right);//用s替代当前node
                s.right = RemoveMin(node.right);
                s.left = node.left;
                N--;
                return s;
            }
        }
        public int MaxHeight()//计算二叉树的高度
        {
            return MaxHeight(root);
        }
        private int MaxHeight(Node node)
        {
            if (node == null)
                return 0;
            int l = MaxHeight(node.left);
            int r = MaxHeight(node.right);
            return Math.Max(l, r) + 1;
        }
        private Node GetNode(Node node, KeyT key)
        {
            if (node == null)
                return null;
            if (node.key.Equals(key))
                return node;
            else if (node.key.CompareTo(key) > 0)
                return GetNode(node.left, key);
            else 
                return GetNode(node.right, key);
        }
        public ValueT GetValue(KeyT key)
        {
            Node node = GetNode(root, key);
            if (node == null)
                throw new ArgumentException("键" + key + "不存在，无法获取对应值");
            else
                return node.value;
        }
        public void Set(KeyT key, ValueT value)
        {
            Node node = GetNode(root, key);
            if (node == null)
                throw new ArgumentException("键" + key + "不存在，无法获取对应值");
            else
                 node.value = value;
        }
    }
}
