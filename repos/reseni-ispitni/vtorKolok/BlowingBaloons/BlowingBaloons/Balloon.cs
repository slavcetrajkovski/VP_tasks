using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowingBaloons
{
    [Serializable]
    public class Balloon
    {
        public int radius {get; set;}
        public Point center { get; set; }
        public Color color { get; set; }  
        public bool flag { get; set; }

        public Balloon(Point center)
        {
            this.center = center;
            this.radius = radius;
            Random random = new Random();
            color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            radius = random.Next(20, 30);
            flag = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, center.X - radius, center.Y - radius, radius * 2, radius * 2);
            brush.Dispose();
        }

        public void blowBalloon()
        {
            radius += 5;
        }

        public bool touching(Balloon b)
        {
            double distance = Math.Pow(center.X - b.center.X, 2) + Math.Pow(center.Y - b.center.Y, 2);
            return distance <= Math.Pow(radius + b.radius, 2);
        }
    }
}
