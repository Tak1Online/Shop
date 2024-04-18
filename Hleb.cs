using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Hleb
    {
        public double height;
        public double cost;
        public double count = 0;
        public double summ;
        public double Costs()
        {
            return summ = (height/1000)*cost*count;
        }
    }
}
