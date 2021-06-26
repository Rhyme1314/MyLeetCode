using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class TestHelper
    {
        public static List<string> ReadFile(string fileName)
        {
            //使用FileStream打开fileName路径下的文件(fs可以理解为一个通道 连接当前对象和路径下的文件)
            FileStream fs = new FileStream(fileName, FileMode.Open);

            StreamReader sr = new StreamReader(fs);//读取该FileStream 也就是读取该流的连接文件的信息

            List<string> words = new List<string>();//创建一个List来存放读取到的单词

            while (!sr.EndOfStream)
            {
                string contents = sr.ReadLine().Trim();

                int start = FirstCharacterIndex(contents, 0);

                for (int i = start+1; i <= contents.Length; i++)
                {

                    if (i == contents.Length || !Char.IsLetter(contents[i]))
                    {
                        string word = contents.Substring(start, i - start).ToLower();
                        words.Add(word);
                        start = FirstCharacterIndex(contents, i);
                        i = start + 1;
                    }
                    else
                        i++;
                }
            }
            fs.Close();
            sr.Close();
            return words;
        }
        private static int FirstCharacterIndex(string s,int start)
        {
            for (int i = start; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                    return i;
            }
            return s.Length;
        }
    }
}
