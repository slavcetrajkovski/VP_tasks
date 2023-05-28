using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naracki
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }

        public Order(Product product, int quantity, string note)
        {
            Product = product;
            Quantity = quantity;
            Note = note;
        }

        public int total()
        {
            return Product.Price * Quantity;
        }

        public override string ToString()
        {
            return String.Format("{0} x {1} = {2} ден", Quantity, Product.Name, total());
        }
    }
}
