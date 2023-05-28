using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DrawingObjects2
{
    public class Circle : Shape
    {
        public static readonly float RADIUS = 25;
        public float radius { get; set; }
        public bool isPulsing;
        public Circle(Point point, Color color) : base(point, color)
        {
            radius = RADIUS;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color);
            g.FillEllipse(b, Point.X - radius, Point.Y - radius, radius * 2, radius * 2);
            b.Dispose();
        }

        public override void Pulse()
        {
            if (isPulsing)
            {
                radius += 3;
                if(radius >= 75)
                {
                    isPulsing = false;
                }
            }
            else
            {
                radius -= 3;
                if(radius <= RADIUS)
                {
                    isPulsing = true;
                }
            }
        }

        public override void Move(Point p)
        {
            Point = p;
        }

        public override bool isHit(Point p)
        {
            return Math.Sqrt(Math.Pow(Point.X - p.X, 2) + Math.Pow(Point.Y - p.Y, 2)) <= radius;
        }
    }
}
