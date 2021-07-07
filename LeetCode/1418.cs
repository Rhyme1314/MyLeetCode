using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1418//点菜展示表
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            IList<IList<string>> res = new List<IList<string>>();
            HashSet<string> name = new HashSet<string>();
            Dictionary<int, Dictionary<string, int>> dic = new Dictionary<int, Dictionary<string, int>>();//每张桌子
            for (int i = 0; i < orders.Count; i++)
            {
                int tableID = int.Parse(orders[i][1]);
                if (dic.ContainsKey(tableID))
                {
                    if (dic[tableID].ContainsKey(orders[i][2]))
                        dic[tableID][orders[i][2]]++;
                    else
                        dic[tableID][orders[i][2]] =1;
                }
                else
                {
                    dic[tableID] = new Dictionary<string, int>();
                    dic[tableID][orders[i][2]] = 0;
                }
                name.Add(orders[i][2]);
            }
            List<string> nameList = new List<string>();
            foreach (var item in name)
            {
                nameList.Add(item);
            }
            nameList.Sort((a, b) => string.CompareOrdinal(a, b));
            nameList.Insert(0, "Table");

            res.Add(nameList);

            List<int> tableIDList = new List<int>();
            foreach (var item in dic)
            {
                tableIDList.Add(item.Key);
            }
            tableIDList.Sort();
            int n = res[0].Count;
            foreach (var item in tableIDList)
            {
                List<string> curList = new List<string>();
                for (int i = 1; i < n; i++)
                {
                    if (!dic[item].ContainsKey(res[0][i]))
                    {
                        dic[item][res[0][i]] = 0;
                    }
                    curList.Add(dic[item][res[0][i]].ToString());
                }
                curList.Insert(0, item.ToString());
                res.Add(new List<string>(curList));
            }
            return res;
        }
    }
}
