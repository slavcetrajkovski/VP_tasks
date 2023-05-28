using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvProgram
{
    public class TV
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<TVProgram> tvProgram;

        public TV(string name, int number)
        {
            Name = name;
            Number = number;
            tvProgram = new List<TVProgram>();
        }

        public override string ToString()
        {
            return string.Format("{0}. {1}", Number, Name);
        }
    }
}
