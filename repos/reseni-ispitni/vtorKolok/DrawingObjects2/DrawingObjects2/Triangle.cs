using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DrawingObjects2
{
    public class Triangle : Shape
    {
       
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public bool isPulsing;

        public Triangle(Point point, Color color, Point p1, Point p2) : base(point, color)
        {
            P1 = p1;
            P2 = p2;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            Point[] points = {Point, P1, P2};
            g.FillPolygon(b, points);
            b.Dispose();
        }

        public override void Move(Point p)
        {
           
        }

        public override void Pulse()
        {
            if (isPulsing)
            {
                P1 = new Point(P1.X + 3, P1.Y);
                P2 = new Point(P2.X, P2.Y + 2);
                if (P1.X >= Point.X + 100 || P2.Y >= Point.Y + 100)
                {
                    isPulsing = false;
                }
            }
            else
            {
                P1 = new Point(P1.X - 3, P1.Y);
                P2 = new Point(P2.X, P2.Y - 2);
                if (P1.X <= Point.X || P2.Y <= Point.Y)
                {
                    isPulsing = true;
                }
            }
        }

        public override bool isHit(Point p)
        {
            throw new NotImplementedException();
        }
    }
}
