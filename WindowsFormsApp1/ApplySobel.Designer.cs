namespace WindowsFormsApp1
{
    partial class ApplySobel
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
            this.tbXorder = new System.Windows.Forms.TextBox();
            this.tbYorder = new System.Windows.Forms.TextBox();
            this.tbApertureSize = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbXorder
            // 
            this.tbXorder.Location = new System.Drawing.Point(145, 37);
            this.tbXorder.Name = "tbXorder";
            this.tbXorder.Size = new System.Drawing.Size(100, 20);
            this.tbXorder.TabIndex = 0;
            // 
            // tbYorder
            // 
            this.tbYorder.Location = new System.Drawing.Point(145, 82);
            this.tbYorder.Name = "tbYorder";
            this.tbYorder.Size = new System.Drawing.Size(100, 20);
            this.tbYorder.TabIndex = 1;
            // 
            // tbApertureSize
            // 
            this.tbApertureSize.Location = new System.Drawing.Point(145, 126);
            this.tbApertureSize.Name = "tbApertureSize";
            this.tbApertureSize.Size = new System.Drawing.Size(100, 20);
            this.tbApertureSize.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(105, 172);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apreture Size";
            // 
            // ApplySobel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbApertureSize);
            this.Controls.Add(this.tbYorder);
            this.Controls.Add(this.tbXorder);
            this.Name = "ApplySobel";
            this.Text = "ApplySobel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbXorder;
        private System.Windows.Forms.TextBox tbYorder;
        private System.Windows.Forms.TextBox tbApertureSize;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}