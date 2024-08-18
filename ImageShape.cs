using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    internal class ImageShape: Shape
    {
        private Bitmap image;

        public ImageShape(Bitmap image, Color colored)
        {
            this.image = image;
            Colored = colored;
        }

        public override void Draw(Graphics g)
        {
            // Draw the image on the graphics object
            g.DrawImage(image, X1, Y1, image.Width, image.Height);
        }

        public override string ToString()
        {
            return "ImageShape: " + X1 + "," + Y1 + " Size: " + image.Width + "x" + image.Height;
        }
    }
}
