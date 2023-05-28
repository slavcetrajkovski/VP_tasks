using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognoza
{
    public class Weather
    {
        public int Max { get; set; }
        public int Min { get; set; }

        public Weather(int max, int min)
        {
            Max = max;
            Min = min;
        }

    }
}
