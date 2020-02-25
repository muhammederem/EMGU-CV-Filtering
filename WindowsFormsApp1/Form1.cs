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
        Image<Gray, byte> imgGray;
        Image<Gray, byte> imgBinarized;
        Image<Bgr, byte> imgtemp;
        Image<Bgr, byte> imgReset;
        Mat m = new Mat();
        Image<Bgr, float> imgSobel;


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



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                imgtemp = new Image<Bgr, byte>(ofd.FileName);
                imgReset = new Image<Bgr, byte>(ofd.FileName);
                imgGray = new Image<Gray, byte>(ofd.FileName);
                imgSobel = new Image<Bgr, float>(ofd.FileName);
                // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = imgInput.Bitmap;
                pictureBox2.Image = imgInput.Bitmap;


            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = imgReset.Bitmap;
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

        private void sepFilter2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        //***********************************************//
        //FONKSİYONLAI YAZILMIŞ BUTONLAR
        private void buildPyramidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput != null)
                {
                    ApplyLaplacian deg = new ApplyLaplacian(this);
                    deg.Show();
                }
                else
                {
                    MessageBox.Show("Input Image is empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
   
        public void ApplyLaplacian(int apertureSize)
        {
            try
            {
                pictureBox2.Image = imgtemp.Bitmap;
                pictureBox2.Image = imgtemp.Laplace(apertureSize).Bitmap;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput != null)
                {
                    ApplySobel deg = new ApplySobel(this);
                    deg.Show();
                }
                else
                {
                    MessageBox.Show("Input Image is empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ApplySobel(int xOrder,int yOrder,int ApretureSize)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    pictureBox2.Image = imgSobel.Sobel(xOrder,yOrder,ApretureSize ).Bitmap;
                }
                else
                    MessageBox.Show("İmage is empty");

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
                if (imgInput != null)
                {
                    ApplyBoxFilter deg = new ApplyBoxFilter(this);
                    deg.Show();
                }
                else
                {
                    MessageBox.Show("Input Image is empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ApplyBoxFilter(int size)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    CvInvoke.BoxFilter(imgtemp, imgtemp, Emgu.CV.CvEnum.DepthType.Default, new Size(size, size), new Point(-1, -1), true, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = imgtemp.Bitmap;
                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        

        
        private void biToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput != null)
                {
                    ApplyBilateral deg = new ApplyBilateral(this);
                    deg.Show();
                }
                else
                {
                    MessageBox.Show("Input Image is empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void ApplyBilateral(int diametr,double sigmaColor,double sigmaSpace)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    CvInvoke.BilateralFilter(imgtemp, m, diametr, sigmaColor, sigmaSpace, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = m.Bitmap;
                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void medianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput != null)
                {
                    ApplyMedianBlur deg = new ApplyMedianBlur(this);
                    deg.Show();
                }
                else
                {
                    MessageBox.Show("Input Image is empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        } 

        public void ApplyMedianBlur(int kSize)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    CvInvoke.MedianBlur(imgtemp, imgtemp, kSize);
                    pictureBox2.Image = imgtemp.Bitmap;


                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (imgInput != null)
                {
                    ApplyMorpho deg = new ApplyMorpho(this);
                    deg.Show();
                }
                else
                {
                    MessageBox.Show("Input Image is empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
            public void ApplyMorpho(Emgu.CV.CvEnum.ElementShape shape,int SizeX,int SizeY, Emgu.CV.CvEnum.MorphOp type)
        {
            try
            {           
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    Mat kernel = CvInvoke.GetStructuringElement(shape, new Size(SizeX, SizeY), new Point(-1, -1));
                    pictureBox2.Image = imgtemp.MorphologyEx(type, kernel, new Point(-1, 1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0.1)).Bitmap;
                    
                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pyrDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CvInvoke.PyrDown(imgInput, m, Emgu.CV.CvEnum.BorderType.Default);
            pictureBox2.Image = m.Bitmap;
        }

        private void pyrUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CvInvoke.PyrUp(imgInput, m, Emgu.CV.CvEnum.BorderType.Default);
            pictureBox2.Image = m.Bitmap;

        }

        private void spatailGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput != null)
                {
                    ApplySpatial deg = new ApplySpatial(this);
                    deg.Show();
                }
                else
                {
                    MessageBox.Show("Input Image is empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void ApplySpatial(int kSize)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgGray.Bitmap;
                    CvInvoke.SpatialGradient(imgGray, imgGray, imgGray, kSize, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = imgGray.Bitmap;
                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void pyrMeanShiftFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput != null)
            {
                MeanShift deg = new MeanShift(this);
                deg.Show();
            }
            else
            {
                MessageBox.Show("Input Image is empty.");
            }

        }
        public void ApplyMeanShift(double sp,double sr,int maxSize)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    CvInvoke.PyrMeanShiftFiltering(imgtemp, imgtemp, sp, sr, maxSize, new MCvTermCriteria(5, 1));
                    pictureBox2.Image = imgtemp.Bitmap;
                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void scharrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput != null)
            {
                ApplyScharr deg =new ApplyScharr(this);
                deg.Show();
            }
            else
            {
                MessageBox.Show("Input Image is empty.");
            }

        }
        public void ApplyScharr(int dx,int dy)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    CvInvoke.Scharr(imgtemp, imgtemp, Emgu.CV.CvEnum.DepthType.Cv8U, dx, dy, 1.0, 0.0, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = imgtemp.Bitmap;
                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void squareBoxFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput != null)
            {
                SquareBoxFilter deg = new SquareBoxFilter(this);
                deg.Show();
            }
            else
            {
                MessageBox.Show("Input Image is empty.");
            }
        }
        public void ApplySquareBoxFilter(int size)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    CvInvoke.SqrBoxFilter(imgtemp, imgtemp, Emgu.CV.CvEnum.DepthType.Default, new Size(size, size), new Point(-1, -1), true, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = imgtemp.Bitmap;
                }
                else
                    MessageBox.Show("İmage is empty");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput != null)
            {
                Smooth deg = new Smooth(this);
                deg.Show();
            }
            else
            {
                MessageBox.Show("Input Image is empty.");
            }
        }
        public void ApplySmooth(double sigmaX,double sigmaY, int size)
        {
            try
            {
                if (imgtemp != null)
                {
                    pictureBox2.Image = imgtemp.Bitmap;
                    CvInvoke.GaussianBlur(imgtemp, imgtemp, new Size(size, size), sigmaX, sigmaY);
                    pictureBox2.Image = imgtemp.Bitmap;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
      private void filter2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput != null)
            {
                filter2D deg = new filter2D(this);
                deg.Show();
            }
            else
            {
                MessageBox.Show("Input Image is empty.");
            }
        }

        public void ApplyFilter2D(int kernelSize)
        {
            try
            {
                if (imgtemp != null)
                {
                    Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, new Size(kernelSize, kernelSize), new Point(-1, 1));
                    CvInvoke.Filter2D(imgtemp, imgtemp, kernel, new Point(-1, 1), 0.0, Emgu.CV.CvEnum.BorderType.Default);
                    pictureBox2.Image = imgtemp.Bitmap;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}
       