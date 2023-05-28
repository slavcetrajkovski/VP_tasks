using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingPolygons
{
    [Serializable]
    public class Polygon
    {
        List<Point> points { get; set; }
        public bool isClosed { get; set; } = false;
        public bool isCloseToStart { get; set; } = false;

        Point cursor { get; set; } = new Point();

        public Polygon()
        {
            points = new List<Point>();
        }

        public void addPoint(Point point)
        {
            isCloseToStart = nearStart();
            if (isCloseToStart)
            {
                points.Add(points[0]);
                isClosed = true;
                isCloseToStart = false;
            }
            else
            {
                points.Add(point);
            }
        }  

        public void updateCursor(Point p)
        {
            cursor = p;
            isCloseToStart = nearStart();
        }

       public bool nearStart()
        {
            if(points.Count < 3)
            {
                return false;
            }
            Point firstPoint = points[0];
            double distance = Math.Sqrt(Math.Pow(firstPoint.X - cursor.X, 2) + Math.Pow(firstPoint.Y - cursor.Y, 2));
            return distance <= 5;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2); //penkalo za linii
            Pen pDashed = new Pen(Color.Black, 1);
            pDashed.DashStyle = DashStyle.Dash;
            Brush brush = new SolidBrush(Color.Blue);

            if(points.Count >= 2)
            {
                g.DrawLines(p, points.ToArray());
                if (isCloseToStart)
                {
                    Point firsPoint = points[0];
                    g.DrawEllipse(pDashed, firsPoint.X-5, firsPoint.Y-5, 10, 10);
                }

                if (isClosed)
                {
                    g.FillPolygon(brush, points.ToArray());
                }
            }

            if(points.Count > 0)
            {   
                Point lastPoint = points[points.Count - 1];
                g.DrawLine(pDashed, lastPoint, cursor);
            }


            p.Dispose();
            pDashed.Dispose();
            brush.Dispose();
            
        }
    }
}
