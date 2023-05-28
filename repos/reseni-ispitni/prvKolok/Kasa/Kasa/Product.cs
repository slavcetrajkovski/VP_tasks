using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} {2:0.00}", Code, Name, Price);
        }
    }
}
