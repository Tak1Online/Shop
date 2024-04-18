using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Order
    {
        public int countWhite { get; set; }
        public int countBlack { get; set; }
        public int countOrder { get; set; }
        public string hleb { get; set; }
        public double sum { get; set; }
        public double cost { get; set; }

        public double Sum()
        {
            return sum = sum + cost;
        }
        public int WhiteHleb()
        {
            return countWhite = countWhite + countOrder;
        }

        public int BlackHleb()
        {
            return countBlack = countBlack + countOrder;

        }
    }
}
