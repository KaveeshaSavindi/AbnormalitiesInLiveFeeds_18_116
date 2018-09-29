namespace POC
{
    partial class frmSMTPSETTINGS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label iDEMAILSETUPLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label sMTPSERVERLabel;
            System.Windows.Forms.Label sMTPPORTLabel;
            System.Windows.Forms.Label eNABLEDLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dS = new POC.DS();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.ta = new POC.DSTableAdapters.SMTPSETTINGSTableAdapter();
            this.tableAdapterManager = new POC.DSTableAdapters.TableAdapterManager();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.iDEMAILSETUPTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.sMTPSERVERTextBox = new System.Windows.Forms.TextBox();
            this.sMTPPORTTextBox = new System.Windows.Forms.TextBox();
            this.eNABLEDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iDEMAILSETUPLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            sMTPSERVERLabel = new System.Windows.Forms.Label();
            sMTPPORTLabel = new System.Windows.Forms.Label();
            eNABLEDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.grpBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Size = new System.Drawing.Size(1227, 666);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 0;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs
            // 
            this.bs.DataMember = "SMTPSETTINGS";
            this.bs.DataSource = this.dS;
            // 
            // ta
            // 
            this.ta.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMAILSTableAdapter = null;
            this.tableAdapterManager.EVENTSTableAdapter = null;
            this.tableAdapterManager.INCIDENTSTableAdapter = null;
            this.tableAdapterManager.SMTPSETTINGSTableAdapter = this.ta;
            this.tableAdapterManager.UpdateOrder = POC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(814, 666);
            this.dgv.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDEMAILSETUP";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDEMAILSETUP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn2.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PASSWORD";
            this.dataGridViewTextBoxColumn3.HeaderText = "PASSWORD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SMTPSERVER";
            this.dataGridViewTextBoxColumn4.HeaderText = "SMTPSERVER";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SMTPPORT";
            this.dataGridViewTextBoxColumn5.HeaderText = "SMTPPORT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ENABLED";
            this.dataGridViewTextBoxColumn6.HeaderText = "ENABLED";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(iDEMAILSETUPLabel);
            this.grpBox.Controls.Add(this.iDEMAILSETUPTextBox);
            this.grpBox.Controls.Add(eMAILLabel);
            this.grpBox.Controls.Add(this.eMAILTextBox);
            this.grpBox.Controls.Add(pASSWORDLabel);
            this.grpBox.Controls.Add(this.pASSWORDTextBox);
            this.grpBox.Controls.Add(sMTPSERVERLabel);
            this.grpBox.Controls.Add(this.sMTPSERVERTextBox);
            this.grpBox.Controls.Add(sMTPPORTLabel);
            this.grpBox.Controls.Add(this.sMTPPORTTextBox);
            this.grpBox.Controls.Add(eNABLEDLabel);
            this.grpBox.Controls.Add(this.eNABLEDTextBox);
            this.grpBox.Enabled = false;
            this.grpBox.Location = new System.Drawing.Point(17, 23);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(360, 266);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            // 
            // iDEMAILSETUPLabel
            // 
            iDEMAILSETUPLabel.AutoSize = true;
            iDEMAILSETUPLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDEMAILSETUPLabel.Location = new System.Drawing.Point(35, 66);
            iDEMAILSETUPLabel.Name = "iDEMAILSETUPLabel";
            iDEMAILSETUPLabel.Size = new System.Drawing.Size(76, 17);
            iDEMAILSETUPLabel.TabIndex = 0;
            iDEMAILSETUPLabel.Text = "IDEMAILSETUP:";
            // 
            // iDEMAILSETUPTextBox
            // 
            this.iDEMAILSETUPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "IDEMAILSETUP", true));
            this.iDEMAILSETUPTextBox.Enabled = false;
            this.iDEMAILSETUPTextBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDEMAILSETUPTextBox.Location = new System.Drawing.Point(130, 63);
            this.iDEMAILSETUPTextBox.Name = "iDEMAILSETUPTextBox";
            this.iDEMAILSETUPTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDEMAILSETUPTextBox.TabIndex = 1;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(35, 92);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(38, 17);
            eMAILLabel.TabIndex = 2;
            eMAILLabel.Text = "EMAIL:";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EMAIL", true));
            this.eMAILTextBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMAILTextBox.Location = new System.Drawing.Point(130, 89);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(100, 23);
            this.eMAILTextBox.TabIndex = 3;
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pASSWORDLabel.Location = new System.Drawing.Point(35, 118);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(66, 17);
            pASSWORDLabel.TabIndex = 4;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "PASSWORD", true));
            this.pASSWORDTextBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(130, 115);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(100, 23);
            this.pASSWORDTextBox.TabIndex = 5;
            // 
            // sMTPSERVERLabel
            // 
            sMTPSERVERLabel.AutoSize = true;
            sMTPSERVERLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sMTPSERVERLabel.Location = new System.Drawing.Point(35, 144);
            sMTPSERVERLabel.Name = "sMTPSERVERLabel";
            sMTPSERVERLabel.Size = new System.Drawing.Size(72, 17);
            sMTPSERVERLabel.TabIndex = 6;
            sMTPSERVERLabel.Text = "SMTPSERVER:";
            // 
            // sMTPSERVERTextBox
            // 
            this.sMTPSERVERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "SMTPSERVER", true));
            this.sMTPSERVERTextBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sMTPSERVERTextBox.Location = new System.Drawing.Point(130, 141);
            this.sMTPSERVERTextBox.Name = "sMTPSERVERTextBox";
            this.sMTPSERVERTextBox.Size = new System.Drawing.Size(100, 23);
            this.sMTPSERVERTextBox.TabIndex = 7;
            // 
            // sMTPPORTLabel
            // 
            sMTPPORTLabel.AutoSize = true;
            sMTPPORTLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sMTPPORTLabel.Location = new System.Drawing.Point(35, 170);
            sMTPPORTLabel.Name = "sMTPPORTLabel";
            sMTPPORTLabel.Size = new System.Drawing.Size(64, 17);
            sMTPPORTLabel.TabIndex = 8;
            sMTPPORTLabel.Text = "SMTPPORT:";
            // 
            // sMTPPORTTextBox
            // 
            this.sMTPPORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "SMTPPORT", true));
            this.sMTPPORTTextBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sMTPPORTTextBox.Location = new System.Drawing.Point(130, 167);
            this.sMTPPORTTextBox.Name = "sMTPPORTTextBox";
            this.sMTPPORTTextBox.Size = new System.Drawing.Size(100, 23);
            this.sMTPPORTTextBox.TabIndex = 9;
            // 
            // eNABLEDLabel
            // 
            eNABLEDLabel.AutoSize = true;
            eNABLEDLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eNABLEDLabel.Location = new System.Drawing.Point(35, 196);
            eNABLEDLabel.Name = "eNABLEDLabel";
            eNABLEDLabel.Size = new System.Drawing.Size(49, 17);
            eNABLEDLabel.TabIndex = 10;
            eNABLEDLabel.Text = "ENABLED:";
            // 
            // eNABLEDTextBox
            // 
            this.eNABLEDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "ENABLED", true));
            this.eNABLEDTextBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNABLEDTextBox.Location = new System.Drawing.Point(130, 193);
            this.eNABLEDTextBox.Name = "eNABLEDTextBox";
            this.eNABLEDTextBox.Size = new System.Drawing.Size(100, 23);
            this.eNABLEDTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(302, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmSMTPSETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 666);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSMTPSETTINGS";
            this.Text = "SMTP SETTINGS";
            this.Load += new System.EventHandler(this.frmSMTPSETTINGS_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DS dS;
        private System.Windows.Forms.BindingSource bs;
        private DSTableAdapters.SMTPSETTINGSTableAdapter ta;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox iDEMAILSETUPTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.TextBox sMTPSERVERTextBox;
        private System.Windows.Forms.TextBox sMTPPORTTextBox;
        private System.Windows.Forms.TextBox eNABLEDTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}