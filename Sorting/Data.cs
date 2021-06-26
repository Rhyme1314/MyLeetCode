using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Data:IComparable<Data>
    {
        private int year, month, day;
        private string happen;
        public Data(int _year, int _month, int _day, string _happen)
        {
            year = _year;month = _month;day = _day;
            happen = _happen;
        }

        public int CompareTo(Data other)
        {
            if (this.year > other.year) return 1; if(this.year<other.year) return -1;
            if (this.month > other.month) return 1; if (this.month < other.month) return -1;
            if (this.day > other.day) return 1; if (this.day < other.day) return -1;
            return 0;
        }

        public override string ToString()
        {
            return year + "/" + month + "/" + day + ":" + happen;
        }
    }
}
