using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class SplittedDate
    {
        public int d, m, y;

        public SplittedDate(int d, int m, int y)
        {
            this.d = d;
            this.m = m;
            this.y = y;
        }
    }
}
