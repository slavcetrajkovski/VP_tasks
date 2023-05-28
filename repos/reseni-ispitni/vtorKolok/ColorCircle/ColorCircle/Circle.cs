using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircle
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public Color Color { get; set; }
        public bool Selected { get; set; }

        public Circle(int radius, Point center, Color color)
        {
            Radius = radius;
            Center = center;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            if (Selected)
            {
                Pen p = new Pen(Brushes.Red, 5);
                g.DrawEllipse(p, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
                p.Dispose();
            }
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();    
        }

        public bool isHit(Point point){
            return Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
        }
    }
}
