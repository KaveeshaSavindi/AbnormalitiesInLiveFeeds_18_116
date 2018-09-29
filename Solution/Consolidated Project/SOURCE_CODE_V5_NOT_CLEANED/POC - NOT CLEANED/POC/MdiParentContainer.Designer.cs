namespace POC
{
    partial class MdiParentContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sMTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoGrayAndContrastAdjustmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1372, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem1
            // 
            this.setupToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMTPToolStripMenuItem,
            this.uSERSToolStripMenuItem});
            this.setupToolStripMenuItem1.Name = "setupToolStripMenuItem1";
            this.setupToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem1.Text = "Setup";
            // 
            // sMTPToolStripMenuItem
            // 
            this.sMTPToolStripMenuItem.Name = "sMTPToolStripMenuItem";
            this.sMTPToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sMTPToolStripMenuItem.Text = "SMTP";
            this.sMTPToolStripMenuItem.Click += new System.EventHandler(this.sMTPToolStripMenuItem_Click);
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.uSERSToolStripMenuItem.Text = "USERS";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoGrayAndContrastAdjustmentsToolStripMenuItem,
            this.faceDetectionToolStripMenuItem,
            this.mainFormToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settingsToolStripMenuItem.Text = "Cameras";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // videoGrayAndContrastAdjustmentsToolStripMenuItem
            // 
            this.videoGrayAndContrastAdjustmentsToolStripMenuItem.Name = "videoGrayAndContrastAdjustmentsToolStripMenuItem";
            this.videoGrayAndContrastAdjustmentsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.videoGrayAndContrastAdjustmentsToolStripMenuItem.Text = "Front Camera";
            this.videoGrayAndContrastAdjustmentsToolStripMenuItem.Click += new System.EventHandler(this.videoGrayAndContrastAdjustmentsToolStripMenuItem_Click);
            // 
            // faceDetectionToolStripMenuItem
            // 
            this.faceDetectionToolStripMenuItem.Name = "faceDetectionToolStripMenuItem";
            this.faceDetectionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.faceDetectionToolStripMenuItem.Text = "Side Camera";
            this.faceDetectionToolStripMenuItem.Click += new System.EventHandler(this.faceDetectionToolStripMenuItem_Click);
            // 
            // mainFormToolStripMenuItem
            // 
            this.mainFormToolStripMenuItem.Name = "mainFormToolStripMenuItem";
            this.mainFormToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.mainFormToolStripMenuItem.Text = "MainForm";
            this.mainFormToolStripMenuItem.Click += new System.EventHandler(this.mainFormToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentsToolStripMenuItem,
            this.eventsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.incidentsToolStripMenuItem.Text = "Incidents";
            this.incidentsToolStripMenuItem.Click += new System.EventHandler(this.incidentsToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // MdiParentContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 672);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiParentContainer";
            this.Text = "ATM VIDEO POC PROJECT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoGrayAndContrastAdjustmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sMTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainFormToolStripMenuItem;
    }
}