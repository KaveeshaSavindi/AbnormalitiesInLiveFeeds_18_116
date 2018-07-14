using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Runtime.InteropServices;

namespace WpfFaceDetectionTest
{
    public partial class MainWindow : Window
    {

        private Capture capture;
	
       
        private HaarCascade haarCascade;
        DispatcherTimer timer; //To capture the picture every millisecond


		public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            capture = new Capture();
			capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS, 30);
			capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 450);
			capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 370);
			haarCascade = new HaarCascade(@"haarcascade_frontalface_alt_tree.xml");
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Start();
        }

		//Captures the image every millisecond, and then convert it to gray frame
		//After converted, faces will be detected
		//Each detected face will be marked by black rectangle
		void Timer_Tick(object sender, EventArgs e)
        {
            Image<Bgr,Byte> currentFrame = capture.QueryFrame();

            if (currentFrame != null)
            {
                Image<Gray, Byte> grayFrame = currentFrame.Convert<Gray, Byte>();
                    
                var detectedFaces = grayFrame.DetectHaarCascade(haarCascade)[0];

                int counter = 0;
                foreach (var face in detectedFaces)
                {
                    currentFrame.Draw(face.rect, new Bgr(0, double.MaxValue, 0), 3);
                    counter++;
					if (counter > 1)
					{

						MessageBox.Show("More than one face detected!");
					}
				}

				//if (counter == 0)
				//{
				//	MessageBox.Show("No face detected!");
				//}

				image1.Source = ToBitmapSource(currentFrame);
            }
            
        }

		//Converts plain Bitmap class to BitmapSource so WPF can read it as an image and view it on image1

		[DllImport("gdi32")]
        private static extern int DeleteObject(IntPtr o);

        public static BitmapSource ToBitmapSource(IImage image)
        {
            using (System.Drawing.Bitmap source = image.Bitmap)
            {
                IntPtr ptr = source.GetHbitmap(); //obtain the Hbitmap

                BitmapSource bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    ptr,
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());

                DeleteObject(ptr); //release the HBitmap
                return bs;
            }
        }
    }
}
