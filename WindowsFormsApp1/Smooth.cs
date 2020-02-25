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
    public partial class Smooth : Form
    {
        Form1 form = null;
        public Smooth(Form1 F)
        {
            InitializeComponent();
            form = F;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (form != null)
                {
                    int size = 3;
                    double sigmaY = 1;
                    double sigmaX = 1;
                    int.TryParse(tbSize.Text, out size);
                    double.TryParse(tbSigmaX.Text, out sigmaX);
                    double.TryParse(tbSigmaY.Text, out sigmaY);
                    form.ApplySmooth(sigmaX,sigmaY, size);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
