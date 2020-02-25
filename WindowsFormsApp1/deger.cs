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
    public partial class deger : Form
    {
        Form1 form=null;
        public deger(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        public static string value;

        private void btn_apply_Click(object sender, EventArgs e)
        {

            try
            {
                if (form!=null)
                {
                    int kernel = 3;
                    int.TryParse(tbKernel.Text, out kernel);
                    form.ApplyFilter2D(kernel);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
