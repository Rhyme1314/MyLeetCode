using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class RBT2<KeyT, ValueT> where KeyT : IComparable<KeyT>
    {
        private const bool Red = true;
        private const bool Black = false;
        private class Node
        {
            public KeyT key;
            public ValueT value;
            public Node left;//左子节点
            public Node right;//右子节点
            public bool color;

            public Node(KeyT key, ValueT value)
            {
                this.key = key;
                this.value = value;
                this.left = null;
                this.right = null;
                this.color = Red;
            }
        }
        private Node root;//根节点
        private int N;//节点数
        public RBT2()
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
        public void Add(KeyT key, ValueT value)
        {
            root = Add(root, key, value);
            root.color = Black;
        }//递归添加方法
        private Node Add(Node node, KeyT key, ValueT value)
        {//这个node就是根节点
            if (node == null)
            {
                N++;
                return new Node(key, value);
            }
            if (node.key.CompareTo(key) > 0)
                node.left = Add(node.left, key, value);
            else if (node.key.CompareTo(key) < 0)
                node.right = Add(node.right, key, value);
            else if (node.key.CompareTo(key) == 0)
                node.value = value;//当作Set用

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
        //public ValueT GetValue(KeyT key)
        //{
        //    return GetValue(root, key);
        //}
        //private ValueT GetValue(Node node, KeyT key)
        //{
        //    if (node == null)
        //        return default(ValueT);
        //    if (node.key.CompareTo(key) == 0)
        //        return node.value;
        //    else if (node.key.CompareTo(key) > 0)
        //        return GetValue(node.left, key);
        //    else //(node.data.CompareTo(data) <0)
        //        return GetValue(node.right, key);
        //}
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
