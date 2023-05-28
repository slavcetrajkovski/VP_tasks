using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispiti
{
    public class Exam
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public Problem Problem1 { get; set; }
        public Problem Problem2 { get; set; }

        public Exam(string month, int year)
        {
            Year = year;
            Month = month;
            Problem1 = new Problem();
            Problem2 = new Problem();   
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Month, Year);
        }
    }
}
