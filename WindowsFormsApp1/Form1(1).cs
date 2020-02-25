using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Ocl;
using Emgu.CV.Structure;
using Emgu.Util;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> ımgGray;
        Image<Gray, byte> ımgBinarized;
        Mat m = new Mat();
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           

            //string filep = @"C:\Users\muhammet.erem\source\repos\WindowsFormsApp1\WindowsFormsApp1\3.jpg";
            //Image<Bgr, byte> img = new Image<Bgr, byte>(filep);
            //pictureBox1.Image = img.Bitmap;
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat m = new Mat();
            pictureBox2.Image = imgInput.Bitmap;
            CvInvoke.GaussianBlur(imgInput, m, new Size(9, 9), 0, 1);
            

            pictureBox2.Image = m.Bitmap;

            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               // pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = imgInput.Bitmap;
                pictureBox2.Image = imgInput.Bitmap;

            }
        }

        //private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        //{
            
        //    Mat m = new Mat();
        //    CvInvoke.GaussianBlur(imgInput, m, new Size(9, 9), 0, 1);


        //    pictureBox2.Image = m.Bitmap;
        //}

        //private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        //{



        //    pictureBox2.Image = imgInput.Bitmap;
        //}

        private void biToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat m = new Mat();
            CvInvoke.BilateralFilter(imgInput, m, 5, 115.6, 65.1);
            pictureBox2.Image = m.Bitmap;
            imgInput.Bitmap=m.Bitmap;
        }

        private void dİlateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            if (pictureBox1 != null)
            {

                
                pictureBox2.Image = imgInput.Dilate(5).Bitmap;
    
                
            }
            else if (pictureBox2 != null)
            {
               
            }
            
        }

        private void eroseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, new Size(5,5),new Point(-1,1));
                CvInvoke.Erode(imgInput, m, element, new Point(-1, 1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0));
                pictureBox2.Image = m.Bitmap;
                imgInput.Bitmap = m.Bitmap;
                //pictureBox2.Image = imgInput.Erode(3).Bitmap;
                
            }

        }


        private void buildpyramidtoolstripmenuıtem_click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1 != null)
                {
                    Mat m = new Mat();
                    //Pyramid Fİlter Parametrs
                    CvInvoke.Laplacian(imgInput, m, Emgu.CV.CvEnum.DepthType.Cv64F, 3, 1, 0, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image= m.Bitmap;
                   
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void filter2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1 != null)
                {
                    Mat m = new Mat();
                    double delta = 1.0;

                    Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, 1));
                    CvInvoke.Filter2D(imgInput, m, kernel, new Point(),delta, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = m.Bitmap;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void boxFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, 1));
               // CvInvoke.BoxFilter(imgInput, m, Emgu.CV.CvEnum.DepthType.Cv16S);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void morphologicalShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, 1));
              pictureBox2.Image  =imgInput.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Close, kernel, new Point(-1, 1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0)).Bitmap  ;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bluringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                CvInvoke.GaussianBlur(imgInput, m, new Size(5, 5), 8.2, 4.0, Emgu.CV.CvEnum.BorderType.Default);
                pictureBox2.Image = imgInput.Bitmap;
                imgInput.Bitmap = m.Bitmap;
            }
            catch (Exception ea)
            {

                MessageBox.Show(ea.Message);

            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1 != null)
                {
                    CvInvoke.Sobel(imgInput, m, Emgu.CV.CvEnum.DepthType.Cv16S, 1, 0, 7, 1.7, 5.0, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = m.Bitmap;
                    //pictureBox2.Image = imgInput.Sobel(1, 1, 1).Bitmap;
                    //pictureBox2.Image = m.Bitmap;
                    //imgInput.Bitmap = m.Bitmap;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox2!=null)
                {
                    pictureBox2.Image = pictureBox1.Image;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void convertMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void arrowedLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CvInvoke.ArrowedLine(imgInput, new Point(-1, 1), new Point(35, 9), new MCvScalar(0.5), 1, Emgu.CV.CvEnum.LineType.EightConnected, 0, 0.1);
        }
    }
}
