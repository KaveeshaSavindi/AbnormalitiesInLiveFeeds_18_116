using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Cvb;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
namespace POC
{
    public partial class frmSideCamera : Form
    {
        public frmSideCamera()
        {
            InitializeComponent();
            getCamera();
            descriptor.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
            motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            fgDetector = new BackgroundSubtractorMOG2();
        }
        #region Global Variables
        DS ds = new DS();
        DSTableAdapters.INCIDENTSTableAdapter taINCIDENTS = new DSTableAdapters.INCIDENTSTableAdapter();
        DSTableAdapters.EVENTSTableAdapter taEVENT = new DSTableAdapters.EVENTSTableAdapter();
        bool start = false;
        VideoCapture capture;
        Image<Bgr, Byte> img; // image captured
        Image<Gray, Byte> Gray_Frame; // image for processing
        Image<Bgr, Byte> FrameOld; // image for processing Movement Tracking
        Rectangle[] faces;// DETECTED FACES
        CascadeClassifier _face = new CascadeClassifier("./haarcascade_frontalface_default.xml");// HAAR FILE USED
        CascadeClassifier _body = new CascadeClassifier("./haarcascade_fullbody.xml");// HAAR FILE USED
        Rectangle[] _bodies;// DETECTED BODIES
        HOGDescriptor descriptor=new HOGDescriptor();
        Boolean EqualizeHist = false;
        Boolean GammaCorrect = false;
        Boolean GaussianBlure = false;
        Boolean bodyDetection = false;
        Boolean detectMotionAnoramlities = false;
        Boolean wasInFreez = false;
        Boolean freezTriggered = false;
        Boolean TimerStarted = false;
        int freezDelay = 5;
        int freezTime = 0;                         
        FilterInfoCollection CaptureDevice; // Retrieve devices
        DenseHistogram Histo = new DenseHistogram(255, new RangeF(0, 255));
        double valCorrectGamma = 1.9d;
        float f;
        MotionDetector motionDetector;
        IBackgroundSubtractor fgDetector;
        int CAMERAINDEX = 0;
        #endregion
        private void capture_ImageGrabbed(object sender, EventArgs e)
        {            
            try
            {
                
                Mat iMat = new Mat();
                capture.Retrieve(iMat);
                img = iMat.ToImage<Bgr, byte>();
                FrameOld = img.Clone();
                Bitmap imgB = FrameOld.Bitmap;
                Gray_Frame=img.Convert<Gray,Byte>().Clone();
                // When enabled Equalize Hist and GammaCorrect adjust contrast and brithness
                if (EqualizeHist) Gray_Frame._EqualizeHist();// Equalize Histogram
                if (GammaCorrect) Gray_Frame._GammaCorrect(valCorrectGamma);// Correct Gamma
                if (GaussianBlure) CvInvoke.GaussianBlur(Gray_Frame, Gray_Frame, new Size(3, 3), 1);

                grayImg.Image = Gray_Frame;
                faces=_face.DetectMultiScale(Gray_Frame, 1.3, 5,
                                             new System.Drawing.Size(24, 24),
                                             System.Drawing.Size.Empty); /**/
                lblDetectedFaces.BeginInvoke((Action)(()=>{// This is used to update the label of Faces detected count
                    int nbrFaces = faces.Length;
                    lblDetectedFaces.Text = nbrFaces + "";
                }));
                foreach (Rectangle face in faces)
                    {
                        img.Draw(face, new Bgr(System.Drawing.Color.Blue), 2);
                    }
                // Detecting bodies
                if (bodyDetection) {
                    _bodies = _body.DetectMultiScale(Gray_Frame, 1.3, 5,
                                             new System.Drawing.Size(24, 24),
                                             System.Drawing.Size.Empty);
                    foreach (Rectangle body in _bodies)
                        {
                            img.Draw(body, new Bgr(System.Drawing.Color.Red), 2);
                        }
                    lblBodies.BeginInvoke((Action)(()=>{// This is used to update the label of Faces detected count
                        lblBodies.Text = _bodies.Length + "";
                    }));
                }
                //
                
                    captureImageBox.Image = img;
                // ##### Histogram
                    Histo.Clear();
                    Histo.Calculate(new Image<Gray, Byte>[] {Gray_Frame}, true, null);
                    Mat hMat = new Mat();
                    Histo.CopyTo(hMat);
                    myHistogram.BeginInvoke((Action)(()=>{
                        myHistogram.ClearHistogram();
                        myHistogram.AddHistogram("Gray Histogram ", Color.Red, hMat, 256, new float[] { 0, 256 });
                        myHistogram.Refresh();
                    }));
                 //########################     
                    //######## Fram diffrencess   :detectMotionAnoramlities MoveTowards moveTowardsFilter = new MoveTowards();
                    if (detectMotionAnoramlities)
                    {
                        #region Contour
                        VectorOfVectorOfPoint polygon = new VectorOfVectorOfPoint();      // to draw the perimeter

                        Image<Gray, byte> gray = img.Convert<Gray, byte>();               // convert source to gray
                        Image<Gray, byte> thresh = gray.PyrDown().PyrUp();                  // attempt to make edges more distinct?
                        Image<Gray, byte> cannyImg = thresh.Canny(new Gray(10).Intensity, new Gray(50).Intensity);
                        Mat tmpMat = new Mat();
                        Image<Gray, byte> imOut = new Image<Gray, byte>(img.Width, img.Height, new Gray(0));
                        CvInvoke.FindContours(cannyImg, polygon, tmpMat, RetrType.External, ChainApproxMethod.ChainApproxTc89Kcos);
                        CvInvoke.DrawContours(imOut, polygon, -1, new MCvScalar(255, 0, 0), 2);
                        pBoxContours.Image = imOut.Bitmap;
                        #endregion

                        Mat forgroundMask = new Mat();
                        fgDetector.Apply(img, forgroundMask);
                        pBoxBackground.Image = forgroundMask.Bitmap;
                        f=motionDetector.ProcessFrame(imgB);
                        
                        lblDetectedMotions.BeginInvoke((Action)(() =>
                        {// This is used to update the label of Faces detected count
                            lblDetectedMotions.Text = f + "";
                        }));
                        if (f > 0.2f)
                        {
                            txtAlerts.BeginInvoke((Action)(() =>
                            {// This is used to update the label of diff %
                                txtAlerts.Text += "+ Quick Motion detected or more than 2% of fram changed" + DateTime.Now + Environment.NewLine;
                            }));
                            taINCIDENTS.Insert("NA", "+ Quick Motion detected or more than 2% of fram changed", "INCIDENT TYPE 1", DateTime.Now.ToString());
                        }
                        /*
                        
                         * */
                        // Blob Counter
                        CvBlobs blobs = new CvBlobs();
                        
                        blobs.FilterByArea(100, int.MaxValue);
                        BlobCounter blobcounter = new BlobCounter();
                        blobcounter.MinHeight = 100;
                        blobcounter.MaxWidth = 20;
                        blobcounter.ObjectsOrder = ObjectsOrder.Size;
                        blobcounter.ProcessImage(forgroundMask.Bitmap);
                        Rectangle[] rect = blobcounter.GetObjectsRectangles();
                        Graphics g = Graphics.FromImage(imgB);
                        int BlobCPT = 0;
                        if (rect.Length > 0)
                        {
                            Rectangle objec = rect[0];
                            Graphics graphic = Graphics.FromImage(imgB);
                            using (Pen pen = new Pen(Color.Red, 2))
                                foreach (Rectangle rec in rect)
                                {
                                    
                                    if ((rec.Width > 50) && (rec.Height > 50))
                                    {
                                        g.DrawRectangle(pen, rec);
                                        BlobCPT++;
                                    }
                                }
                            {

                            }
                            g.Dispose();
                        }
                        if (f == 0.00f && blobs.Count == 0 && faces.Length==0)
                        {
                            if (!wasInFreez && freezTriggered)
                            {
                                freezTime = 0;
                                wasInFreez = true;
                                // We suppose 0.5% and less as freez
                                txtAlerts.BeginInvoke((Action)(() =>
                                {// This is used to update the label of Faces detected count
                                    txtAlerts.Text += "+Freez detecte : - Time:" + DateTime.Now.ToString() + Environment.NewLine;
                                }));
                                taEVENT.Insert( "+Freez detecte : - Time:", "FREEZ", DateTime.Now.ToString());
                            }
                            if (!wasInFreez && !freezTriggered && !TimerStarted)
                            {
                                TimerStarted = true;
                                freezTimer.Start();
                            }
                        }
                        else if(BlobCPT>0 && f != 0.00f)
                        {
                            if (wasInFreez)// We need to stop the timer and send the notification message
                            {
                                txtAlerts.BeginInvoke((Action)(() =>
                                {// This is used to update the label of Faces detected count
                                    txtAlerts.Text += "+Freez Stoped after : " + freezTime + " Second - Time:" + DateTime.Now.ToString() + Environment.NewLine;
                                }));

                                taEVENT.Insert( "+Freez Stoped after : " + freezTime + " Second", "FREEZ STOP", DateTime.Now.ToString());
                                freezTimer.Stop();
                                TimerStarted = false;
                                wasInFreez = false;
                                freezTriggered = false;
                            }
                            
                        }
                        pBox.Image = imgB;

                    }
                 //#######################
                 Application.DoEvents();// Allow app to run other threads
            }
            catch (Exception E)
            {
               // MessageBox.Show(E.Message);
            }
        }
        private void getCamera()
        {

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);

            }
            comboBox1.SelectedIndex = 0;
        }


        public void SaveSetup()
        {

        }
        #region Buttons And Controls Actions
        #region Auto Gamma and Hist adjustments
        private void cbCoorectGamma_CheckedChanged(object sender, EventArgs e)
        {
            GammaCorrect = !GammaCorrect;
            valCorrectGamma = 1.9d;
            trackBar1.Value = 5;
            lblGammaVal.Text = valCorrectGamma + "";
            if (GammaCorrect)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void cbEqualizeHist_CheckedChanged(object sender, EventArgs e)
        {
            EqualizeHist = !EqualizeHist;
        }
        #endregion
        // START / STOP STREAMING DATA
        private void btnRUNCAM1_Click(object sender, EventArgs e)
        {
            if (start)
            {
                start = false;
                btnRUNCAM1.Text = "START";
                capture.Stop();
                int tmp;
                int.TryParse(txtfreezDelay.Text,out tmp);
                if(tmp==0){
                    freezDelay = 5;
                }else{
                    freezDelay = tmp ;
                }
            }
            else
            {
                start = true;
                if (capture == null)
                {
                    capture = new VideoCapture(0);
                }
                btnRUNCAM1.Text = "STOP";
                capture.ImageGrabbed += capture_ImageGrabbed;// Set a listner for Image Grabbed (This will be updated afterwords)
                capture.Start();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valCorrectGamma = (double) 10.0d/trackBar1.Value;
            lblGammaVal.Text = valCorrectGamma+"";
        }

        private void cbAutoCorrect_CheckedChanged(object sender, EventArgs e)
        {
            valCorrectGamma = 1.9d;
            trackBar1.Value = 5;
            lblGammaVal.Text = valCorrectGamma + "";
        }

        private void cbGaussianBlur_CheckedChanged(object sender, EventArgs e)
        {
            GaussianBlure = !GaussianBlure;
        }
       
        private void cbBodyDetection_CheckedChanged(object sender, EventArgs e)
        {
            bodyDetection = !bodyDetection;
        }

        private void cbDetectMotionAnoramlities_CheckedChanged(object sender, EventArgs e)
        {
            detectMotionAnoramlities = !detectMotionAnoramlities;
        }
        private void freezTimer_Tick(object sender, EventArgs e)
        {
            freezTime += 1;
            //lbltimerElapsed.BeginInvoke((Action)(() =>
            //{

            //    lbltimerElapsed.Text = freezTime + "";
            //}));
            if (freezTime > freezDelay)
            {
                freezTriggered = true;
                //lblFreez.BeginInvoke((Action)(() =>
                //{
                //    lblFreez.Text = "true";
                //}));
            }
            Application.DoEvents();
        }
        #endregion

        private void frmSideCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(capture!=null)
                capture.Dispose();
        }

        private void btnSaveSetup_Click(object sender, EventArgs e)
        {
            taCAMERA.deleteByName("SIDE");
            taCAMERA.Insert(EqualizeHist + "", GammaCorrect + "", GaussianBlure + "", bodyDetection + "", detectMotionAnoramlities + "", "true", freezDelay + "", "20", null, "SIDE");
        }

        DSTableAdapters.CAMERASETUPTableAdapter taCAMERA = new DSTableAdapters.CAMERASETUPTableAdapter();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CAMERAINDEX = comboBox1.SelectedIndex;
        }
       


        

       
    }
}
