using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomobili
{
    public class Car
    {
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public double Consumption { get; set; }
        public int Price { get; set; }

        public Car(Brand brand, string model, double consumption, int price)
        {
            Brand = brand;
            Model = model;
            Consumption = consumption;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2:0.0} {3}", Brand.Name, Model, Consumption, Price);
        }

    }
}
