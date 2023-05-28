using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobusi
{
    public class Bus
    {
        public string Name { get; set; }
        public string Registration { get; set; }
        public bool Local { get; set; }
        public List<Line> lines { get; set; } = new List<Line>();

        public Bus(string name, string registration, bool local)
        {
            Name = name;
            Registration = registration;
            Local = local;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Name, Registration, Local ? "L" : "M");
        }
    }
}
