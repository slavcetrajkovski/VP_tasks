using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvProgram
{
    public class TVProgram
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public TVProgram(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}:{2:00}", Name, Duration / 60, Duration % 60);
        }
    }
}
