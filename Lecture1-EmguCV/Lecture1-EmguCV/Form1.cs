using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using Emgu.CV.CvEnum;

namespace Lecture1_EmguCV
{
    public partial class Form : System.Windows.Forms.Form
    {
        Capture capture = new Capture();
        public bool camera_status = true;

        public Form()
        {
            InitializeComponent();
            System.Windows.Forms.Application.Idle += streaming;
        }
        private void streaming(object sendoer, EventArgs e)
        {
            var img = capture.QueryFrame().ToImage<Bgr, byte>();
            Image<Gray, byte> Gray_Image;
            Gray_Image = img.Convert<Gray, byte>().Clone();
            Main_Screen.Image = Gray_Image.Bitmap;

            //直方圖等化
            Image<Gray, byte> Equalized_Image = new Image<Gray, byte>(Gray_Image.Width, Gray_Image.Height);
            CvInvoke.EqualizeHist(Gray_Image, Equalized_Image);
            HE_Screen.Image = Equalized_Image.Bitmap;

            //Otsu's二值化
            Image<Gray, byte> Binarized_Image = new Image<Gray, byte>(Gray_Image.Width, Gray_Image.Height);
            CvInvoke.Threshold(Gray_Image, Binarized_Image, 0, 255, ThresholdType.Otsu);
            OB_Screen.Image = Binarized_Image.Bitmap;

            //FuzzySet增強
            Image<Gray, byte> Enhanced_Image = new Image<Gray, byte>(Gray_Image.Width, Gray_Image.Height);
            CvInvoke.GaussianBlur(Equalized_Image, Enhanced_Image, new Size(9, 9), 0);
            FE_Screen.Image = Enhanced_Image.Bitmap;

            //Laplacian邊緣檢測
            Image<Gray, byte> Edge_Image = new Image<Gray, byte>(Gray_Image.Width, Gray_Image.Height);
            CvInvoke.Laplacian(Binarized_Image, Edge_Image, DepthType.Cv8U);
            LE_Screen.Image = Edge_Image.Bitmap;

        }

        private void START_Button_Click(object sender, EventArgs e)
        {
            switch (camera_status)
            {
                case true:
                    System.Windows.Forms.Application.Idle -= streaming;
                    START_Button.Text = "START";
                    camera_status = false;
                    break;
                case false:
                    System.Windows.Forms.Application.Idle += streaming;
                    START_Button.Text = "PAUSE";
                    camera_status = true;
                    break;
            }
        }
    }
}
