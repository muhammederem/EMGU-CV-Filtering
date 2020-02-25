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
    public partial class ApplyMorpho : Form
    {
        Form1 form = null;
        public ApplyMorpho(Form1 f)
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
                    Emgu.CV.CvEnum.ElementShape shape = Emgu.CV.CvEnum.ElementShape.Rectangle;
                    if (cbShape.SelectedIndex == 0)
                    {
                         shape = Emgu.CV.CvEnum.ElementShape.Rectangle;

                    }
                   if (cbShape.SelectedIndex == 1)
                    {
                         shape = Emgu.CV.CvEnum.ElementShape.Cross;

                    }
                   if (cbShape.SelectedIndex == 2)
                    {
                         shape = Emgu.CV.CvEnum.ElementShape.Custom;

                    }
                    if (cbShape.SelectedIndex == 3)
                    {
                         shape = Emgu.CV.CvEnum.ElementShape.Ellipse;

                    }

                    Emgu.CV.CvEnum.MorphOp type = Emgu.CV.CvEnum.MorphOp.Open;
                    if (cbType.SelectedIndex == 0)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.Open;

                    }
                    if (cbType.SelectedIndex == 1)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.Open;

                    }
                    if (cbType.SelectedIndex == 2)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.Tophat;

                    }
                    if (cbType.SelectedIndex == 3)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.HitMiss;

                    }
                    if (cbType.SelectedIndex == 4)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.Blackhat;

                    }
                    if (cbType.SelectedIndex == 5)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.Erode;

                    }
                    if (cbType.SelectedIndex == 6)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.Dilate;

                    }
                    if (cbType.SelectedIndex == 7)
                    {
                        type = Emgu.CV.CvEnum.MorphOp.Gradient;

                    }

                    int sizeX;
                    int sizeY;
                    int.TryParse(tbSizex.Text, out sizeX);
                    int.TryParse(tbSizeY.Text, out sizeY);

                    form.ApplyMorpho(shape,sizeX,sizeY,type);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
