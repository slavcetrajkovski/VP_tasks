using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowingBaloons
{
    [Serializable]
    public class Scene
    {
        public List<Balloon> balloons {get; set;}

        public Scene()
        {
            balloons = new List<Balloon>();
        }

        public void addBalloons(Point p)
        {
            Balloon b = new Balloon(p);
            balloons.Add(b);
        }

        public void Draw(Graphics g)
        {
            foreach(Balloon balloon in balloons)
            {
                balloon.Draw(g);
            }
        }

        public void blowBalloons()
        {
            foreach (Balloon balloon in balloons)
            {
                balloon.blowBalloon();
            }
        }

        public void explosion()
        {
            for(int i = 0; i < balloons.Count; i++)
            {
                for(int j = i + 1; j < balloons.Count; j++) 
                {
                    if (balloons[i].touching(balloons[j]))
                    {
                        balloons[i].flag = true;
                        balloons[j].flag = true;
                    }
                }
            }

            for(int i = balloons.Count - 1; i >= 0; i--)
            {
                if (balloons[i].flag)
                {
                    balloons.RemoveAt(i);
                }
            }
        }
    }
}
