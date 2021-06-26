using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _406 //根据身高重建队列
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            Sort(people);
            int[][] res = new int[people.Length][];
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i+1; j>people[i][1]; j--)
                {
                    if (j>0)
                        res[j] = res[j - 1];
                }
                res[people[i][1]] = people[i];
            }
            return res;
        }
        private void Sort(int[][] people) {
            bool isBub = true;//冒泡
            while (isBub)
            {
                isBub = false;
                for (int i = 0; i < people.Length-1; i++)
                {
                    if (people[i][0]<people[i+1][0])
                    {
                        int[] temp = people[i];
                        people[i] = people[i + 1];
                        people[i + 1] = people[i];
                        isBub = true;
                    }
                    else if (people[i][0] == people[i + 1][0]&&people[i][1]>people[i+1][1])
                    {
                        int[] temp = people[i];
                        people[i] = people[i + 1];
                        people[i + 1] = people[i];
                        isBub = true;
                    }
                }
            }
        }
    }
}
