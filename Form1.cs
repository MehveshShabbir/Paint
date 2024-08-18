using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintClass
{
    // A user defined data type conatin all shapes as its attribute. 
    public enum SHAPETOOLS
    {
        SELECT,
        LINE,
        RECT,
        CIRCLE,
        TRIANGLE,
        SQUARE,
        STAR, 
        BUCKET
    }
    public enum FILLMODE
    {
        OFF,
        ON
    }


    public partial class Form1 : Form
    {
        // Create attributes fr satring and ending points
        int x1, y1;
        int x2, y2;

        // Create a flag to allow drawing or not
        bool IsDrawing = false;
        // Lets create a list to store te shapes drawn by user
        List<Shape> Shapes = new List<Shape>(); // Shape is not built in data type
                                                // Define a class Shape that will hold basic functions

        private List<Shape> SelectedShapes = new List<Shape>();
        private Selection currentSelection;

        // SeelctedTool should be of type SHAPETOOLS(containg all basic shapes)
        SHAPETOOLS SelectedTool = SHAPETOOLS.SELECT; // It should be of type which incliudes all shapes
        private object drawingGraphics;

        // So defined a user defined data type SHAPETOOLS

        private FILLMODE FillMode = FILLMODE.OFF;


        private Color currentColor = Color.Black; // Default color

        public Form1()
        {
            InitializeComponent();
            // Initialize ColorPalette

        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseClick += Form1_MouseClick;

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FillMode == FILLMODE.ON)
            {
                // Perform bucket fill at the clicked point
                PerformBucketFill(new Point(e.X, e.Y));

                // Disable filling after one use
                FillMode = FILLMODE.OFF;
                this.Cursor = Cursors.Default;
            }
        }
        private void PerformBucketFill(Point clickPoint)
        {
            if (FillMode == FILLMODE.OFF)
            {
                return;
            }

            // Get the color from your palette or use the currentColor attribute
            Color selectedColor = currentColor; // You can replace this with the actual way you get the color

            // Create a bitmap to store the canvas
            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);

            // Create a graphics object from the bitmap
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Draw all existing shapes on the bitmap
                foreach (Shape shape in Shapes)
                {
                    shape.Draw(g);
                }
            }

            // Get the color of the clicked point
            Color targetColor = bmp.GetPixel(clickPoint.X, clickPoint.Y);

            // Create a queue for flood fill algorithm
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(clickPoint);

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();

                // Check if the current point is within the canvas boundaries
                if (current.X >= 0 && current.X < bmp.Width && current.Y >= 0 && current.Y < bmp.Height)
                {
                    // Check if the current pixel has the target color
                    if (bmp.GetPixel(current.X, current.Y) == targetColor)
                    {
                        // Set the pixel color to the new color
                        bmp.SetPixel(current.X, current.Y, selectedColor);

                        // Enqueue neighboring pixels
                        queue.Enqueue(new Point(current.X + 1, current.Y));
                        queue.Enqueue(new Point(current.X - 1, current.Y));
                        queue.Enqueue(new Point(current.X, current.Y + 1));
                        queue.Enqueue(new Point(current.X, current.Y - 1));
                    }
                }
            }

            // Update the Shapes list with the filled bitmap using the selected color
            Shapes.Clear();
            Shapes.Add(new ImageShape(bmp, selectedColor));

            // Trigger a repaint to display the filled canvas
            Refresh();
        }



        // Temporarily draw the shapes
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            // If Graphics object  available for drawing
            if (e.Graphics != null)
            {
                // Iterate through each Shape object in Shapes list 
                // Every time we paint a new shape, all the previous shapes stored in list are drawn
                foreach (Shape s in Shapes)
                {
                    // calls and Override the function Draw on current shape(s) defined in Shape class
                    // And render the shape Grapics on screen
                    s.Draw(e.Graphics);
                }

                // An insatcne of A built in data type pen for drawing shapes
                Pen pen1 = new Pen(currentColor, 2);
                // Draw shapes depending on Tool
                switch (SelectedTool) // Orignally this var is empty. Lets fill it before constructor
                {
                    case SHAPETOOLS.SELECT:
                        // Draw the selection rectangle if it exists
                        if (currentSelection != null)
                        {
                            currentSelection.Draw(e.Graphics);
                        }
                        break;
                    // Now while drawing we have to define the drawer(pencil), weight ad color.
                    // For this lets create an instance of built in pencil having fixed size just before this function
                    case SHAPETOOLS.LINE:
                        // if LINE is selted from SHAPETOOLS, use DrawLine function of paint instance e
                        // Show it on screen using graphics
                        e.Graphics.DrawLine(pen1, x1, y1, x2, y2); //(Pen, satring points, ending points)
                                                                   // Define all these points before constructor as attributes
                        break;

                    case SHAPETOOLS.RECT:      //(pen, x1, y1,  width  , height)
                        e.Graphics.DrawRectangle(pen1, x1, y1, x2 - x1, y2 - y1);
                        break;

                    case SHAPETOOLS.CIRCLE: //(pen,  x1, y1,  width , height )
                        e.Graphics.DrawEllipse(pen1, x1, y1, x2 - x1, y2 - y1);
                        break;

                    case SHAPETOOLS.TRIANGLE:
                        int x3 = x1 + (x2 - x1) / 2;
                        int y3 = y1 - (int)Math.Sqrt(3) * (x2 - x1) / 2;

                        e.Graphics.DrawPolygon(pen1, new Point[] { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) });
                        break;

                    case SHAPETOOLS.SQUARE:
                        int sideLength = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                        e.Graphics.DrawRectangle(pen1, x1, y1, sideLength, sideLength);
                        break;
                    case SHAPETOOLS.STAR:
                        int size = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                        Star star = new Star(x1, y1, size, currentColor);
                        star.Draw(e.Graphics);  // Call the Draw method directly
                        break;
                }

                // Now theres no information how on mouse events shapes  will be drawn 
            }
        }
        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton button)
                {
                    button.Checked = false;
                }
            }

            // Check the clicked button
            if (sender is ToolStripButton clickedButton)
            {
                clickedButton.Checked = true;

                // Handle the corresponding action based on the selected tool
                // ...

                // Update the selected tool in your Form1 class (you can use Tag property to store tool information)
                if (clickedButton.Tag is SHAPETOOLS selectedTool)
                {
                    SelectedTool = selectedTool;
                }
            }
        }
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.SELECT;

        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.LINE;
        }
        

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.RECT;
        }

        private void circleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.CIRCLE;
        }
        private void TriangleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.TRIANGLE;
        }
        private void SquareToolStripMenu(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.SQUARE;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton button)
                {
                    button.Checked = false;
                }
            }

            // Check the clicked button
            if (sender is ToolStripButton clickedButton)
            {
                clickedButton.Checked = true;

                // Handle the corresponding action based on the selected tool
                // ...

                // Update the selected tool in your Form1 class (you can use Tag property to store tool information)
                if (clickedButton.Tag is SHAPETOOLS selectedTool)
                {
                    SelectedTool = selectedTool;
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveChanges()
        {
            // Lets use a built in Save Dialogue Box
            SaveFileDialog saveDialogue = new SaveFileDialog(); ;

            // Optionally apply a filetr of whcih types files shold be open
            //saveDialogue.Filter = "Mehvesh Vector Graphics (.mvg)|*.mvg";

            // Display Dialogue box
            if (saveDialogue.ShowDialog() == DialogResult.OK)
            {
                // If shown, Write data on instance of StreamWriter
                // Also pass the file name from dialogue box to instance to write data on file
                StreamWriter writeonFiles = new StreamWriter(saveDialogue.FileName);

                // We have to keep writing for all the sahpes in the list
                for (int i = 0; i < Shapes.Count; i++)
                {
                    // Optionally convert it in sring so it can be readable
                    writeonFiles.WriteLine(Shapes[i].ToString());

                }
                MessageBox.Show("File Successfully Saved!");
                // Close File
                writeonFiles.Close();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialogue = new OpenFileDialog();
            openDialogue.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("would you like to save this work?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                SaveChanges();

                
            }
            
            Shapes.Clear();
            
            using (Graphics formGraphics = CreateGraphics())
            {
                // Clear the drawing surface
                formGraphics.Clear(Color.White);
            }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("would you like to save this work?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                SaveChanges();

            }
            Close();
        }

        private void StarToolStripMenuItem(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.STAR;
        }

        private void toolStripMenuItem2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;

        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;

        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            currentColor = Color.Brown;

        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            currentColor = Color.Purple;

        }

        private void btnGrey_Click(object sender, EventArgs e)
        {
            currentColor = Color.Gray;

        }

        private void Filler_Click(object sender, EventArgs e)
        {
            SelectedTool = SHAPETOOLS.SELECT;

            FillMode = FillMode == FILLMODE.OFF ? FILLMODE.ON : FILLMODE.OFF;

            if (FillMode == FILLMODE.ON) // Fix the condition here
            {
                // Change the cursor to indicate that filling is active
                this.Cursor = Cursors.Cross;
                
            }
            else
            {
                // Change the cursor back to the default cursor
                this.Cursor = Cursors.Default;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                y2 = e.Y;
                x2 = e.X;

                // Triggerss paint screen to redraw the updated coordinates  
                Invalidate();
            }

        }


        // Will add to the loista dn will show all previous shapes as well
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            Invalidate();

            // when users mouse up, drawing should be stopped
            IsDrawing = false;

            // We have taken the coordiantes, now the final shape will be storedin Shapes  
            // depending on slected tool
            switch (SelectedTool)
            {
                case SHAPETOOLS.LINE:
                    Shapes.Add(new Line(x1, y1, x2, y2, currentColor));
                    break;

                case SHAPETOOLS.RECT:
                    Shapes.Add(new Rectangle(x1, y1, x2 - x1, y2 - y1, currentColor));
                    break;

                case SHAPETOOLS.CIRCLE:
                    Shapes.Add(new Circle(x1, y1, x2 - x1, y2 - y1, currentColor));
                    break;

                case SHAPETOOLS.TRIANGLE:
                    {
                        Shapes.Add(new Triangle(x1, y1, x2, y2, x1 + (x2 - x1) / 2, y1 - (int)Math.Sqrt(3) * (x2 - x1) / 2, currentColor));
                        break;
                    }
                case SHAPETOOLS.SQUARE:
                    Shapes.Add(new Square(x1, y1, Math.Max(x2 - x1, y2 - y1), currentColor));
                    break;
                // Now theres no info about how these arguments and create the resoective shape
                // So create classes for all these shapes derived from Shape class
                case SHAPETOOLS.STAR:
                    int size = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                    Shapes.Add(new Star(x1, y1, size, currentColor));
                    break;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // we will store paint instacne e coordinates in x1, y1
            x1 = e.X;
            y1 = e.Y;


            IsDrawing = true;  // This should be created as an attribute
        }


    }
}
