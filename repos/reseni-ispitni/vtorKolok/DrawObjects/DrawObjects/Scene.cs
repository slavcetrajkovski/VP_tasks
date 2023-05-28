using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawObjects
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; }

        public Scene()
        {
            Shapes = new List<Shape>();
        }

        public void addShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void DrawAll(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
        }

        public void Click(Point location, string ShapeType)
        {
            bool found = false;
            foreach(Shape s in Shapes) {
                if (s.isHit(location))
                {
                    found = true;
                    s.Selected = !s.Selected;
                }
            }

            if(!found)
            {
                if(ShapeType == "Circle")
                {
                    Shapes.Add(new Circle(Color.Red, 30, location));
                }
                else
                {
                    Shapes.Add(new Square(Color.Red, 60, location));
                }
            } 

        }

        public void Pulse()
        {
            foreach(Shape s in Shapes) { 
                s.Pulse();
            }
        }
    }
}
