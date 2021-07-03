using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class BST1<T> where T:IComparable<T> //二叉查找树 用链表实现 
        //二叉查找树里不能有相同的元素 且元素之间必须能比大小
    {
        private class Node
        {
           public  T data;
            public Node left;//左子节点
            public Node right;//右子节点

            public Node(T data)
            {
                this.data = data;
                this.left = null;
                this.right = null;
            }
        }
        private Node root;//根节点
        private int N;//节点数

        public BST1()
        {
            this.root = null;
            N = 0;
        }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        public void add(T data)//非递归添加方式
        {
            if (root == null)
            {
                root = new Node(data);
                N++;
                return;
            }
            Node cur = root;
            Node pre = null;//cur的父节点

            while (cur!=null)
            {
                if (cur.data.CompareTo(data) == 0)
                    return;
                if (cur.data.CompareTo(data) > 0)//cur当前的值大于data
                {
                    pre = cur;
                    cur = cur.left;
                }
                if (cur.data.CompareTo(data) < 0)//cur当前的值小于data
                {
                    pre = cur;
                    cur = cur.right;
                }
            }
            if (cur==null)
            {
                if (pre.data.CompareTo(data)>0)
                    pre.left = new Node(data);
                else
                    pre.right = new Node(data);
            }
            N++;
        }
        public void Add(T data)
        {
           root =  Add(root, data);
        }//递归添加方法
        private Node Add(Node node, T data)
        {
            if (node == null)//递归终止条件
            {
                N++;
               return  new Node(data);
            }
            if (node.data.CompareTo(data)>0)
               node.left =  Add(node.left, data);
            if (node.data.CompareTo(data) < 0)
               node.right =   Add(node.right, data);
          
            return node;
        }
        public bool Contains(T data)
        {
           

            return Contains(root, data);
            
            
        }
        private bool Contains(Node node, T data)
        {
            if (node==null)
                return false;
            if (node.data.CompareTo(data)==0)
                return true;
           else if (node.data.CompareTo(data) > 0)
               return  Contains(node.left, data);
            else //(node.data.CompareTo(data) <0)
              return   Contains(node.right, data);
           
            //}
        }
        //前序遍历
        public void PreOrder()
        {
            PreOrder(root);
        }
        private void PreOrder(Node node)
        
        {
            if (node==null)
                return;
            Console.WriteLine(node.data);


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
            if (node==null)
                return;
            InOrder(node.left);
            Console.WriteLine(node.data);
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
            Console.WriteLine(node.data); 
        }
        //层序遍历 需要用的队列
        public void LevelOrder()
        {
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);//将根节点入队

            while (nodes.Count!=0)
            {
                Node node = nodes.Dequeue();
                Console.WriteLine(node.data);
                if (node.left != null) nodes.Enqueue(node.left);
                if (node.right != null) nodes.Enqueue(node.right);

            }
          




        }
        //找出二叉树最小值
        public T Min()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
           return  Min(root).data;
        }
        private Node Min(Node node)
        {
            if (node.left ==null)//说明当前node就是最小节点
                return node;
          return   Min(node.left);
        }
        //找出二叉树最大值
        public T Max()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            return  Max(root).data;
        }
        private Node Max(Node node)
        {
            if (node.right==null)
                return node;
            return Max(node.right);
        }
        //删除二叉树最小值
        public T RemoveMin()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            T del = Min();//找到最小值
           root =  RemoveMin(root);
            return del;
        }
        private Node RemoveMin(Node node)
        {
            if (node.left == null)
            {
                N--;
                return node.right;
            }
          node.left =   RemoveMin(node.left);
            return node;
        }
        public T RemoveMax()
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            T del = Max();
            root = RemoveMax(root);
            return del;
        }
        private Node RemoveMax(Node node)
        {
            if (node.right==null)
            {
                N--;
                return node.left;
            }
            node.right = RemoveMax(node.right);
            return node;
        }
        public void Remove(T data)//删除data的节点
        {
            if (IsEmpty)
                throw new ArgumentException("此二叉树为空树");
            root = Remove(root, data);

        }
        private Node Remove(Node node, T data)
        {
            if (node==null)
                return null;
            if (node.data.CompareTo(data) > 0)  
            {
                node.left = Remove(node.left, data);
                return node;
            }
            else if (node.data.CompareTo(data) < 0)
            {
                node.right = Remove(node.right, data);
                return node;
            }
            else //node.data.CompareTo(data) = 0
            {
                //实行删除操作
                if (node.left == null)
                { N--; return node.right; }
                    
                if(node.right == null)
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
            if (node==null)
                return 0;
            int l = MaxHeight(node.left);
            int r = MaxHeight(node.right);
            return Math.Max(l, r) + 1;
        }
       
    }
}
