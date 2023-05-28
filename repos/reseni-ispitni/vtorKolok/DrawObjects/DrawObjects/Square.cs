using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects
{
    public class Square : Shape
    {

        public Point TopLeft { get; set; }
        private int qoef = -1;
        public Square(Color color, int size, Point topLeft) : base(color, size)
        {
            this.TopLeft = topLeft;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color);
            g.FillRectangle(b, TopLeft.X, TopLeft.Y, Size, Size);
            if (Selected)
            {
                Pen p = new Pen(Color.Yellow, 2);
                g.DrawRectangle(p, TopLeft.X, TopLeft.Y, Size, Size);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool isHit(Point p)
        {
            Rectangle r = new Rectangle(TopLeft.X, TopLeft.Y, Size, Size);
            return r.Contains(p);
      
        }

        public override void Pulse()
        {
            Size += (qoef * 2);
            if (Size >= 60 || Size <= 10)
            {
                qoef *= -1;
            }
        }

    }
}
