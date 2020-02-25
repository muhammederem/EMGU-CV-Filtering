namespace WindowsFormsApp1
{
    partial class deger
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
            this.tbKernel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbKernel
            // 
            this.tbKernel.Location = new System.Drawing.Point(128, 9);
            this.tbKernel.Name = "tbKernel";
            this.tbKernel.Size = new System.Drawing.Size(104, 20);
            this.tbKernel.TabIndex = 0;
            this.tbKernel.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Derece";
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(128, 35);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(62, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Uygula";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // deger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 83);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKernel);
            this.Name = "deger";
            this.Text = "deger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKernel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_apply;
    }
}