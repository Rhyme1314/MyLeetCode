using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class Bst1Set<T>:ISet<T> where T:IComparable<T>
    {
        private BST1<T> bst; 
        public Bst1Set()
        {
           bst  = new BST1<T>();//使用二叉树实现集合
        }

        public int Count { get { return bst.Count; } }

        public bool IsEmpty { get { return bst.IsEmpty; } }

        public void Add(T e)
        {
            bst.Add(e);
        }

        public bool Contains(T e)
        {
            return bst.Contains(e);
        }

        public void Remove(T e)
        {
            bst.Remove(e);
        }
        public int MaxHeight()
        {
            return bst.MaxHeight();
        }
    }
}
