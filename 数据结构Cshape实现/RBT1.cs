using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class RBT1<T> where T : IComparable<T> //红黑树 
    {
        private const bool Red = true;
        private const bool Black = false;
        private class Node
        {
            public T data;
            public Node left;//左子节点
            public Node right;//右子节点
            public bool color;

            public Node(T data)
            {
                this.data = data;
                this.left = null;
                this.right = null;
                this.color = Red;
            }
        }
        private Node root;//根节点
        private int N;//节点数
        public RBT1()
        {
            this.root = null;
            N = 0;
        }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }
        private bool IsRed(Node node)
        {
            if (node == null) return false;//空节点默认为黑节点
            else return node.color;

        }
        private Node LeftRotate(Node node)
        {
            Node x = node.right;
            x.color = node.color;
            node.color = Red;
            node.right = x.left;
            x.left = node;

            return x;
        }//左旋转 维护红黑树平衡 
        private void FlipColor(Node node)
        {
            node.color = Red;
            node.left.color = Black;
            node.right.color = Black;
        }//颜色翻转
        private Node RightRotate(Node node)
        {
            Node x = node.left;
            node.left = x.right;
            x.right = node;
            x.color = node.color;
            node.color = Red;

            return x;
        }//右旋转
        public void Add(T data)
        {
            root = Add(root, data);
            root.color = Black;
        }//递归添加方法
        private Node Add(Node node, T data)
        {//这个node就是根节点
            if (node == null)
            {
                N++;
                return new Node(data);
            }
            if (node.data.CompareTo(data) > 0)
                node.left = Add(node.left, data);
            if (node.data.CompareTo(data) < 0)
                node.right = Add(node.right, data);
            //对红黑树进行维护
            if (IsRed(node.right) && !IsRed(node.left))//左子节点为黑色 右子节点为红色
                node = LeftRotate(node);
            if (IsRed(node.right) && IsRed(node.left))//左子节点为红色 右子节点为红色
                FlipColor(node);
            if (IsRed(node.left) && IsRed(node.left.left))//左子节点为红色 左子节点的左子节点还是红色
                node = RightRotate(node);

            return node;
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
        public bool Contains(T data)
        {


            return Contains(root, data);


        }
        private bool Contains(Node node, T data)
        {
            if (node == null)
                return false;
            if (node.data.CompareTo(data) == 0)
                return true;
            else if (node.data.CompareTo(data) > 0)
                return Contains(node.left, data);
            else //(node.data.CompareTo(data) <0)
                return Contains(node.right, data);

            //}
        }
    }
}
