using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregled
{
    public class Measurement
    {
        public MesurementType Type { get; set; }
        public int Value { get; set; }

        public Measurement(MesurementType type, int value)
        {
            Type = type;
            Value = value;
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", Type, Value);
        }
    }
}
