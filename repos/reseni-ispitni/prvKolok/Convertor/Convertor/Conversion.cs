using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    public class Conversion
    {
        public string ConvertFrom { get; set; }
        public string ConvertTo { get; set; }
        public decimal Multiplier { get; set; }

        public Conversion(string convertFrom, string convertTo, decimal multiplier)
        {
            ConvertFrom = convertFrom;
            ConvertTo = convertTo;
            Multiplier = multiplier;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", ConvertFrom, ConvertTo);
        }
    }
}
