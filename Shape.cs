using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    // internal class Shape
    // Make it a abstract class because itself does jot have a function
    internal abstract class Shape
    {
        // Attributes are x and y axis which willl accessible to every child shapoe
        public int X1 {  get; set; }
        public int Y1 { get; set; }

        public Color Colored { get; set; }
        public bool Fill { get; set; }
        public bool IsSelected { get; set; }


        // Create  aastract function that will draw the shape
        public abstract void Draw(Graphics g);
    }
}
