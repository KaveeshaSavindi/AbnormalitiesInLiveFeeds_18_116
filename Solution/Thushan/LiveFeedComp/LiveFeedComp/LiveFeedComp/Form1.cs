using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.Filters;
using AForge.Imaging.ColorReduction;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;
using AForge.Vision.Motion;


namespace LiveFeedComp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        Graphics g;
        Bitmap video;
        int mode;
        int Red, Green, Blue;
        float f;
        
        bool OnOff = false;
        int countdown = 5;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private MotionDetector motionDetector;
        
       
        

        private void Form1_Load(object sender, EventArgs e)
        {

            motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
           
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);

            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

            mode = 1;
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);

            FinalFrame.Start();

        }
        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            

          /*  f = motionDetector.ProcessFrame(video); */         

            video = (Bitmap)eventArgs.Frame.Clone();
            Bitmap video2 = (Bitmap)eventArgs.Frame.Clone();
            
           
            
            MoveTowards moveTowardsFilter = new MoveTowards();
            moveTowardsFilter.OverlayImage = video;
            Bitmap tmp =  moveTowardsFilter.Apply(video2);
            video2.Dispose();
            video2 = tmp;

            

            FiltersSequence processingFilter = new FiltersSequence();
            processingFilter.Add(new Difference(video2));
            processingFilter.Add(new Threshold(15));
            processingFilter.Add(new Opening());
            processingFilter.Add(new Edges());

           
           
            
            if (OnOff == true)
                
                    {
                        pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
                        g = Graphics.FromImage(video2);
                        g.DrawString(countdown.ToString(), new Font("Arial", 20), new SolidBrush(Color.Red), new PointF(2, 4));
                        g.Dispose();
                    }
                    
                if (mode == 1)
                    {
                        ColorFiltering colorfilter = new ColorFiltering();
                       
                        colorfilter.Red = new IntRange(Red, (int)numericUpDown1Red.Value);
                        colorfilter.Green = new IntRange(Green,(int)numericUpDown2Green.Value);
                        colorfilter.Blue = new IntRange(Blue,(int)numericUpDown3Blue.Value);
                        colorfilter.ApplyInPlace(video2);

                        BlobCounter blobcounter = new BlobCounter();
                    blobcounter.MinHeight = 20;
                    blobcounter.MaxWidth =20;
                    blobcounter.ObjectsOrder = ObjectsOrder.Size;
                    blobcounter.ProcessImage(video2);
                    Rectangle[] rect = blobcounter.GetObjectsRectangles();
                    Graphics g = Graphics.FromImage(video2);
                   /* if (rect.Length>10)
                    {*/
                       /* Rectangle objec = rect[0];*/
                        Graphics graphic = Graphics.FromImage(video2);
                        using (Pen pen = new Pen(Color.Red,1))
                            foreach (Rectangle rec in rect)
                            {
                                g.DrawRectangle(pen, rec );
                                if ((rec.Width > 15) && (rec.Height > 15))
                                { 
                                }
                            }
                        {
                         /*   graphic.DrawRectangle(pen,objec);*/
                        }
                        graphic.Dispose();
                    /* }*/
                    
                        pictureBox2.Image = video2;
                    }
            pictureBox1.Image = video;

           
            }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning==true)
            {
                FinalFrame.Stop();
                

               

            }
        }

       

        private void buttonTrObject_Click(object sender, EventArgs e)
        {
          
        }

        private void liveFeedAutoCapture_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            mode = 1 ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "value: " + f.ToString();
             countdown--;
            if (countdown == 0)
            {
                timer1.Enabled = false;
                OnOff = false;
                pictureBox2.Image = video;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void liveFeedSave_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Save(@"C:\Users\THUSHAN\Documents\Visual Studio 2010\Projects\LiveFeedComp", ImageFormat.Jpeg);
            }
            else MessageBox.Show("No Image to save!!!");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Red = (int)trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Green = (int)trackBar2.Value;
        }

        private void numericUpDown2Green_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Blue = (int)trackBar3.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       
        }

       

        
        
    }

