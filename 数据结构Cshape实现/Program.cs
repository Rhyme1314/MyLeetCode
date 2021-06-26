using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据结构Cshape实现;

namespace Course
{
    class Program
    {
        public static long TestStack(IStack<int> stack, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                stack.Push(i);//入栈   O(n)
            for (int i = 0; i < N; i++)
                stack.Pop();//出栈      O(n)
            t.Stop();
            return t.ElapsedMilliseconds;

        }
        public static long TestQueue(IQueue<int> queue, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                queue.Enqueue(i);//进队   O(n)
            for (int i = 0; i < N; i++)
                queue.Dequeue();//出队      O(n)
            t.Stop();
            return t.ElapsedMilliseconds;

        }
        public static long TestSet(数据结构Cshape实现.ISet<string> set, List<string> words)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (var word in words)
            {
                set.Add(word);
            }
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        public static long TestDic(数据结构Cshape实现.IDictionary<string, int> dic, List<string> words)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (var word in words)
            {
                if (!dic.ContainsKey(word))
                    dic.Add(word, 1);
                else
                    dic.Set(word, dic.Get(word) + 1);
            }
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        public static int Func(int n)//递归函数
        {
            if (n == 1) return 1;//套娃
            else return n * Func(n - 1);//在函数内调用自己的函数 就叫递归

        }
        static void Main(string[] args)
        {

            Console.WriteLine("哈利波特");
            List<string> words = TestHelper.ReadFile("测试文件/哈利波特.txt");
            Console.WriteLine("总词数为：" + words.Count);

            RBT2Dic<string, int> rbt2Dic = new RBT2Dic<string, int>();//红黑树字典
            HashST2Dic<string, int> hashST2Dic = new HashST2Dic<string, int>();//哈希表字典
            HashST2Dic<string, int> hashST2Dic2 = new HashST2Dic<string, int>(997);//哈希表字典 M为997
            long t1 = TestDic(rbt2Dic, words);
            long t2 = TestDic(hashST2Dic, words);
            long t3 = TestDic(hashST2Dic2, words);
            Console.WriteLine("红黑树字典所包含的总词汇量为{0}，其中love的次数为{1},用时{2}", rbt2Dic.Count, rbt2Dic.Get("love"),t1);//327
            Console.WriteLine("哈希表字典所包含的总词汇量为{0}，其中love的次数为{1},用时{2}", hashST2Dic.Count, hashST2Dic.Get("love"), t2);//119
            Console.WriteLine("哈希表字典（997）所包含的总词汇量为{0}，其中love的次数为{1},用时{2}", hashST2Dic2.Count, hashST2Dic2.Get("love"), t3);//18
            //事实证明 哈希表在查找方面 是十分快的
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                    dictionary.Add(word, 1);
                else
                    dictionary[word]++;
            }
            t.Stop();
            Console.WriteLine("C#自带哈希表字典所包含的总词汇量为{0}，其中love的次数为{1},用时{2}", dictionary.Count, dictionary["love"], t.ElapsedMilliseconds);//5
            //C#牛逼
            Console.ReadKey();



            // RBT1Set<string> rbt1Set = new RBT1Set<string>();
            // HashST1Set<string> hash1Set = new HashST1Set<string>();//默认为97 每个链表长度平均为180个node
            //                                                        //如果我们提高传入的质数M 比如997 那么每个链表长度平均就为18个 遍历起来就很方便
            // HashST1Set<string> hash1Set2 = new HashST1Set<string>(997);
            // long t1 = TestSet(rbt1Set, words);
            // long t2 = TestSet(hash1Set, words);
            // long t3 = TestSet(hash1Set2, words);
            // Console.WriteLine("红黑树集合所包含的总词汇量为{0}，去重操作用时{1}", rbt1Set.Count, t1);//18312 223
            // Console.WriteLine("哈希表集合所包含的总词汇量为{0}，去重操作用时{1}", hash1Set.Count, t2);//55
            // Console.WriteLine("哈希表集合（997）所包含的总词汇量为{0}，去重操作用时{1}", hash1Set2.Count, t3);//8
            // //很明显 哈希表的访问是十分十分快的 因为他的时间复杂度只是和链表的长度成正比， 而链表的长度很容易收缩
            // //下面我们看看C#为我们提供的哈希表
            //HashSet<string> hashSet =  new HashSet<string> ();//C#为我们提供的哈希表集合 是不能传入M的 因为怕我们乱传
            // Stopwatch t = new Stopwatch();
            // t.Start();
            // foreach (var word in words)
            // {
            //     hashSet.Add(word);
            // }
            // t.Stop();
            // Console.WriteLine("C#哈希表集合所包含的总词汇量为{0}，去重操作用时{1}", hashSet.Count, t.ElapsedMilliseconds);//4ms
            // //C#牛逼




        }
    }
}
