using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobusi
{
    public class Line
    {
        public string Destination { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Price { get; set; }

        public Line(string destination, int hours, int minutes, int price)
        {
            Destination = destination;
            Hours = hours;
            Minutes = minutes;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1:00} - {2} - {3} Ден.", Hours, Minutes, Destination, Price);
        }
    }
}
