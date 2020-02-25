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
            this.biToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildPyramidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filter2DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyrDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyrUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyrMeanShiftFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scharrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareBoxFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatailGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageProcessingToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.biToolStripMenuItem,
            this.buildPyramidToolStripMenuItem,
            this.filter2DToolStripMenuItem,
            this.boxFilterToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.medianBlurToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.pyrDownToolStripMenuItem,
            this.pyrUpToolStripMenuItem,
            this.pyrMeanShiftFilteringToolStripMenuItem,
            this.scharrToolStripMenuItem,
            this.squareBoxFilterToolStripMenuItem,
            this.spatailGradientToolStripMenuItem});
            this.imageFilteringToolStripMenuItem.Name = "imageFilteringToolStripMenuItem";
            this.imageFilteringToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.imageFilteringToolStripMenuItem.Text = "İmage Filtering";
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            this.smoothingToolStripMenuItem.Click += new System.EventHandler(this.smoothingToolStripMenuItem_Click);
            // 
            // biToolStripMenuItem
            // 
            this.biToolStripMenuItem.Name = "biToolStripMenuItem";
            this.biToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.biToolStripMenuItem.Text = "Bilateral";
            this.biToolStripMenuItem.Click += new System.EventHandler(this.biToolStripMenuItem_Click);
            // 
            // buildPyramidToolStripMenuItem
            // 
            this.buildPyramidToolStripMenuItem.Name = "buildPyramidToolStripMenuItem";
            this.buildPyramidToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.buildPyramidToolStripMenuItem.Text = "Laplacian";
            this.buildPyramidToolStripMenuItem.Click += new System.EventHandler(this.buildPyramidToolStripMenuItem_Click);
            // 
            // filter2DToolStripMenuItem
            // 
            this.filter2DToolStripMenuItem.Name = "filter2DToolStripMenuItem";
            this.filter2DToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.filter2DToolStripMenuItem.Text = "Filter 2D";
            this.filter2DToolStripMenuItem.Click += new System.EventHandler(this.filter2DToolStripMenuItem_Click);
            // 
            // boxFilterToolStripMenuItem
            // 
            this.boxFilterToolStripMenuItem.Name = "boxFilterToolStripMenuItem";
            this.boxFilterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.boxFilterToolStripMenuItem.Text = "Box Filter";
            this.boxFilterToolStripMenuItem.Click += new System.EventHandler(this.boxFilterToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // medianBlurToolStripMenuItem
            // 
            this.medianBlurToolStripMenuItem.Name = "medianBlurToolStripMenuItem";
            this.medianBlurToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.medianBlurToolStripMenuItem.Text = "Median Blur";
            this.medianBlurToolStripMenuItem.Click += new System.EventHandler(this.medianBlurToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.topHatToolStripMenuItem.Text = "Morphological";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // pyrDownToolStripMenuItem
            // 
            this.pyrDownToolStripMenuItem.Name = "pyrDownToolStripMenuItem";
            this.pyrDownToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pyrDownToolStripMenuItem.Text = "Pyr Down";
            this.pyrDownToolStripMenuItem.Click += new System.EventHandler(this.pyrDownToolStripMenuItem_Click);
            // 
            // pyrUpToolStripMenuItem
            // 
            this.pyrUpToolStripMenuItem.Name = "pyrUpToolStripMenuItem";
            this.pyrUpToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pyrUpToolStripMenuItem.Text = "Pyr Up";
            this.pyrUpToolStripMenuItem.Click += new System.EventHandler(this.pyrUpToolStripMenuItem_Click);
            // 
            // pyrMeanShiftFilteringToolStripMenuItem
            // 
            this.pyrMeanShiftFilteringToolStripMenuItem.Name = "pyrMeanShiftFilteringToolStripMenuItem";
            this.pyrMeanShiftFilteringToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pyrMeanShiftFilteringToolStripMenuItem.Text = "Pyr Mean Shift Filtering";
            this.pyrMeanShiftFilteringToolStripMenuItem.Click += new System.EventHandler(this.pyrMeanShiftFilteringToolStripMenuItem_Click);
            // 
            // scharrToolStripMenuItem
            // 
            this.scharrToolStripMenuItem.Name = "scharrToolStripMenuItem";
            this.scharrToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.scharrToolStripMenuItem.Text = "Scharr";
            this.scharrToolStripMenuItem.Click += new System.EventHandler(this.scharrToolStripMenuItem_Click);
            // 
            // squareBoxFilterToolStripMenuItem
            // 
            this.squareBoxFilterToolStripMenuItem.Name = "squareBoxFilterToolStripMenuItem";
            this.squareBoxFilterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.squareBoxFilterToolStripMenuItem.Text = "Square Box Filter";
            this.squareBoxFilterToolStripMenuItem.Click += new System.EventHandler(this.squareBoxFilterToolStripMenuItem_Click);
            // 
            // spatailGradientToolStripMenuItem
            // 
            this.spatailGradientToolStripMenuItem.Name = "spatailGradientToolStripMenuItem";
            this.spatailGradientToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.spatailGradientToolStripMenuItem.Text = "Spatail Gradient";
            this.spatailGradientToolStripMenuItem.Click += new System.EventHandler(this.spatailGradientToolStripMenuItem_Click);
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
            this.pictureBox2.Location = new System.Drawing.Point(396, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.77921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 346);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(65, 340);
            this.treeView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem biToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildPyramidToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem filter2DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem medianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pyrDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyrUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyrMeanShiftFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scharrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareBoxFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spatailGradientToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

