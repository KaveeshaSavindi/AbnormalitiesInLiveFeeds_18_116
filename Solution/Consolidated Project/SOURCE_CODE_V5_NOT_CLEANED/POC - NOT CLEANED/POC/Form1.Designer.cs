namespace POC
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.btnRUNCAM1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grayImg = new Emgu.CV.UI.ImageBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxBackground = new System.Windows.Forms.PictureBox();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.pBoxContours = new System.Windows.Forms.PictureBox();
            this.myHistogram = new Emgu.CV.UI.HistogramBox();
            this.txtAlerts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetectedMotions = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfreezDelay = new System.Windows.Forms.MaskedTextBox();
            this.cbDetectMotionAnoramlities = new System.Windows.Forms.CheckBox();
            this.cbBodyDetection = new System.Windows.Forms.CheckBox();
            this.cbGaussianBlur = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBodies = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGammaVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAutoCorrect = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cbCoorectGamma = new System.Windows.Forms.CheckBox();
            this.cbEqualizeHist = new System.Windows.Forms.CheckBox();
            this.lblMotions = new System.Windows.Forms.Label();
            this.lblDetectedFaces = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.freezTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxContours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // captureImageBox
            // 
            this.captureImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureImageBox.Location = new System.Drawing.Point(0, 0);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(581, 489);
            this.captureImageBox.TabIndex = 2;
            this.captureImageBox.TabStop = false;
            // 
            // btnRUNCAM1
            // 
            this.btnRUNCAM1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUNCAM1.Location = new System.Drawing.Point(306, 37);
            this.btnRUNCAM1.Name = "btnRUNCAM1";
            this.btnRUNCAM1.Size = new System.Drawing.Size(75, 23);
            this.btnRUNCAM1.TabIndex = 3;
            this.btnRUNCAM1.Text = "Start";
            this.btnRUNCAM1.UseVisualStyleBackColor = true;
            this.btnRUNCAM1.Click += new System.EventHandler(this.btnRUNCAM1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1844, 1026);
            this.splitContainer1.SplitterDistance = 581;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grayImg);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.captureImageBox);
            this.splitContainer2.Size = new System.Drawing.Size(581, 1026);
            this.splitContainer2.SplitterDistance = 533;
            this.splitContainer2.TabIndex = 0;
            // 
            // grayImg
            // 
            this.grayImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayImg.Location = new System.Drawing.Point(0, 0);
            this.grayImg.Name = "grayImg";
            this.grayImg.Size = new System.Drawing.Size(581, 533);
            this.grayImg.TabIndex = 3;
            this.grayImg.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.pBoxContours);
            this.splitContainer3.Panel2.Controls.Add(this.myHistogram);
            this.splitContainer3.Panel2.Controls.Add(this.txtAlerts);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.lblDetectedMotions);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(1259, 1026);
            this.splitContainer3.SplitterDistance = 419;
            this.splitContainer3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pBoxBackground);
            this.panel1.Controls.Add(this.pBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 1026);
            this.panel1.TabIndex = 8;
            // 
            // pBoxBackground
            // 
            this.pBoxBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBoxBackground.Location = new System.Drawing.Point(0, 436);
            this.pBoxBackground.Name = "pBoxBackground";
            this.pBoxBackground.Size = new System.Drawing.Size(419, 590);
            this.pBoxBackground.TabIndex = 4;
            this.pBoxBackground.TabStop = false;
            // 
            // pBox
            // 
            this.pBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBox.Location = new System.Drawing.Point(0, 0);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(419, 436);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            // 
            // pBoxContours
            // 
            this.pBoxContours.Location = new System.Drawing.Point(454, 156);
            this.pBoxContours.Name = "pBoxContours";
            this.pBoxContours.Size = new System.Drawing.Size(370, 377);
            this.pBoxContours.TabIndex = 8;
            this.pBoxContours.TabStop = false;
            // 
            // myHistogram
            // 
            this.myHistogram.Location = new System.Drawing.Point(10, 400);
            this.myHistogram.Name = "myHistogram";
            this.myHistogram.Size = new System.Drawing.Size(433, 367);
            this.myHistogram.TabIndex = 7;
            // 
            // txtAlerts
            // 
            this.txtAlerts.Location = new System.Drawing.Point(10, 809);
            this.txtAlerts.Multiline = true;
            this.txtAlerts.Name = "txtAlerts";
            this.txtAlerts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlerts.Size = new System.Drawing.Size(381, 205);
            this.txtAlerts.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 789);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detected Motions :";
            // 
            // lblDetectedMotions
            // 
            this.lblDetectedMotions.AutoSize = true;
            this.lblDetectedMotions.Location = new System.Drawing.Point(111, 789);
            this.lblDetectedMotions.Name = "lblDetectedMotions";
            this.lblDetectedMotions.Size = new System.Drawing.Size(0, 17);
            this.lblDetectedMotions.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtfreezDelay);
            this.groupBox1.Controls.Add(this.cbDetectMotionAnoramlities);
            this.groupBox1.Controls.Add(this.cbBodyDetection);
            this.groupBox1.Controls.Add(this.cbGaussianBlur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBodies);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbCoorectGamma);
            this.groupBox1.Controls.Add(this.cbEqualizeHist);
            this.groupBox1.Controls.Add(this.lblMotions);
            this.groupBox1.Controls.Add(this.lblDetectedFaces);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnRUNCAM1);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 393);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Stream 1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(334, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save setup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Delay in Seconds befor Freez Alert";
            // 
            // txtfreezDelay
            // 
            this.txtfreezDelay.Location = new System.Drawing.Point(217, 156);
            this.txtfreezDelay.Mask = "0000";
            this.txtfreezDelay.Name = "txtfreezDelay";
            this.txtfreezDelay.Size = new System.Drawing.Size(100, 23);
            this.txtfreezDelay.TabIndex = 17;
            this.txtfreezDelay.Text = "5";
            // 
            // cbDetectMotionAnoramlities
            // 
            this.cbDetectMotionAnoramlities.AutoSize = true;
            this.cbDetectMotionAnoramlities.Location = new System.Drawing.Point(206, 116);
            this.cbDetectMotionAnoramlities.Name = "cbDetectMotionAnoramlities";
            this.cbDetectMotionAnoramlities.Size = new System.Drawing.Size(98, 21);
            this.cbDetectMotionAnoramlities.TabIndex = 16;
            this.cbDetectMotionAnoramlities.Text = "Detect Motions";
            this.cbDetectMotionAnoramlities.UseVisualStyleBackColor = true;
            this.cbDetectMotionAnoramlities.CheckedChanged += new System.EventHandler(this.cbDetectMotionAnoramlities_CheckedChanged);
            // 
            // cbBodyDetection
            // 
            this.cbBodyDetection.AutoSize = true;
            this.cbBodyDetection.Location = new System.Drawing.Point(36, 116);
            this.cbBodyDetection.Name = "cbBodyDetection";
            this.cbBodyDetection.Size = new System.Drawing.Size(100, 21);
            this.cbBodyDetection.TabIndex = 15;
            this.cbBodyDetection.Text = "Body detection";
            this.cbBodyDetection.UseVisualStyleBackColor = true;
            this.cbBodyDetection.CheckedChanged += new System.EventHandler(this.cbBodyDetection_CheckedChanged);
            // 
            // cbGaussianBlur
            // 
            this.cbGaussianBlur.AutoSize = true;
            this.cbGaussianBlur.Location = new System.Drawing.Point(32, 213);
            this.cbGaussianBlur.Name = "cbGaussianBlur";
            this.cbGaussianBlur.Size = new System.Drawing.Size(96, 21);
            this.cbGaussianBlur.TabIndex = 14;
            this.cbGaussianBlur.Text = "Smooth Image";
            this.cbGaussianBlur.UseVisualStyleBackColor = true;
            this.cbGaussianBlur.CheckedChanged += new System.EventHandler(this.cbGaussianBlur_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Detected Bodies :";
            // 
            // lblBodies
            // 
            this.lblBodies.AutoSize = true;
            this.lblBodies.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodies.Location = new System.Drawing.Point(307, 77);
            this.lblBodies.Name = "lblBodies";
            this.lblBodies.Size = new System.Drawing.Size(36, 17);
            this.lblBodies.TabIndex = 12;
            this.lblBodies.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGammaVal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbAutoCorrect);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(6, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 126);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adjust Brithness  and Contrast";
            // 
            // lblGammaVal
            // 
            this.lblGammaVal.AutoSize = true;
            this.lblGammaVal.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGammaVal.Location = new System.Drawing.Point(139, 83);
            this.lblGammaVal.Name = "lblGammaVal";
            this.lblGammaVal.Size = new System.Drawing.Size(36, 17);
            this.lblGammaVal.TabIndex = 13;
            this.lblGammaVal.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Gamma val :";
            // 
            // cbAutoCorrect
            // 
            this.cbAutoCorrect.AutoSize = true;
            this.cbAutoCorrect.Location = new System.Drawing.Point(260, 83);
            this.cbAutoCorrect.Name = "cbAutoCorrect";
            this.cbAutoCorrect.Size = new System.Drawing.Size(89, 21);
            this.cbAutoCorrect.TabIndex = 11;
            this.cbAutoCorrect.Text = "Auto Correct";
            this.cbAutoCorrect.UseVisualStyleBackColor = true;
            this.cbAutoCorrect.CheckedChanged += new System.EventHandler(this.cbAutoCorrect_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(26, 32);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(397, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbCoorectGamma
            // 
            this.cbCoorectGamma.AutoSize = true;
            this.cbCoorectGamma.Location = new System.Drawing.Point(306, 213);
            this.cbCoorectGamma.Name = "cbCoorectGamma";
            this.cbCoorectGamma.Size = new System.Drawing.Size(103, 21);
            this.cbCoorectGamma.TabIndex = 10;
            this.cbCoorectGamma.Text = "Correct Gamma";
            this.cbCoorectGamma.UseVisualStyleBackColor = true;
            this.cbCoorectGamma.CheckedChanged += new System.EventHandler(this.cbCoorectGamma_CheckedChanged);
            // 
            // cbEqualizeHist
            // 
            this.cbEqualizeHist.AutoSize = true;
            this.cbEqualizeHist.Location = new System.Drawing.Point(177, 213);
            this.cbEqualizeHist.Name = "cbEqualizeHist";
            this.cbEqualizeHist.Size = new System.Drawing.Size(87, 21);
            this.cbEqualizeHist.TabIndex = 9;
            this.cbEqualizeHist.Text = "Equalize Hist";
            this.cbEqualizeHist.UseVisualStyleBackColor = true;
            this.cbEqualizeHist.CheckedChanged += new System.EventHandler(this.cbEqualizeHist_CheckedChanged);
            // 
            // lblMotions
            // 
            this.lblMotions.AutoSize = true;
            this.lblMotions.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotions.Location = new System.Drawing.Point(33, 77);
            this.lblMotions.Name = "lblMotions";
            this.lblMotions.Size = new System.Drawing.Size(88, 17);
            this.lblMotions.TabIndex = 6;
            this.lblMotions.Text = "Detected Faces :";
            // 
            // lblDetectedFaces
            // 
            this.lblDetectedFaces.AutoSize = true;
            this.lblDetectedFaces.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetectedFaces.Location = new System.Drawing.Point(137, 77);
            this.lblDetectedFaces.Name = "lblDetectedFaces";
            this.lblDetectedFaces.Size = new System.Drawing.Size(36, 17);
            this.lblDetectedFaces.TabIndex = 4;
            this.lblDetectedFaces.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // freezTimer
            // 
            this.freezTimer.Interval = 1000;
            this.freezTimer.Tick += new System.EventHandler(this.freezTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 1026);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Side Video Stream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grayImg)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxContours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureImageBox;
        private System.Windows.Forms.Button btnRUNCAM1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Emgu.CV.UI.ImageBox grayImg;
        private System.Windows.Forms.Label lblDetectedFaces;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMotions;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox cbCoorectGamma;
        private System.Windows.Forms.CheckBox cbEqualizeHist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbAutoCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGammaVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBodies;
        private System.Windows.Forms.CheckBox cbGaussianBlur;
        private System.Windows.Forms.CheckBox cbBodyDetection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDetectMotionAnoramlities;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetectedMotions;
        private System.Windows.Forms.TextBox txtAlerts;
        private System.Windows.Forms.Timer freezTimer;
        private System.Windows.Forms.PictureBox pBoxBackground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtfreezDelay;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Emgu.CV.UI.HistogramBox myHistogram;
        private System.Windows.Forms.PictureBox pBoxContours;
        private System.Windows.Forms.Button button1;


    }
}

