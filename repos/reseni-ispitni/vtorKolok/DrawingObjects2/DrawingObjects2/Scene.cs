using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DrawingObjects2
{
    public class Scene
    {
        public List<Shape> shapes { get; set; }

        public Scene()
        {
            shapes = new List<Shape>();
        }

        public enum ShapeType
        {
            CIRCLE,
            TRIANGLE
        }

        public void Draw(Graphics g)
        {
            foreach (Shape shape in shapes) {
                shape.Draw(g);
            }
        }

        public void AddShape(Point p, ShapeType type)
        {
            Shape s = null;
            if(type == ShapeType.CIRCLE)
            {
                 s = new Circle(p, Color.Red);
            }else if(type == ShapeType.TRIANGLE)
            {
                 s = new Triangle(p, Color.Red, new Point(p.X + 50, p.Y), new Point(p.X, p.Y + 40));
            }
            
            shapes.Add(s);
        }

        public void Pulse()
        {
            foreach (Shape shape in shapes)
            {
                shape.Pulse();
            }
        }

        internal void findShape(Point location)
        {
            foreach
                (Shape shape in shapes)
            {
                if (shape.isHit(location))
                {
                    shape.Selected = true;
                }
            }
        }

        internal void Move(Point location)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.Selected)
                {
                    shape.Move(location);
                }
            }
        }

        internal void Unselect(Point location)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.Selected)
                {
                    //shape.Move(location);
                    shape.Selected = false;
                }
            }
        }
    }
}
