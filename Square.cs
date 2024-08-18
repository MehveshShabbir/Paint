using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    internal class Square : Shape
    {
        public int SideLength { get; set; }

        public Square(int x1, int y1, int sideLength, Color colored)
        {
            X1 = x1;
            Y1 = y1;
            SideLength = sideLength;
            Colored = colored;
        }

        public override void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Colored, 2);
            g.DrawRectangle(pen1, X1, Y1, SideLength, SideLength);
        }

        public override string ToString()
        {
            return "Square: " + X1 + "," + Y1 + "," + SideLength;
        }
    }
}
