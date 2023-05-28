using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serija
{
    public class Production
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Production(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Code, Name);
        }
    }
}
