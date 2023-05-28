using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregled
{
    public class Patient
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public List<Measurement> measurements { get; set; }

        public Patient(string name, int weight, int height)
        {
            Name = name;
            Weight = weight;
            Height = height;
            measurements = new List<Measurement>();
        }

        public Patient()
        {
        }

        public override string ToString()
        {
            return String.Format("{0} {1}kg {2} cm", Name, Weight, Height);
        }
    }
}
