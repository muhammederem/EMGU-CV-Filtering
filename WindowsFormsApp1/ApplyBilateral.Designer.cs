namespace WindowsFormsApp1
{
    partial class ApplyBilateral
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
            this.tbDiametr = new System.Windows.Forms.TextBox();
            this.tbSigmaColor = new System.Windows.Forms.TextBox();
            this.tbSigmaSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDiametr
            // 
            this.tbDiametr.Location = new System.Drawing.Point(110, 27);
            this.tbDiametr.Name = "tbDiametr";
            this.tbDiametr.Size = new System.Drawing.Size(100, 20);
            this.tbDiametr.TabIndex = 0;
            // 
            // tbSigmaColor
            // 
            this.tbSigmaColor.Location = new System.Drawing.Point(110, 75);
            this.tbSigmaColor.Name = "tbSigmaColor";
            this.tbSigmaColor.Size = new System.Drawing.Size(100, 20);
            this.tbSigmaColor.TabIndex = 1;
            // 
            // tbSigmaSpace
            // 
            this.tbSigmaSpace.Location = new System.Drawing.Point(110, 131);
            this.tbSigmaSpace.Name = "tbSigmaSpace";
            this.tbSigmaSpace.Size = new System.Drawing.Size(100, 20);
            this.tbSigmaSpace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diametr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sigma Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sigma Space";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(135, 171);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ApplyBilateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 206);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSigmaSpace);
            this.Controls.Add(this.tbSigmaColor);
            this.Controls.Add(this.tbDiametr);
            this.Name = "ApplyBilateral";
            this.Text = "ApplyBilateral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDiametr;
        private System.Windows.Forms.TextBox tbSigmaColor;
        private System.Windows.Forms.TextBox tbSigmaSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApply;
    }
}