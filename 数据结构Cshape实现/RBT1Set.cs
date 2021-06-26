using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class RBT1Set<T>:ISet<T> where T : IComparable<T>
    {
        private RBT1<T> rbt;
        public RBT1Set()
        {
            rbt = new RBT1<T>();
        }

        public int Count { get { return rbt.Count; } }

        public bool IsEmpty { get { return rbt.IsEmpty; } }

        public void Add(T e)
        {
            rbt.Add(e);
        }

        public bool Contains(T e)
        {
            return rbt.Contains(e);
        }

        public void Remove(T e)
        {
            Console.WriteLine("还未实现");
        }
        public int MaxHeight()
        {
            return rbt.MaxHeight();
        }
    }
}
