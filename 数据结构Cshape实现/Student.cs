using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Cshape实现
{
    class Student:IComparable<Student>
    {
        private string name;
        private int tall;

        public Student(string name, int tall)
        {
            this.name = name;
            this.tall = tall;
        }

        public int CompareTo(Student other)
        {
            if (this.tall > other.tall) return 1;
            if (this.tall < other.tall) return -1;
            return 0;

        }

        public override string ToString()
        {
            return "{" + name + ":" + tall + "}";
        }
    }
}
