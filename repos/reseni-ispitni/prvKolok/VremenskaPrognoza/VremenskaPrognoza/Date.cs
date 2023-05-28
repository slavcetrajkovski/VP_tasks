using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPrognoza
{
    public class Date
    {
        public string Day { get; set; }
        public  string Month { get; set; }
        public Weather weather { get; set; }

        public Date(string day, string month)
        {
            Day = day;
            Month = month;
        }

        public void createWeather(int max, int min)
        {
            weather = new Weather(max, min);

        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Day, Month);
        }
    }
}
