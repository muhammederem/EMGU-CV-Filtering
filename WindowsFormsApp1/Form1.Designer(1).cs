namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bluringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildPyramidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dİlateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eroseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filter2DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologicalShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.geometricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowedLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageProcessingToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.geometricToolStripMenuItem,
            this.drawingFunctionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.binarizeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            // 
            // imageProcessingToolStripMenuItem
            // 
            this.imageProcessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageFilteringToolStripMenuItem});
            this.imageProcessingToolStripMenuItem.Name = "imageProcessingToolStripMenuItem";
            this.imageProcessingToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.imageProcessingToolStripMenuItem.Text = "İmage Processing";
            // 
            // imageFilteringToolStripMenuItem
            // 
            this.imageFilteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothingToolStripMenuItem,
            this.bluringToolStripMenuItem,
            this.biToolStripMenuItem,
            this.buildPyramidToolStripMenuItem,
            this.dİlateToolStripMenuItem,
            this.eroseToolStripMenuItem,
            this.filter2DToolStripMenuItem,
            this.boxFilterToolStripMenuItem,
            this.morphologicalShapesToolStripMenuItem,
            this.sobelToolStripMenuItem});
            this.imageFilteringToolStripMenuItem.Name = "imageFilteringToolStripMenuItem";
            this.imageFilteringToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.imageFilteringToolStripMenuItem.Text = "İmage Filtering";
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            this.smoothingToolStripMenuItem.Click += new System.EventHandler(this.smoothingToolStripMenuItem_Click);
            // 
            // bluringToolStripMenuItem
            // 
            this.bluringToolStripMenuItem.Name = "bluringToolStripMenuItem";
            this.bluringToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.bluringToolStripMenuItem.Text = "Bluring";
            this.bluringToolStripMenuItem.Click += new System.EventHandler(this.bluringToolStripMenuItem_Click);
            // 
            // biToolStripMenuItem
            // 
            this.biToolStripMenuItem.Name = "biToolStripMenuItem";
            this.biToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.biToolStripMenuItem.Text = "Bilateral";
            this.biToolStripMenuItem.Click += new System.EventHandler(this.biToolStripMenuItem_Click);
            // 
            // buildPyramidToolStripMenuItem
            // 
            this.buildPyramidToolStripMenuItem.Name = "buildPyramidToolStripMenuItem";
            this.buildPyramidToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.buildPyramidToolStripMenuItem.Text = "Build Pyramid";
            // 
            // dİlateToolStripMenuItem
            // 
            this.dİlateToolStripMenuItem.Name = "dİlateToolStripMenuItem";
            this.dİlateToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.dİlateToolStripMenuItem.Text = "Dilate";
            this.dİlateToolStripMenuItem.Click += new System.EventHandler(this.dİlateToolStripMenuItem_Click);
            // 
            // eroseToolStripMenuItem
            // 
            this.eroseToolStripMenuItem.Name = "eroseToolStripMenuItem";
            this.eroseToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.eroseToolStripMenuItem.Text = "Erode";
            this.eroseToolStripMenuItem.Click += new System.EventHandler(this.eroseToolStripMenuItem_Click);
            // 
            // filter2DToolStripMenuItem
            // 
            this.filter2DToolStripMenuItem.Name = "filter2DToolStripMenuItem";
            this.filter2DToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.filter2DToolStripMenuItem.Text = "Filter 2D";
            this.filter2DToolStripMenuItem.Click += new System.EventHandler(this.filter2DToolStripMenuItem_Click);
            // 
            // boxFilterToolStripMenuItem
            // 
            this.boxFilterToolStripMenuItem.Name = "boxFilterToolStripMenuItem";
            this.boxFilterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.boxFilterToolStripMenuItem.Text = "Box Filter";
            this.boxFilterToolStripMenuItem.Click += new System.EventHandler(this.boxFilterToolStripMenuItem_Click);
            // 
            // morphologicalShapesToolStripMenuItem
            // 
            this.morphologicalShapesToolStripMenuItem.Name = "morphologicalShapesToolStripMenuItem";
            this.morphologicalShapesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.morphologicalShapesToolStripMenuItem.Text = "Morphological Shapes";
            this.morphologicalShapesToolStripMenuItem.Click += new System.EventHandler(this.morphologicalShapesToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(382, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // geometricToolStripMenuItem
            // 
            this.geometricToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertMapsToolStripMenuItem});
            this.geometricToolStripMenuItem.Name = "geometricToolStripMenuItem";
            this.geometricToolStripMenuItem.Size = new System.Drawing.Size(194, 20);
            this.geometricToolStripMenuItem.Text = "Geometric Image Transformation";
            // 
            // convertMapsToolStripMenuItem
            // 
            this.convertMapsToolStripMenuItem.Name = "convertMapsToolStripMenuItem";
            this.convertMapsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertMapsToolStripMenuItem.Text = "Convert Maps";
            this.convertMapsToolStripMenuItem.Click += new System.EventHandler(this.convertMapsToolStripMenuItem_Click);
            // 
            // drawingFunctionsToolStripMenuItem
            // 
            this.drawingFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrowedLineToolStripMenuItem});
            this.drawingFunctionsToolStripMenuItem.Name = "drawingFunctionsToolStripMenuItem";
            this.drawingFunctionsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.drawingFunctionsToolStripMenuItem.Text = "Drawing Functions";
            // 
            // arrowedLineToolStripMenuItem
            // 
            this.arrowedLineToolStripMenuItem.Name = "arrowedLineToolStripMenuItem";
            this.arrowedLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrowedLineToolStripMenuItem.Text = "Arrowed Line";
            this.arrowedLineToolStripMenuItem.Click += new System.EventHandler(this.arrowedLineToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 662);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bluringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildPyramidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dİlateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eroseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem filter2DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologicalShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem geometricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrowedLineToolStripMenuItem;
    }
}

