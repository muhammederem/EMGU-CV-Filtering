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
    public partial class MeanShift : Form
    {
        Form1 form = null;
        public MeanShift(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

            try
            {
                if (form != null)
                {
                    double sp;
                    double sr;
                    int maxSize;
                    double.TryParse(tbSp.Text, out sp);
                    double.TryParse(tbSr.Text, out sr);
                    int.TryParse(tbMaxSize.Text, out maxSize);
                    form.ApplyMeanShift(sp, sr, maxSize);

                }
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
