using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
#if !__IOS__
using Emgu.CV.Cuda;
#endif
using Emgu.CV.XFeatures2D;
using System.IO;
namespace POC
{
    public partial class frmMAINFORM : Form
    {
        #region Global Variables

        VideoCapture SIDEcapture;
        FilterInfoCollection CaptureDevice;
        Boolean startSIDECAMERA = false; 
        DS ds = new DS();
        DSTableAdapters.INCIDENTSTableAdapter taINCIDENTS = new DSTableAdapters.INCIDENTSTableAdapter();
        DSTableAdapters.EVENTSTableAdapter taEVENT = new DSTableAdapters.EVENTSTableAdapter();
        CascadeClassifier _face = new CascadeClassifier("./haarcascade_frontalface_default.xml");// HAAR FILE USED
        int ATMCAMINDEX = 0;
        int SIDECAMERAINDEX = 0;
        #endregion
        #region ATMCAPTURE SETUP
        cameraSetup ATMSETUP = new cameraSetup();
        cameraSetup SIDECAMERA = new cameraSetup();
        #endregion
        public frmMAINFORM()
        {
            InitializeComponent();
            getCamera();
            ATMSETUP.isSIDECAM = false;
            SIDECAMERA.isSIDECAM = true;
        }
        private void getCamera()
        {

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmbBOXCAMS1.Items.Add(Device.Name);
                cmbBOXCAMS2.Items.Add(Device.Name);

            }
            //cmbBOXCAMS1.SelectedIndex = 0;
            //cmbBOXCAMS2.SelectedIndex = 0;
        }
        private void getATMCAMERASETUP()
        {

        }
        private void btnRUNCAM1_Click(object sender, EventArgs e)
        {
            if (ATMSETUP.startCAMERA)
            {
                ATMSETUP.startCAMERA = false;
                btnRUNCAM1.Text = "START";
                ATMSETUP.capture.Stop();
                ATMSETUP.capture.Dispose();
                ATMSETUP.capture = null;
                int tmp;
                // getATMCAMERASETUP  || URGENT
                /*if (tmp == 0)
                {
                    freezDelayATM = 5;
                }
                else
                {
                    freezDelayATM = tmp;
                }*/
            }
            else
            {
                ATMSETUP.startCAMERA = true;
                if (ATMSETUP.capture == null)
                {
                    ATMSETUP.capture = new VideoCapture(ATMCAMINDEX);
                    MessageBox.Show("ATM CAMERA INDEX " + ATMCAMINDEX);
                }
                btnRUNCAM1.Text = "STOP";
                ATMSETUP.capture.ImageGrabbed += ATMcapture_IMAGE_GRABED;// Set a listner for Image Grabbed (This will be updated afterwords)
                ATMSETUP.capture.Start();
            }
        }

        private void ATMcapture_IMAGE_GRABED(object sender, EventArgs e)
        {
            try { 
                //throw new NotImplementedException();
                Mat iMat = new Mat();
                ATMSETUP.capture.Retrieve(iMat);
                ATMSETUP.img= iMat.ToImage<Bgr, byte>();
                #region FaceDetection
                //ATMSETUP.startFACEDETECTION = true; // FOR TESTS
                ATMSETUP.toGray();
                if (ATMSETUP.startFACEDETECTION)
                {
                    ATMSETUP.getFaces();
                    lblATMDetectedFaces.BeginInvoke((Action)(()=>{// This is used to update the label of Faces detected count
                        int nbrFaces = 0;
                        if (ATMSETUP.faces != null)
                            nbrFaces = ATMSETUP.faces.Length;

                        if (nbrFaces > 1)
                        {
                            taINCIDENTS.Insert("NA", "+ Two or more Faces detected", "INCIDENT TYPE 2", DateTime.Now.ToString());
                        }
                        lblATMDetectedFaces.Text = nbrFaces + "";
                    }));
                }
                #endregion
                #region Detect Abnormal Acitvities
                //ATMSETUP.detectMotionAnoramlities = true;// FOR TESTS
                if (ATMSETUP.detectMotionAnoramlities)
                {
                    ATMSETUP.detectMotion();
                }
                #endregion
                imgBOXATM.Image = ATMSETUP.Gray_Frame;
                Application.DoEvents();
            }
            catch (Exception E)
            {
                // Avoid Dispose Errors
            }
        }

        private void cmbBOXCAMS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ATMCAMINDEX = cmbBOXCAMS1.SelectedIndex;
        }


        private void frmMAINFORM_Load(object sender, EventArgs e)
        {
            this.taEVENTS1.Fill(this.dS1.EVENTS);
            this.taINCIDENTS1.Fill(this.dS1.INCIDENTS);
            timerTICTAC.Start();
        }

        private void timerTICTAC_Tick(object sender, EventArgs e)
        {
            this.taEVENTS1.Fill(this.dS1.EVENTS);
            this.taINCIDENTS1.Fill(this.dS1.INCIDENTS);
        }

        private void frmMAINFORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ATMSETUP!=null && ATMSETUP.capture != null)
            { 
                ATMSETUP.capture.Stop();
                ATMSETUP.capture.Dispose();
            }
            //ATMSETUP = null;
        }

        private void btnRUNCAM2_Click(object sender, EventArgs e)
        {

            if (SIDECAMERA.startCAMERA)
            {
                SIDECAMERA.startCAMERA = false;
                btnRUNCAM2.Text = "START";
                SIDECAMERA.capture.Stop();
                SIDECAMERA.capture.Dispose();
                SIDECAMERA.capture = null;
                int tmp;
                // getATMCAMERASETUP  || URGENT
                /*if (tmp == 0)
                {
                    freezDelayATM = 5;
                }
                else
                {
                    freezDelayATM = tmp;
                }*/
            }
            else
            {
                SIDECAMERA.startCAMERA = true;
                if (SIDECAMERA.capture == null)
                {
                    SIDECAMERA.capture = new VideoCapture(SIDECAMERAINDEX);
                    MessageBox.Show("SIDE CAMERA INDEX " + SIDECAMERAINDEX);
                    SIDECAMERA.isSIDECAM = true;
                }
                btnRUNCAM2.Text = "STOP";
                SIDECAMERA.capture.ImageGrabbed += SIDEcapture_IMAGE_GRABED;// Set a listner for Image Grabbed (This will be updated afterwords)
                SIDECAMERA.capture.Start();
            }
        }

        private void SIDEcapture_IMAGE_GRABED(object sender, EventArgs e)
        {
            try
            {
                //throw new NotImplementedException();
                Mat iMat = new Mat();
                SIDECAMERA.capture.Retrieve(iMat);
                SIDECAMERA.img = iMat.ToImage<Bgr, byte>();
                #region FaceDetection
                //SIDECAMERA.startFACEDETECTION = true; // FOR TESTS
                SIDECAMERA.toGray();
                SIDECAMERA.getFaces();
                SIDECAMERA.getBodies();
                lblSIDEDETECTEDFACES.BeginInvoke((Action)(() =>
                {// This is used to update the label of Faces detected count
                    int nbrFaces=0;
                    if(SIDECAMERA.faces!=null)
                        nbrFaces = SIDECAMERA.faces.Length;
                    lblSIDEDETECTEDFACES.Text = nbrFaces + "";
                }));
                lblSIDEDETECTEDBODIES.BeginInvoke((Action)(() =>
                {// This is used to update the label of Faces detected count
                    int nbrBodies = 0;
                    if (SIDECAMERA.bodies != null)
                        nbrBodies = SIDECAMERA.bodies.Length;
                    lblSIDEDETECTEDBODIES.Text = nbrBodies + "";
                    if (SIDECAMERA.SVMbodies != null) { 
                        nbrBodies = SIDECAMERA.bodiesCount;
                    }
                    if(nbrBodies!=0)
                        MessageBox.Show("DETECTED BODY");

                    lblSIDEDETECTEDBODIES.Text += "/"+nbrBodies;
                }));
                #endregion
                #region Detect Abnormal Acitvities
                SIDECAMERA.detectMotionAnoramlities = true;// FOR TESTS
                if (SIDECAMERA.detectMotionAnoramlities)
                {
                    SIDECAMERA.detectMotion();
                }
                if (SIDECAMERA.BLOBS!=null && SIDECAMERA.BLOBS[0]!=null)
                {
                    ATMSETUP.detectMotionAnoramlities = true;
                    ATMSETUP.startFACEDETECTION = true;
                }
                else
                {
                    ATMSETUP.detectMotionAnoramlities = false ;
                    ATMSETUP.startFACEDETECTION = false;
                }
                // m;
                if (SIDECAMERA.ObjectDETECTION)
                {
                    long matches = 0;
                    DirectoryInfo D = new DirectoryInfo("./PICS");
                    FileInfo[] FILES = D.GetFiles();
                    foreach (FileInfo f in FILES) { 
                        Mat m= SIDECAMERA.DrawGR(iMat, new Mat(f.FullName, ImreadModes.Color),out matches);
                        lblGPU.BeginInvoke((Action)(() =>
                        {// This is used to update the label of Faces detected count
                            lblGPU.Text = "USING GPU= " + SIDECAMERA.USINGGPU;
                        }));
                        imgBOXSIDE.Image = m;
                    }
                    
                }
                #endregion
                //imgBOXSIDE.Image = SIDECAMERA.img;
            }
            catch (Exception E)
            {
                // Avoid Dispose Errors
                //MessageBox.Show(E.Message);
            }
        }

        private void cmbBOXCAMS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SIDECAMERAINDEX = cmbBOXCAMS2.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIDECAMERA.ObjectDETECTION = !SIDECAMERA.ObjectDETECTION;
            if (SIDECAMERA.ObjectDETECTION)
            {
                btnObjectDetection.Text = "Stop Object Detection";
            }
            else
            {
                btnObjectDetection.Text = "Start Object Detection";
            }
        }
    }
}
