using System;
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
    public partial class ApplyLaplacian : Form
    {
        Form1 form = null;
        public ApplyLaplacian(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(tbApertureSize.Text, out int apertureSize);
                form.ApplyLaplacian(apertureSize);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);           }

        }
    }
}
