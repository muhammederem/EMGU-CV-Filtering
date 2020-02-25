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
    public partial class ApplyBilateral : Form
    {
        Form1 form = null;
        public ApplyBilateral(Form1 f)
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
                    double sigmas;
                    double sigmac;
                    int.TryParse(tbDiametr.Text, out int diametr);
                    double.TryParse(tbSigmaColor.Text, out sigmac);
                    double.TryParse(tbSigmaSpace.Text, out sigmas);
                    form.ApplyBilateral(diametr, sigmac, sigmas);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
