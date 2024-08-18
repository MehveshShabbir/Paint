using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PaintClass
{
    public class ColorPaletteControl : UserControl
    {
        private FlowLayoutPanel flowLayoutPanel;

        public Color SelectedColor { get; private set; }

        public ColorPaletteControl()
        {
            InitializeComponent();
            InitializeColorButtons();
        }

        private void InitializeComponent()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            Controls.Add(flowLayoutPanel);
        }

        private void InitializeColorButtons()
        {
            AddColorButton(Color.Black);
            AddColorButton(Color.Red);
            AddColorButton(Color.Green);
            AddColorButton(Color.Blue);
            AddColorButton(Color.Yellow);
            AddColorButton(Color.Orange);
            AddColorButton(Color.Purple);
            AddColorButton(Color.Gray);
        }

        private void AddColorButton(Color color)
        {
            Button colorButton = new Button
            {
                BackColor = color,
                Size = new Size(30, 30),
                Margin = new Padding(2),
                Tag = color,
            };

            colorButton.Click += ColorButton_Click;

            flowLayoutPanel.Controls.Add(colorButton);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button colorButton)
            {
                SelectedColor = (Color)colorButton.Tag;
                OnColorChanged(EventArgs.Empty);
            }
        }

        public event EventHandler ColorChanged;

        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged?.Invoke(this, e);
        }
    }
}
