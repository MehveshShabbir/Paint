using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    internal class Triangle : Shape
    {
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, Color colored)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            Colored = colored;

        }

        public override void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Colored, 2);

            Point[] trianglePoints = { new Point(X1, Y1), new Point(X2, Y2), new Point(X3, Y3) };
            g.DrawPolygon(pen1, trianglePoints);
        }

        public override string ToString()
        {
            return "Triangle: " + X1 + "," + Y1 + "," + X2 + "," + Y2 + "," + X3 + "," + Y3;
        }
    }
}
