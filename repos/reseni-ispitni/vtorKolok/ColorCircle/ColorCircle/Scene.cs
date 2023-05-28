using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircle
{
    [Serializable]
    public class Scene
    {
        public List<Circle> circles { get; set; }

        public Scene() { 
            circles = new List<Circle>();
        }

        public void AddCircle(Point p, int radius, Color color)
        {
            Circle c = new Circle(radius, p, color);
            circles.Add(c);
        }

        public void Draw(Graphics g)
        {
            foreach (Circle c in circles) { 
                c.Draw(g);
            }
        }

        public void findSelected(Point location)
        {
            foreach (Circle c in circles)
            {
                if(c.isHit(location))
                {
                    c.Selected = true;
                }
            }
        }

        public void deleteSelected()
        {
            for(int i = circles.Count - 1; i >= 0; i--)
            {
                if (circles[i].Selected)
                {
                    circles.RemoveAt(i);
                }
            }
        }
    }
}
