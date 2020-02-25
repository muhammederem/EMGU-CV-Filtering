﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ApplyMedianBlur : Form
    {
        Form1 form = null;
        public ApplyMedianBlur(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (form != null)
                {
                    int kSize = 3;
                    int.TryParse(tbKSize.Text, out kSize);
                    form.ApplyMedianBlur(kSize);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
