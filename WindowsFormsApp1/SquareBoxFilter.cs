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
    public partial class SquareBoxFilter : Form
    {
        Form1 form = null;
        public SquareBoxFilter(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (form != null)
                {
                    int size = 2;
                    int.TryParse(tbSize.Text, out size);
                    form.ApplySquareBoxFilter(size);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
