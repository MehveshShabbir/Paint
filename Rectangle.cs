using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    
    internal class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x1, int y1, int width, int height , Color colored)
        {
            X1 = x1;
            Y1 = y1;
            Width = width;
            Height = height;
            Colored = colored;

        }

        public override void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Colored, 2);
            g.DrawRectangle(pen1, X1, Y1, Width, Height);
        }


        public override string ToString()
        {
            return "Rectangel: " + X1 + ","+Y1 + "," + Width + "," + Height;
        }


    }
}
