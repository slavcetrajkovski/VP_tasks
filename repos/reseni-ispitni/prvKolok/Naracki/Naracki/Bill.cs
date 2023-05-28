using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naracki
{
    public class Bill
    {
        public DateTime Time { get; set; }
        public int Total { get; set; }

        public Bill()
        {
           
        }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2}", Time.ToShortDateString(), Time.ToLongTimeString(), Total);
        }
    }
}
