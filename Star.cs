using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    internal class Star :  Shape
    {
        public int Size { get; set; }

        public Star(int x, int y, int size, Color colored)
        {
            X1 = x;
            Y1 = y;
            Size = size;
            Colored = colored;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Colored, 2);

            int numberOfPoints = 5; // You can adjust this based on the number of points you want in your star

            PointF[] starPoints = GetStarPoints(X1, Y1, Size, numberOfPoints);

            g.DrawPolygon(pen, starPoints);
        }

        private PointF[] GetStarPoints(int x, int y, int size, int points)
        {
            PointF[] starPoints = new PointF[2 * points];

            double angle = -Math.PI / 2; // Start angle at the top

            double angleIncrement = Math.PI / points; // Angle between each point

            for (int i = 0; i < starPoints.Length; i++)
            {
                double factor = (i % 2 == 0) ? 0.5 : 1.0; // Alternate between inner and outer points
                double newX = x + size * factor * Math.Cos(angle);
                double newY = y + size * factor * Math.Sin(angle);

                starPoints[i] = new PointF((float)newX, (float)newY);

                angle += angleIncrement;
            }

            return starPoints;
        }

        public override string ToString()
        {
            return "Star: " + X1 +"," + Y1+ ", Size: "+ Size;
        }
    }
}
