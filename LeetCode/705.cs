using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//不使用任何内建的哈希表库设计一个哈希集合（HashSet）。
//实现 MyHashSet 类：
//void add(key) 向哈希集合中插入值 key 。
//bool contains(key) 返回哈希集合中是否存在这个值 key 。
//void remove(key) 将给定值 key 从哈希集合中删除。如果哈希集合中没有这个值，什么也不做。
//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/design-hashset
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _705
    {
        
        LinkedList<int>[] lists;//将C#为我们提供的链表数组作为hash底层
        public _705()
        {
            lists = new LinkedList<int>[997];
            for (int i = 0; i < lists.Length; i++)
            {
                lists[i] = new LinkedList<int>();
            }
        }

        private int Hash(int key)//返回一个0到996的数 作为链表索引
        {
            return (key.GetHashCode() & 0x7fffffff) % 997;
        }


        public void Add(int key)
        {
            LinkedList<int> list = lists[Hash(key)];
               if (!list.Contains(key))
                list.AddFirst(key);
        }

        public void Remove(int key)
        {
            LinkedList<int> list = lists[Hash(key)];
            if (list.Contains(key))
                list.Remove(key);
        }
        public bool Contains(int key)
        {
            LinkedList<int> list = lists[Hash(key)];
            return list.Contains(key);
        }
    }
}
