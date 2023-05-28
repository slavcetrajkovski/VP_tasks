using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom
{
    public class Airport
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        public Airport(string city, string name, string code)
        {
            City = city;
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Code, Name, City);
        }
    }
}
