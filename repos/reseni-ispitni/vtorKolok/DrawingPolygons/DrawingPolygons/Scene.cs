using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingPolygons
{
    [Serializable]
    public class Scene
    {
        List<Polygon> polygons { get; set; } = new List<Polygon>();
        Polygon currentPolygon { get; set; }    

        public Scene() { 
            polygons = new List<Polygon>();
            currentPolygon = new Polygon();
        }

        public void addPoint(Point p)
        {
            currentPolygon.addPoint(p);
            if (currentPolygon.isClosed)
            {
                polygons.Add(currentPolygon);
                currentPolygon = new Polygon();
            }
        }

       public void update(Point p)
        {
            currentPolygon.updateCursor(p);
        }

        public void Draw(Graphics g) {
            currentPolygon.Draw(g);
            foreach (Polygon p in polygons) {
                p.Draw(g);
            }
        }
    }
}
