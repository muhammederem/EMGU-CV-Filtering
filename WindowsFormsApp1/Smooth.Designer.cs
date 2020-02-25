namespace WindowsFormsApp1
{
    partial class Smooth
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
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbSigmaX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbSigmaY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(120, 6);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 20);
            this.tbSize.TabIndex = 0;
            // 
            // tbSigmaX
            // 
            this.tbSigmaX.Location = new System.Drawing.Point(120, 37);
            this.tbSigmaX.Name = "tbSigmaX";
            this.tbSigmaX.Size = new System.Drawing.Size(100, 20);
            this.tbSigmaX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sigma X";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(145, 102);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // tbSigmaY
            // 
            this.tbSigmaY.Location = new System.Drawing.Point(120, 72);
            this.tbSigmaY.Name = "tbSigmaY";
            this.tbSigmaY.Size = new System.Drawing.Size(100, 20);
            this.tbSigmaY.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sigma Y";
            // 
            // Smooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 137);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSigmaY);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSigmaX);
            this.Controls.Add(this.tbSize);
            this.Name = "Smooth";
            this.Text = "Smooth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbSigmaX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbSigmaY;
        private System.Windows.Forms.Label label3;
    }
}