using AForge.Imaging;
using AForge.Vision.Motion;
using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.CV.Structure;
using System;
using System.Data;
using System.Drawing;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
#if !__IOS__
using Emgu.CV.Cuda;
#endif
using Emgu.CV.XFeatures2D;
using System.Diagnostics;
using System.IO;
namespace POC
{
    class cameraSetup
    {

        DS ds = new DS();
        DSTableAdapters.INCIDENTSTableAdapter taINCIDENTS = new DSTableAdapters.INCIDENTSTableAdapter();
        DSTableAdapters.EVENTSTableAdapter taEVENT = new DSTableAdapters.EVENTSTableAdapter();
        DSTableAdapters.CAMERASETUPTableAdapter taCAMERA = new DSTableAdapters.CAMERASETUPTableAdapter();
        public int deviceID;
        public VideoCapture capture;
        public Boolean startCAMERA = false;
        public Image<Bgr, Byte> img; // image captured
        public Image<Gray, Byte> Gray_Frame; // image for processing
        public Image<Bgr, Byte> FrameOld; // image for processing Movement Tracking
        public Rectangle[] faces;// DETECTED FACES
        public Rectangle[] bodies;// DETECTED BODIES
        public Rectangle[] BLOBS;// DETECTED BLOBS
        public HOGDescriptor descriptor = new HOGDescriptor();//CHECKIFREMOVE
        public Boolean EqualizeHist = false;
        public Boolean GammaCorrect = false;
        public Boolean GaussianBlure = false;
        public Boolean bodyDetection = false;
        public Boolean detectMotionAnoramlities = false;
        public Boolean wasInFreez = false;
        public Boolean freezTriggered = false;
        public Boolean TimerStarted = false;
        public Boolean startFACEDETECTION = false;
        public Boolean isSIDECAM = false;
        public Rectangle[] motionZONE = null;
        public Boolean ObjectDETECTION = false;
        public FileInfo[] FILES;
        public int freezDelay = 5;
        public int freezTime = 0;
        public float motionRatio = 0f;
        IBackgroundSubtractor fgDetector;
        public MCvObjectDetection[] SVMbodies;// DETECTED BODIES
        
        
        CascadeClassifier _face = new CascadeClassifier("./haarcascade_frontalface_default.xml");// HAAR FILE USED
        CascadeClassifier _body = new CascadeClassifier("./haarcascade_fullbody.xml");// HAAR FILE USED
        MotionDetector motionDetector;
        public cameraSetup()
        {
            DataTable dt = null;
            motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            if (isSIDECAM)
            {
                 dt= taCAMERA.getByName("SIDE");
            }
            else
            {
                dt = taCAMERA.getByName("ATM");
            }
            if (dt.Rows[0][2].ToString()!= "False") EqualizeHist = true;
            if (dt.Rows[0][3].ToString() != "False") GammaCorrect = true;
            if (dt.Rows[0][4].ToString() != "False") bodyDetection = true;
            if (dt.Rows[0][5].ToString() != "False") detectMotionAnoramlities = true;
            if (dt.Rows[0][6].ToString() != "False") isSIDECAM = true;
            int.TryParse(dt.Rows[0][7].ToString(), out freezDelay);
            int tmp = 0;
            int.TryParse(dt.Rows[0][8].ToString(), out tmp);
            motionRatio = tmp / 100f;
            fgDetector = new BackgroundSubtractorMOG2();
            descriptor.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
            
        }
        public void toGray()
        {
            Gray_Frame = img.Convert<Gray, Byte>().Clone();
        }
        public void getFaces()
        {
            faces = _face.DetectMultiScale(Gray_Frame, 1.3, 5,
                                             new System.Drawing.Size(24, 24),   
                                             System.Drawing.Size.Empty);
            foreach (Rectangle face in faces)
            {
                img.Draw(face, new Bgr(System.Drawing.Color.Blue), 2);
            }
        }
        public int bodiesCount;
        public void getBodies()
        {
            bodiesCount = 0;
            SVMbodies = descriptor.DetectMultiScale(Gray_Frame,scale:1.3, useMeanshiftGrouping: false);
            bodiesCount = SVMbodies.Length;
            foreach (MCvObjectDetection body in SVMbodies)
            {
                img.Draw(body.Rect, new Bgr(System.Drawing.Color.Green), 2);
            }
            
            bodies=_body.DetectMultiScale(Gray_Frame,1.5,5,
                                             new System.Drawing.Size(50, 50),
                                             System.Drawing.Size.Empty);
            foreach (Rectangle body in bodies)
            {
                img.Draw(body, new Bgr(System.Drawing.Color.Purple), 2);
            }
        }
        public void detectMotion()
        {
            if (motionZONE != null)
            {
                motionDetector.MotionZones = motionZONE;
            }
            motionRatio = motionDetector.ProcessFrame(img.Bitmap);
            if (motionRatio > 0.4f)
            {
                taINCIDENTS.Insert("NA", "+ Quick Motion detected or more than 2% of fram changed", "INCIDENT TYPE 1", DateTime.Now.ToString());
                taINCIDENTS.Fill(ds.INCIDENTS);
            }
            // FREEZ DETECTION
            if (!isSIDECAM)
            {
                Mat forgroundMask = new Mat();
                fgDetector.Apply(img, forgroundMask);
                CvBlobs blobs = new CvBlobs();
                blobs.FilterByArea(100, int.MaxValue);
                BlobCounter blobcounter = new BlobCounter();
                blobcounter.MinHeight = 100;
                blobcounter.MaxWidth = 20;
                blobcounter.ObjectsOrder = ObjectsOrder.Size;
                blobcounter.ProcessImage(forgroundMask.Bitmap);
                Rectangle[] rect = blobcounter.GetObjectsRectangles();
                if (motionRatio == 0 && rect.Length == 0)
                {
                    taINCIDENTS.Insert("NA", "+ FREEZ DETECTED IN ATM", "INCIDENT TYPE 3", DateTime.Now.ToString());
                    taINCIDENTS.Fill(ds.INCIDENTS);
                }
            }
            if (isSIDECAM)
            {
                // PROCESS BLOB
                        Mat forgroundMask = new Mat();
                        fgDetector.Apply(img, forgroundMask);
                        CvBlobs blobs = new CvBlobs();                        
                        blobs.FilterByArea(100, int.MaxValue);
                        BlobCounter blobcounter = new BlobCounter();
                        blobcounter.MinHeight = 100;
                        blobcounter.MaxWidth = 20;
                        blobcounter.ObjectsOrder = ObjectsOrder.Size;
                        blobcounter.ProcessImage(forgroundMask.Bitmap);
                        Rectangle[] rect = blobcounter.GetObjectsRectangles();
                        Graphics g = Graphics.FromImage(img.Bitmap);
                        BLOBS = new Rectangle[10];
                        int BlobCPT = 0;
                        if (motionRatio == 0 && rect.Length == 0)
                        {
                            taINCIDENTS.Insert("NA", "+ FREEZ DETECTED IN SIDE CAMERA", "INCIDENT TYPE 3", DateTime.Now.ToString());
                            taINCIDENTS.Fill(ds.INCIDENTS);
                        }
                        if (rect.Length > 0)
                        {
                            Rectangle objec = rect[0];
                            Graphics graphic = Graphics.FromImage(img.Bitmap);
                            using (Pen pen = new Pen(Color.Red, 2))
                                foreach (Rectangle rec in rect)
                                {

                                    if ((rec.Width > 50) && (rec.Height > 100))
                                    {
                                        
                                        BlobCPT++;
                                        if (rec.Height > 200)
                                        {
                                            g.DrawRectangle(pen, rec);
                                            BLOBS[0] = rec;
                                        }
                                        else
                                        {
                                            g.DrawRectangle(new Pen(Color.Black,2), rec);
                                        }
                                    }
                                }
                            {

                            }
                            g.Dispose();
                        }
            }
        }
        public void disposeObjects()
        {
            capture.Stop();
            capture = null;
        }
        public string USINGGPU = "false";
        public void FindMatch(Mat modelImage, Mat observedImage, out long matchTime, out VectorOfKeyPoint modelKeyPoints, out VectorOfKeyPoint observedKeyPoints, VectorOfVectorOfDMatch matches, out Mat mask, out Mat homography)
        {
            int k = 2;
            double uniquenessThreshold = 0.8;
            double hessianThresh = 300;

            Stopwatch watch;
            homography = null;

            modelKeyPoints = new VectorOfKeyPoint();
            observedKeyPoints = new VectorOfKeyPoint();

            #if !__IOS__
            if (CudaInvoke.HasCuda)
            {
                USINGGPU = "true";
                CudaSURF surfCuda = new CudaSURF((float)hessianThresh);
                using (GpuMat gpuModelImage = new GpuMat(modelImage))
                //extract features from the object image
                using (GpuMat gpuModelKeyPoints = surfCuda.DetectKeyPointsRaw(gpuModelImage, null))
                using (GpuMat gpuModelDescriptors = surfCuda.ComputeDescriptorsRaw(gpuModelImage, null, gpuModelKeyPoints))
                using (CudaBFMatcher matcher = new CudaBFMatcher(DistanceType.L2))
                {
                    surfCuda.DownloadKeypoints(gpuModelKeyPoints, modelKeyPoints);
                    watch = Stopwatch.StartNew();

                    // extract features from the observed image
                    using (GpuMat gpuObservedImage = new GpuMat(observedImage))
                    using (GpuMat gpuObservedKeyPoints = surfCuda.DetectKeyPointsRaw(gpuObservedImage, null))
                    using (GpuMat gpuObservedDescriptors = surfCuda.ComputeDescriptorsRaw(gpuObservedImage, null, gpuObservedKeyPoints))
                    //using (GpuMat tmp = new GpuMat())
                    //using (Stream stream = new Stream())
                    {
                        matcher.KnnMatch(gpuObservedDescriptors, gpuModelDescriptors, matches, k);

                        surfCuda.DownloadKeypoints(gpuObservedKeyPoints, observedKeyPoints);

                        mask = new Mat(matches.Size, 1, DepthType.Cv8U, 1);
                        mask.SetTo(new MCvScalar(255));
                        Features2DToolbox.VoteForUniqueness(matches, uniquenessThreshold, mask);

                        int nonZeroCount = CvInvoke.CountNonZero(mask);
                        if (nonZeroCount >= 4)
                        {
                            nonZeroCount = Features2DToolbox.VoteForSizeAndOrientation(modelKeyPoints, observedKeyPoints,
                               matches, mask, 1.5, 20);
                            if (nonZeroCount >= 4)
                                homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(modelKeyPoints,
                                   observedKeyPoints, matches, mask, 2);
                        }
                    }
                    watch.Stop();
                }
            }
            else
            #endif
            {
                //using (UMat uModelImage = modelImage.ToUMat(AccessType.Read))
                //using (UMat uObservedImage = observedImage.ToUMat(AccessType.Read))
                //{
                    SURF surfCPU = new SURF(hessianThresh);
                    //extract features from the object image
                    UMat modelDescriptors = new UMat();
                    surfCPU.DetectAndCompute(modelImage, null, modelKeyPoints, modelDescriptors, false);

                    watch = Stopwatch.StartNew();

                    // extract features from the observed image
                    UMat observedDescriptors = new UMat();
                    surfCPU.DetectAndCompute(observedImage, null, observedKeyPoints, observedDescriptors, false);
                    BFMatcher matcher = new BFMatcher(DistanceType.L2);
                    matcher.Add(modelDescriptors);

                    matcher.KnnMatch(observedDescriptors, matches, k, null);
                    mask = new Mat(matches.Size, 1, DepthType.Cv8U, 1);
                    mask.SetTo(new MCvScalar(255));
                    Features2DToolbox.VoteForUniqueness(matches, uniquenessThreshold, mask);

                    int nonZeroCount = CvInvoke.CountNonZero(mask);
                    if (nonZeroCount >= 4)
                    {
                        nonZeroCount = Features2DToolbox.VoteForSizeAndOrientation(modelKeyPoints, observedKeyPoints,
                           matches, mask, 1.5, 20);
                        if (nonZeroCount >= 4)
                            homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(modelKeyPoints,
                               observedKeyPoints, matches, mask, 2);
                    }

                    watch.Stop();
                //}
            }
            matchTime = watch.ElapsedMilliseconds;
        }
        public  Mat DrawGR(Mat modelImage, Mat observedImage, out long matchTime)
      {
         Mat homography;
         VectorOfKeyPoint modelKeyPoints;
         VectorOfKeyPoint observedKeyPoints;
         using (VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch())
         {
            Mat mask;
            FindMatch(modelImage, observedImage, out matchTime, out modelKeyPoints, out observedKeyPoints, matches,
               out mask, out homography);

            //Draw the matched keypoints
            Mat result = new Mat();

            Features2DToolbox.DrawMatches(modelImage, modelKeyPoints, observedImage, observedKeyPoints,
               matches, result, new MCvScalar(255, 255, 255), new MCvScalar(255, 255, 255), mask);

            #region draw the projected region on the image

            if (homography != null)
            {
               //draw a rectangle along the projected model
               Rectangle rect = new Rectangle(Point.Empty, modelImage.Size);
               PointF[] pts = new PointF[]
               {
                  new PointF(rect.Left, rect.Bottom),
                  new PointF(rect.Right, rect.Bottom),
                  new PointF(rect.Right, rect.Top),
                  new PointF(rect.Left, rect.Top)
               };
               pts = CvInvoke.PerspectiveTransform(pts, homography);

               Point[] points = Array.ConvertAll<PointF, Point>(pts, Point.Round);
               using (VectorOfPoint vp = new VectorOfPoint(points))
               {
                  CvInvoke.Polylines(result, vp, true, new MCvScalar(255, 0, 0, 255), 5);
               }
               
            }

            #endregion

            return result;

         }
      }

    }
}
