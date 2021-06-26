using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _118//杨辉三角
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res =new  List<IList<int>>();
            IList<int> preList =new  List<int>();
            for (int j = 1; j <= numRows; j++)
            {
                IList<int> curList = new List<int>(j);
                for (int i = 0; i < j; i++)
                {
                    if (i - 1 >= 0 && i < j - 1)
                    {
                        curList.Add(preList[i - 1] + preList[i]);
                    }
                    else curList.Add(1);
                }
                preList = curList;
                res.Add(curList);
            }
            return res;
        }
    }
}
