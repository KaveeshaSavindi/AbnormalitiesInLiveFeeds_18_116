namespace POC
{
    partial class frmMAINFORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.imgBOXATM = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblATMDetectedFaces = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBOXCAMS1 = new System.Windows.Forms.ComboBox();
            this.btnRUNCAM1 = new System.Windows.Forms.Button();
            this.imgBOXSIDE = new Emgu.CV.UI.ImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGPU = new System.Windows.Forms.Label();
            this.btnObjectDetection = new System.Windows.Forms.Button();
            this.lblSIDEDETECTEDBODIES = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSIDEDETECTEDFACES = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBOXCAMS2 = new System.Windows.Forms.ComboBox();
            this.btnRUNCAM2 = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EVENTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EVENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WHEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerTICTAC = new System.Windows.Forms.Timer(this.components);
            this.iNCIDENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNCIDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsINCIDENTS = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new POC.DS();
            this.eVENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wHENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEVENTS = new System.Windows.Forms.BindingSource(this.components);
            this.taINCIDENTS1 = new POC.DSTableAdapters.INCIDENTSTableAdapter();
            this.taEVENTS1 = new POC.DSTableAdapters.EVENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBOXATM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBOXSIDE)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsINCIDENTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEVENTS)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1558, 861);
            this.splitContainer1.SplitterDistance = 519;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.imgBOXATM);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.imgBOXSIDE);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(1558, 519);
            this.splitContainer2.SplitterDistance = 799;
            this.splitContainer2.TabIndex = 0;
            // 
            // imgBOXATM
            // 
            this.imgBOXATM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBOXATM.Location = new System.Drawing.Point(0, 100);
            this.imgBOXATM.Name = "imgBOXATM";
            this.imgBOXATM.Size = new System.Drawing.Size(799, 419);
            this.imgBOXATM.TabIndex = 2;
            this.imgBOXATM.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblATMDetectedFaces);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbBOXCAMS1);
            this.panel1.Controls.Add(this.btnRUNCAM1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblATMDetectedFaces
            // 
            this.lblATMDetectedFaces.AutoSize = true;
            this.lblATMDetectedFaces.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATMDetectedFaces.Location = new System.Drawing.Point(99, 41);
            this.lblATMDetectedFaces.Name = "lblATMDetectedFaces";
            this.lblATMDetectedFaces.Size = new System.Drawing.Size(81, 17);
            this.lblATMDetectedFaces.TabIndex = 9;
            this.lblATMDetectedFaces.Text = "Detected Faces";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Detected Faces";
            // 
            // cmbBOXCAMS1
            // 
            this.cmbBOXCAMS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBOXCAMS1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBOXCAMS1.FormattingEnabled = true;
            this.cmbBOXCAMS1.Location = new System.Drawing.Point(390, 38);
            this.cmbBOXCAMS1.Name = "cmbBOXCAMS1";
            this.cmbBOXCAMS1.Size = new System.Drawing.Size(266, 25);
            this.cmbBOXCAMS1.TabIndex = 7;
            this.cmbBOXCAMS1.SelectedIndexChanged += new System.EventHandler(this.cmbBOXCAMS1_SelectedIndexChanged);
            // 
            // btnRUNCAM1
            // 
            this.btnRUNCAM1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUNCAM1.Location = new System.Drawing.Point(686, 38);
            this.btnRUNCAM1.Name = "btnRUNCAM1";
            this.btnRUNCAM1.Size = new System.Drawing.Size(75, 23);
            this.btnRUNCAM1.TabIndex = 6;
            this.btnRUNCAM1.Text = "Start";
            this.btnRUNCAM1.UseVisualStyleBackColor = true;
            this.btnRUNCAM1.Click += new System.EventHandler(this.btnRUNCAM1_Click);
            // 
            // imgBOXSIDE
            // 
            this.imgBOXSIDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBOXSIDE.Location = new System.Drawing.Point(0, 100);
            this.imgBOXSIDE.Name = "imgBOXSIDE";
            this.imgBOXSIDE.Size = new System.Drawing.Size(755, 419);
            this.imgBOXSIDE.TabIndex = 3;
            this.imgBOXSIDE.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGPU);
            this.panel2.Controls.Add(this.btnObjectDetection);
            this.panel2.Controls.Add(this.lblSIDEDETECTEDBODIES);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSIDEDETECTEDFACES);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbBOXCAMS2);
            this.panel2.Controls.Add(this.btnRUNCAM2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.Location = new System.Drawing.Point(253, 9);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(56, 17);
            this.lblGPU.TabIndex = 15;
            this.lblGPU.Text = "Using CPU";
            // 
            // btnObjectDetection
            // 
            this.btnObjectDetection.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjectDetection.Location = new System.Drawing.Point(454, 12);
            this.btnObjectDetection.Name = "btnObjectDetection";
            this.btnObjectDetection.Size = new System.Drawing.Size(278, 23);
            this.btnObjectDetection.TabIndex = 14;
            this.btnObjectDetection.Text = "Object Detection";
            this.btnObjectDetection.UseVisualStyleBackColor = true;
            this.btnObjectDetection.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSIDEDETECTEDBODIES
            // 
            this.lblSIDEDETECTEDBODIES.AutoSize = true;
            this.lblSIDEDETECTEDBODIES.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIDEDETECTEDBODIES.Location = new System.Drawing.Point(123, 46);
            this.lblSIDEDETECTEDBODIES.Name = "lblSIDEDETECTEDBODIES";
            this.lblSIDEDETECTEDBODIES.Size = new System.Drawing.Size(81, 17);
            this.lblSIDEDETECTEDBODIES.TabIndex = 13;
            this.lblSIDEDETECTEDBODIES.Text = "Detected Faces";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Detected Bodies";
            // 
            // lblSIDEDETECTEDFACES
            // 
            this.lblSIDEDETECTEDFACES.AutoSize = true;
            this.lblSIDEDETECTEDFACES.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIDEDETECTEDFACES.Location = new System.Drawing.Point(123, 22);
            this.lblSIDEDETECTEDFACES.Name = "lblSIDEDETECTEDFACES";
            this.lblSIDEDETECTEDFACES.Size = new System.Drawing.Size(81, 17);
            this.lblSIDEDETECTEDFACES.TabIndex = 11;
            this.lblSIDEDETECTEDFACES.Text = "Detected Faces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Detected Faces";
            // 
            // cmbBOXCAMS2
            // 
            this.cmbBOXCAMS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBOXCAMS2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBOXCAMS2.FormattingEnabled = true;
            this.cmbBOXCAMS2.Location = new System.Drawing.Point(361, 38);
            this.cmbBOXCAMS2.Name = "cmbBOXCAMS2";
            this.cmbBOXCAMS2.Size = new System.Drawing.Size(266, 25);
            this.cmbBOXCAMS2.TabIndex = 9;
            this.cmbBOXCAMS2.SelectedIndexChanged += new System.EventHandler(this.cmbBOXCAMS2_SelectedIndexChanged);
            // 
            // btnRUNCAM2
            // 
            this.btnRUNCAM2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUNCAM2.Location = new System.Drawing.Point(657, 38);
            this.btnRUNCAM2.Name = "btnRUNCAM2";
            this.btnRUNCAM2.Size = new System.Drawing.Size(75, 23);
            this.btnRUNCAM2.TabIndex = 8;
            this.btnRUNCAM2.Text = "Start";
            this.btnRUNCAM2.UseVisualStyleBackColor = true;
            this.btnRUNCAM2.Click += new System.EventHandler(this.btnRUNCAM2_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgv);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer3.Size = new System.Drawing.Size(1558, 338);
            this.splitContainer3.SplitterDistance = 800;
            this.splitContainer3.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNCIDENTIDDataGridViewTextBoxColumn,
            this.pATHDataGridViewTextBoxColumn,
            this.iNCIDENTDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsINCIDENTS;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(800, 338);
            this.dgv.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EVENTID,
            this.EVENT,
            this.WHEN,
            this.DESCRIPTION,
            this.eVENTIDDataGridViewTextBoxColumn,
            this.eVENTDataGridViewTextBoxColumn,
            this.wHENDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bsEVENTS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(754, 338);
            this.dataGridView1.TabIndex = 3;
            // 
            // EVENTID
            // 
            this.EVENTID.DataPropertyName = "EVENTID";
            this.EVENTID.HeaderText = "EVENTID";
            this.EVENTID.Name = "EVENTID";
            this.EVENTID.ReadOnly = true;
            // 
            // EVENT
            // 
            this.EVENT.DataPropertyName = "EVENT";
            this.EVENT.HeaderText = "EVENT";
            this.EVENT.Name = "EVENT";
            this.EVENT.ReadOnly = true;
            // 
            // WHEN
            // 
            this.WHEN.DataPropertyName = "WHEN";
            this.WHEN.HeaderText = "WHEN";
            this.WHEN.Name = "WHEN";
            this.WHEN.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            // 
            // timerTICTAC
            // 
            this.timerTICTAC.Enabled = true;
            this.timerTICTAC.Interval = 2000;
            this.timerTICTAC.Tick += new System.EventHandler(this.timerTICTAC_Tick);
            // 
            // iNCIDENTIDDataGridViewTextBoxColumn
            // 
            this.iNCIDENTIDDataGridViewTextBoxColumn.DataPropertyName = "INCIDENTID";
            this.iNCIDENTIDDataGridViewTextBoxColumn.HeaderText = "INCIDENTID";
            this.iNCIDENTIDDataGridViewTextBoxColumn.Name = "iNCIDENTIDDataGridViewTextBoxColumn";
            this.iNCIDENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pATHDataGridViewTextBoxColumn
            // 
            this.pATHDataGridViewTextBoxColumn.DataPropertyName = "PATH";
            this.pATHDataGridViewTextBoxColumn.HeaderText = "PATH";
            this.pATHDataGridViewTextBoxColumn.Name = "pATHDataGridViewTextBoxColumn";
            this.pATHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNCIDENTDataGridViewTextBoxColumn
            // 
            this.iNCIDENTDataGridViewTextBoxColumn.DataPropertyName = "INCIDENT";
            this.iNCIDENTDataGridViewTextBoxColumn.HeaderText = "INCIDENT";
            this.iNCIDENTDataGridViewTextBoxColumn.Name = "iNCIDENTDataGridViewTextBoxColumn";
            this.iNCIDENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIMEDataGridViewTextBoxColumn
            // 
            this.tIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME";
            this.tIMEDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.tIMEDataGridViewTextBoxColumn.Name = "tIMEDataGridViewTextBoxColumn";
            this.tIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsINCIDENTS
            // 
            this.bsINCIDENTS.DataMember = "INCIDENTS";
            this.bsINCIDENTS.DataSource = this.dS1;
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eVENTIDDataGridViewTextBoxColumn
            // 
            this.eVENTIDDataGridViewTextBoxColumn.DataPropertyName = "EVENTID";
            this.eVENTIDDataGridViewTextBoxColumn.HeaderText = "EVENTID";
            this.eVENTIDDataGridViewTextBoxColumn.Name = "eVENTIDDataGridViewTextBoxColumn";
            this.eVENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVENTDataGridViewTextBoxColumn
            // 
            this.eVENTDataGridViewTextBoxColumn.DataPropertyName = "EVENT";
            this.eVENTDataGridViewTextBoxColumn.HeaderText = "EVENT";
            this.eVENTDataGridViewTextBoxColumn.Name = "eVENTDataGridViewTextBoxColumn";
            this.eVENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wHENDataGridViewTextBoxColumn
            // 
            this.wHENDataGridViewTextBoxColumn.DataPropertyName = "WHEN";
            this.wHENDataGridViewTextBoxColumn.HeaderText = "WHEN";
            this.wHENDataGridViewTextBoxColumn.Name = "wHENDataGridViewTextBoxColumn";
            this.wHENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn1
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn1.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn1.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn1.Name = "dESCRIPTIONDataGridViewTextBoxColumn1";
            this.dESCRIPTIONDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsEVENTS
            // 
            this.bsEVENTS.DataMember = "EVENTS";
            this.bsEVENTS.DataSource = this.dS1;
            // 
            // taINCIDENTS1
            // 
            this.taINCIDENTS1.ClearBeforeFill = true;
            // 
            // taEVENTS1
            // 
            this.taEVENTS1.ClearBeforeFill = true;
            // 
            // frmMAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 861);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMAINFORM";
            this.Text = "frmMAINFORM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMAINFORM_FormClosing);
            this.Load += new System.EventHandler(this.frmMAINFORM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBOXATM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBOXSIDE)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsINCIDENTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEVENTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBOXCAMS1;
        private System.Windows.Forms.Button btnRUNCAM1;
        private System.Windows.Forms.ComboBox cmbBOXCAMS2;
        private System.Windows.Forms.Button btnRUNCAM2;
        private Emgu.CV.UI.ImageBox imgBOXATM;
        private Emgu.CV.UI.ImageBox imgBOXSIDE;
        private System.Windows.Forms.DataGridView dgv;
        private DS dS1;
        private System.Windows.Forms.BindingSource bsINCIDENTS;
        private DSTableAdapters.INCIDENTSTableAdapter taINCIDENTS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNCIDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNCIDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsEVENTS;
        private DSTableAdapters.EVENTSTableAdapter taEVENTS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EVENTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EVENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WHEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.Timer timerTICTAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblATMDetectedFaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSIDEDETECTEDBODIES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSIDEDETECTEDFACES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnObjectDetection;
        private System.Windows.Forms.Label lblGPU;
    }
}