using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    internal class Line : Shape
    {
        // Defien those new coordinates that will be needed to draw a Line
        public int X2 { get; set; }
        public int Y2 { get; set; }

        // Constructor to pass values
        public Line(int x1, int y1, int x2, int y2, Color colored)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Colored = colored;
        }

        // Overroide the Draw function of Shape
        public override void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Colored, 2);
            g. DrawLine(pen1, X1, Y1, X2, Y2);
        }


       
        public override string ToString()
        {
            return "Line: " + X1 + "," + Y2 + "," + X2 + "," + Y2;
        }
    }
}
