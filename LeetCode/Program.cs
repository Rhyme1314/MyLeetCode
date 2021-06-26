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
            _773 test = new _773();
            int[][] board = { new int[] { 1, 2, 3 }, new int[] { 4, 0, 5 } };
            test.SlidingPuzzle(board);
            Console.WriteLine();
            
        }
    }
}
