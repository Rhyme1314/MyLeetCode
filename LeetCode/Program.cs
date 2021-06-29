using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            _40 test = new _40();
            //test.OpenLock(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202");
            int[] arr = { 10, 1, 2, 7, 6, 1, 5 };
            test.CombinationSum2(arr, 8);
            Console.WriteLine();
            
        }
    }
}
