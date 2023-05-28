using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa
{
    public class Item
    {
        public Product product { get; set; }
        public int quantity { get; set; }

        public Item(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} X {2} = {3:0.00}", product.Name, product.Price, quantity, product.Price * quantity);
        }

        public double price()
        {
            return product.Price * quantity;
        }
    }
}
