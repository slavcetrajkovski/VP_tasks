using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobili
{
    public class Brand
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Brand(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1})", Name, Code);
        }
    }
}
