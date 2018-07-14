namespace LiveFeedComp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.liveFeedSave = new System.Windows.Forms.Button();
            this.buttonTrObject = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.liveFeedAutoCapture = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1Red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3Blue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(58, 12);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Capture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // liveFeedSave
            // 
            this.liveFeedSave.Location = new System.Drawing.Point(469, 13);
            this.liveFeedSave.Name = "liveFeedSave";
            this.liveFeedSave.Size = new System.Drawing.Size(75, 23);
            this.liveFeedSave.TabIndex = 2;
            this.liveFeedSave.Text = "Save";
            this.liveFeedSave.UseVisualStyleBackColor = true;
            this.liveFeedSave.Click += new System.EventHandler(this.liveFeedSave_Click);
            // 
            // buttonTrObject
            // 
            this.buttonTrObject.Location = new System.Drawing.Point(640, 12);
            this.buttonTrObject.Name = "buttonTrObject";
            this.buttonTrObject.Size = new System.Drawing.Size(75, 23);
            this.buttonTrObject.TabIndex = 3;
            this.buttonTrObject.Text = "TrcObject";
            this.buttonTrObject.UseVisualStyleBackColor = true;
            this.buttonTrObject.Click += new System.EventHandler(this.buttonTrObject_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(299, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 239);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(292, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // liveFeedAutoCapture
            // 
            this.liveFeedAutoCapture.Location = new System.Drawing.Point(288, 10);
            this.liveFeedAutoCapture.Name = "liveFeedAutoCapture";
            this.liveFeedAutoCapture.Size = new System.Drawing.Size(75, 23);
            this.liveFeedAutoCapture.TabIndex = 6;
            this.liveFeedAutoCapture.Text = "AutoCapture";
            this.liveFeedAutoCapture.UseVisualStyleBackColor = true;
            this.liveFeedAutoCapture.Click += new System.EventHandler(this.liveFeedAutoCapture_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(883, 68);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 104);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(934, 68);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 104);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(985, 68);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 104);
            this.trackBar3.TabIndex = 9;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // numericUpDown1Red
            // 
            this.numericUpDown1Red.Location = new System.Drawing.Point(895, 200);
            this.numericUpDown1Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1Red.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1Red.Name = "numericUpDown1Red";
            this.numericUpDown1Red.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1Red.TabIndex = 10;
            this.numericUpDown1Red.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown2Green
            // 
            this.numericUpDown2Green.Location = new System.Drawing.Point(895, 235);
            this.numericUpDown2Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2Green.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2Green.Name = "numericUpDown2Green";
            this.numericUpDown2Green.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2Green.TabIndex = 11;
            this.numericUpDown2Green.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2Green.ValueChanged += new System.EventHandler(this.numericUpDown2Green_ValueChanged);
            // 
            // numericUpDown3Blue
            // 
            this.numericUpDown3Blue.Location = new System.Drawing.Point(895, 273);
            this.numericUpDown3Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3Blue.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown3Blue.Name = "numericUpDown3Blue";
            this.numericUpDown3Blue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3Blue.TabIndex = 12;
            this.numericUpDown3Blue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Value:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown3Blue);
            this.Controls.Add(this.numericUpDown2Green);
            this.Controls.Add(this.numericUpDown1Red);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.liveFeedAutoCapture);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonTrObject);
            this.Controls.Add(this.liveFeedSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonStart);
            this.Name = "Form1";
            this.Text = "LiveFeed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button liveFeedSave;
        private System.Windows.Forms.Button buttonTrObject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button liveFeedAutoCapture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.NumericUpDown numericUpDown1Red;
        private System.Windows.Forms.NumericUpDown numericUpDown2Green;
        private System.Windows.Forms.NumericUpDown numericUpDown3Blue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

