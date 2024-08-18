using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintClass
{
    internal class Selection : Shape
    {
        private PaintClass.Rectangle selectionRectangle;

        public Selection(PaintClass.Rectangle rectangle)
        {
            selectionRectangle = rectangle;
        }

        public override void Draw(Graphics g)
        {
            // Implement how you want the selection to be drawn
            // For example, drawing a border around the selected area
            Pen pen = new Pen(Color.Black, 1);
            g.DrawRectangle(pen, selectionRectangle.X1, selectionRectangle.Y1, selectionRectangle.Width, selectionRectangle.Height);
        }
    }
}
