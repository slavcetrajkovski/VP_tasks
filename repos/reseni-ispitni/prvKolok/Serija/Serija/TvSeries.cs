using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serija
{
    public class TvSeries
    {
        public Production production { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Seasons { get; set; }

        public TvSeries(Production production, string name, double rating, int seasons)
        {
            this.production = production;
            Name = name;
            Rating = rating;
            Seasons = seasons;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} ({2:00})S: {3}", production.Name, Name, Rating, Seasons);
        }
    }
}
