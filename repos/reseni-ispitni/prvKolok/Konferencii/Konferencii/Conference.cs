using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konferencii
{
    public class Conference
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Conference(string name, int year)
        {
            Id = Guid.NewGuid().ToString(); 
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", Year, Name);
        }
    }
}
