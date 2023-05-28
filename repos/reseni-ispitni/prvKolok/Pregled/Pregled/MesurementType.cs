using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregled
{
    public class MesurementType
    {
        public string Name { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public MesurementType(string name, int min, int max)
        {
            Name = name;
            Min = min;
            Max = max;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} - {2}", Name, Min, Max);
        }
    }
}
