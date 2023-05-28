using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    [Serializable]
    public class Scene
    {
        public List<Ball> balls { get; set; }

        public static Random random = new Random();

        public int height { get; set; } 

        public int width { get; set; }  

        public int hits { get; set; }
        public int misses { get; set; }

        public Scene(int height, int width)
        {
            balls = new List<Ball>();
            this.height = height;
            this.width = width;
        }

        public void addBall()
        {
            balls.Add(new Ball(new Point(-Ball.RADIUS, random.Next(2 * Ball.RADIUS, height - 2 * Ball.RADIUS))));
        }

        public void move()
        {
            foreach (Ball b in balls) {
                b.move(5, 0);
            }

            foreach(Ball b in balls)
            {
                if(b.center.X - Ball.RADIUS > width)
                {
                    b.state = -1;
                }
            }

            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].state == -1)
                {
                    misses++;
                    balls.RemoveAt(i);
                }
            }
        }

        public void draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.draw(g);
            }
        }

        public void hit(Point location)
        {
            foreach(Ball b in balls)
            {
                b.hit(location);
            }

            for(int i = 0; i < balls.Count; i++)
            {
                if (balls[i].state == 3)
                {
                    hits++;
                    balls.RemoveAt(i);
                }
            }
        }
    }
}
