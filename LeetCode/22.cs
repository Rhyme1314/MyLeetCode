using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // 数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
    //   输入：n = 3
    //   输出：["((()))","(()())","(())()","()(())","()()()"]
    class _22 //括号生成 中等难度
    {

        public IList<string> GenerateParenthesis(int n)
        {
            #region 回溯法 抄的 不是自己写的
            List<string> res = new List<string>();
            BackStacking(n, res, 0, 0, "");
            return res;
            #endregion
        }

        private void BackStacking(int n, List<string> res, int left, int right, string curStr)
        {
            if (right > left) return;
            if (left == right && left == n)
            {
                res.Add(curStr);
                return;
            }
            if (left < n)
                BackStacking(n, res, left + 1, right, curStr + "(");
            if (right < left)
                BackStacking(n, res, left, right + 1, curStr + ")");
        }
    }


}
