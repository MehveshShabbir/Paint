using System;
using System.Drawing;

namespace PaintClass
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbRect = new System.Windows.Forms.ToolStripButton();
            this.tsbCircle = new System.Windows.Forms.ToolStripButton();
            this.tsbTriangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Filler = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.ColorPaletteStrip = new System.Windows.Forms.ToolStrip();
            this.btnBlack = new System.Windows.Forms.ToolStripButton();
            this.btnRed = new System.Windows.Forms.ToolStripButton();
            this.btnYellow = new System.Windows.Forms.ToolStripButton();
            this.btnGreen = new System.Windows.Forms.ToolStripButton();
            this.btnBlue = new System.Windows.Forms.ToolStripButton();
            this.btnBrown = new System.Windows.Forms.ToolStripButton();
            this.btnPurple = new System.Windows.Forms.ToolStripButton();
            this.btnGrey = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ColorPaletteStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.toolStripMenuItem2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click_1);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.SquareToolStripMenu);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 34);
            this.toolStripMenuItem2.Text = "Star";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.StarToolStripMenuItem);
            this.toolStripMenuItem2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem2_MouseDown);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelect,
            this.tsbLine,
            this.tsbRect,
            this.tsbCircle,
            this.tsbTriangle,
            this.toolStripButton1,
            this.toolStripButton2,
            this.Filler});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(606, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbSelect
            // 
            this.tsbSelect.CheckOnClick = true;
            this.tsbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelect.Image = global::PaintClass.Properties.Resources.Select;
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(34, 28);
            this.tsbSelect.Tag = "SELECTION";
            this.tsbSelect.Text = "toolStripButton1";
            this.tsbSelect.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // tsbLine
            // 
            this.tsbLine.CheckOnClick = true;
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLine.Image = global::PaintClass.Properties.Resources.Bitmap1;
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(34, 28);
            this.tsbLine.Tag = "LINE";
            this.tsbLine.Text = "toolStripButton2";
            this.tsbLine.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // tsbRect
            // 
            this.tsbRect.CheckOnClick = true;
            this.tsbRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRect.Image = global::PaintClass.Properties.Resources.Rectangle;
            this.tsbRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRect.Name = "tsbRect";
            this.tsbRect.Size = new System.Drawing.Size(34, 28);
            this.tsbRect.Tag = "RECT";
            this.tsbRect.Text = "toolStripButton3";
            this.tsbRect.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // tsbCircle
            // 
            this.tsbCircle.CheckOnClick = true;
            this.tsbCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCircle.Image = global::PaintClass.Properties.Resources.Circle;
            this.tsbCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCircle.Name = "tsbCircle";
            this.tsbCircle.Size = new System.Drawing.Size(34, 28);
            this.tsbCircle.Tag = "CIRCLE";
            this.tsbCircle.Text = "toolStripButton4";
            this.tsbCircle.Click += new System.EventHandler(this.circleToolStripMenuItem_Click_1);
            // 
            // tsbTriangle
            // 
            this.tsbTriangle.CheckOnClick = true;
            this.tsbTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTriangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbTriangle.Image")));
            this.tsbTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTriangle.Name = "tsbTriangle";
            this.tsbTriangle.Size = new System.Drawing.Size(34, 28);
            this.tsbTriangle.Tag = "TRIANGLE";
            this.tsbTriangle.Text = "toolStripButton1";
            this.tsbTriangle.Click += new System.EventHandler(this.TriangleToolStripMenuItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PaintClass.Properties.Resources.Square;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Tag = "SQUARE";
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.SquareToolStripMenu);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.CheckOnClick = true;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::PaintClass.Properties.Resources.Star;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Tag = "STAR";
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.StarToolStripMenuItem);
            // 
            // Filler
            // 
            this.Filler.CheckOnClick = true;
            this.Filler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Filler.Image = ((System.Drawing.Image)(resources.GetObject("Filler.Image")));
            this.Filler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Filler.Name = "Filler";
            this.Filler.Size = new System.Drawing.Size(34, 28);
            this.Filler.Tag = "FILLER";
            this.Filler.Text = "toolStripButton3";
            this.Filler.Click += new System.EventHandler(this.Filler_Click);
            // 
            // ColorPaletteStrip
            // 
            this.ColorPaletteStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColorPaletteStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ColorPaletteStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBlack,
            this.btnRed,
            this.btnYellow,
            this.btnGreen,
            this.btnBlue,
            this.btnBrown,
            this.btnPurple,
            this.btnGrey});
            this.ColorPaletteStrip.Location = new System.Drawing.Point(0, 66);
            this.ColorPaletteStrip.Name = "ColorPaletteStrip";
            this.ColorPaletteStrip.Size = new System.Drawing.Size(36, 306);
            this.ColorPaletteStrip.TabIndex = 2;
            this.ColorPaletteStrip.Text = "toolStrip2";
            // 
            // btnBlack
            // 
            this.btnBlack.CheckOnClick = true;
            this.btnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBlack.Image = global::PaintClass.Properties.Resources.Black;
            this.btnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(31, 28);
            this.btnBlack.Text = "toolStripButton3";
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnRed
            // 
            this.btnRed.CheckOnClick = true;
            this.btnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRed.Image = global::PaintClass.Properties.Resources.Red;
            this.btnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(31, 28);
            this.btnRed.Text = "toolStripButton4";
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.CheckOnClick = true;
            this.btnYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYellow.Image = global::PaintClass.Properties.Resources.Yellow;
            this.btnYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(31, 28);
            this.btnYellow.Text = "toolStripButton5";
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.CheckOnClick = true;
            this.btnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGreen.Image = global::PaintClass.Properties.Resources.Green1;
            this.btnGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(31, 28);
            this.btnGreen.Text = "toolStripButton6";
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.CheckOnClick = true;
            this.btnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBlue.Image = global::PaintClass.Properties.Resources.Blue;
            this.btnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(31, 28);
            this.btnBlue.Text = "toolStripButton7";
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBrown
            // 
            this.btnBrown.CheckOnClick = true;
            this.btnBrown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrown.Image = global::PaintClass.Properties.Resources.Brown;
            this.btnBrown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(31, 28);
            this.btnBrown.Text = "toolStripButton8";
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.CheckOnClick = true;
            this.btnPurple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPurple.Image = global::PaintClass.Properties.Resources.Purple;
            this.btnPurple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(31, 28);
            this.btnPurple.Text = "toolStripButton9";
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnGrey
            // 
            this.btnGrey.CheckOnClick = true;
            this.btnGrey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrey.Image = global::PaintClass.Properties.Resources.Grey;
            this.btnGrey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrey.Name = "btnGrey";
            this.btnGrey.Size = new System.Drawing.Size(31, 28);
            this.btnGrey.Text = "toolStripButton10";
            this.btnGrey.Click += new System.EventHandler(this.btnGrey_Click);
            // 
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.ColorPaletteStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ColorPaletteStrip.ResumeLayout(false);
            this.ColorPaletteStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripButton tsbLine;
        private System.Windows.Forms.ToolStripButton tsbRect;
        private System.Windows.Forms.ToolStripButton tsbCircle;
        private System.Windows.Forms.ToolStripButton tsbTriangle;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStrip ColorPaletteStrip;
        private System.Windows.Forms.ToolStripButton btnBlack;
        private System.Windows.Forms.ToolStripButton btnRed;
        private System.Windows.Forms.ToolStripButton btnYellow;
        private System.Windows.Forms.ToolStripButton btnGreen;
        private System.Windows.Forms.ToolStripButton btnBlue;
        private System.Windows.Forms.ToolStripButton btnBrown;
        private System.Windows.Forms.ToolStripButton btnPurple;
        private System.Windows.Forms.ToolStripButton btnGrey;
        private System.Windows.Forms.ToolStripButton Filler;
    }
}

