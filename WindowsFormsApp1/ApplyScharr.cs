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
    public partial class ApplyScharr : Form
    {
        Form1 form = null;
        public ApplyScharr(Form1 f)
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
                    int dx;
                    int dy;
                    int.TryParse(tbdX.Text, out dx);
                    int.TryParse(tbdY.Text, out dy);
                    form.ApplyScharr(dx,dy);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
