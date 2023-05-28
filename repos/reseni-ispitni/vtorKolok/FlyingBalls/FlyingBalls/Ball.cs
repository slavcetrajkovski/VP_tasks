using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace FlyingBalls
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS = 40;

        public static Random random = new Random();
        public Point center { get; set; }

        // 0-crveno, 1-sino, 2-zeleno, 3-za brisenje, -1-nadvor od ekran
        public int state { get; set; }

        public Ball(Point center)
        {
            this.center = center;
            state = random.Next(3); //0,1,2
        } 

        public void draw(Graphics g)
        {
            Color color;
            switch(state)
            {
                case 0: color = Color.Red; break;
                case 1: color = Color.Blue; break;
                default: color = Color.Green; break;
            }

            Brush b = new SolidBrush(color);
            g.FillEllipse(b, center.X - RADIUS, center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            b.Dispose();
        }

        public void move(int dx, int dy)
        {
            center = new Point(center.X + dx, center.Y + dy);
        }

        public bool hit(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(center.X - p.X, 2) + Math.Pow(center.Y - p.Y, 2));
            if(distance < RADIUS)
            {
                state++;
                return true;
            }
            return false;
        }
    }
}
