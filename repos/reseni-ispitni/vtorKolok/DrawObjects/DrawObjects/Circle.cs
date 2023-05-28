using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects
{
    public class Circle : Shape
    {

        public Point Center { get; set; }
        private int qoef = -1;
        public Circle(Color color, int size, Point Center) : base(color, size)
        {
            this.Center = Center;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color); //deklariranje cetka za crtanje
            g.FillEllipse(b, Center.X - Size, Center.Y - Size, 2 * Size, 2 * Size); //pretstavuvanje na krugot vo formata
            if (Selected) //ako e selektirano vekje nacrtano topche, da se oboi vo zolto
            {
                Pen p = new Pen(Color.Yellow, 2);
                g.DrawEllipse(p, Center.X - Size, Center.Y - Size, 2 * Size, 2 * Size);
                p.Dispose();
            }
            b.Dispose(); //mienje cetka
        }

        public override bool isHit(Point p)
        {
           return Math.Sqrt(Math.Pow(Center.X-p.X, 2) + Math.Pow(Center.Y-p.Y, 2)) <= Size;
        }

        public override void Pulse()
        {
            Size += (qoef * 3);
            if(Size >= 30 || Size <= 6)
            {
                qoef *= -1;
            }
        }
    }
}
