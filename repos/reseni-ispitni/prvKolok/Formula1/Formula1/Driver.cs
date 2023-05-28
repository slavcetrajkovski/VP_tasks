using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isFirst { get; set; }
        public List<Lap> Laps { get; set; }

        public Driver(string name, int age, bool isFirst)
        {
            Name = name;
            Age = age;
            this.isFirst = isFirst;
            Laps = new List<Lap>();
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}) - {2}", Name, Age, isFirst ? "F" : "S");
        }
    }
}
