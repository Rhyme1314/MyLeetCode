using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{


    class ThroneInheritance// 皇位继承顺序
    {
        Dictionary<string, IList<string>> dic;
        HashSet<string> dead;
        string king;
        // List<string> child = new List<string>();
        public ThroneInheritance(string kingName)
        {
            dic = new Dictionary<string, IList<string>>();
            dead = new HashSet<string>();
            king = kingName;
            //dic[king] = new 
        }

        public void Birth(string parentName, string childName)
        {
            IList<string> child;
            if (dic.TryGetValue(parentName, out child))//说明这个parent是有其他儿子的
            {
                child.Add(childName);
            }
            else
            {
                child = new List<string>();
                child.Add(childName);
                dic[parentName] = child;
            }
        }

        public void Death(string name)
        {
            dead.Add(name);
        }

        public IList<string> GetInheritanceOrder()
        {
            IList<string> res = new List<string>();
            PreOrder(res, king);
            return res;
        }
        private void PreOrder(IList<string> res, string name)
        {
            if (!dead.Contains(name))
                res.Add(name);
            if (!dic.ContainsKey(name))//说明他没孩子了
                return;
            foreach (string childName in dic[name])//这个也是按顺序的
                PreOrder(res, childName);
        }
    }
}
