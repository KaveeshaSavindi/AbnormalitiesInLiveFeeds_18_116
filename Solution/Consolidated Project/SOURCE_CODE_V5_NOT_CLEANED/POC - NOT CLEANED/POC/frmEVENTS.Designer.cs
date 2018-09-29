namespace POC
{
    partial class frmEVENTS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label eVENTIDLabel;
            System.Windows.Forms.Label eVENTLabel;
            System.Windows.Forms.Label wHENLabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            this.dS = new POC.DS();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new POC.DSTableAdapters.TableAdapterManager();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.eVENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wHENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta = new POC.DSTableAdapters.EVENTSTableAdapter();
            this.eVENTIDTextBox = new System.Windows.Forms.TextBox();
            this.eVENTTextBox = new System.Windows.Forms.TextBox();
            this.wHENTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            eVENTIDLabel = new System.Windows.Forms.Label();
            eVENTLabel = new System.Windows.Forms.Label();
            wHENLabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs
            // 
            this.bs.DataMember = "EVENTS";
            this.bs.DataSource = this.dS;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMAILSTableAdapter = null;
            this.tableAdapterManager.EVENTSTableAdapter = null;
            this.tableAdapterManager.INCIDENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
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
            // grpBox
            // 
            this.grpBox.Controls.Add(eVENTIDLabel);
            this.grpBox.Controls.Add(this.eVENTIDTextBox);
            this.grpBox.Controls.Add(eVENTLabel);
            this.grpBox.Controls.Add(this.eVENTTextBox);
            this.grpBox.Controls.Add(wHENLabel);
            this.grpBox.Controls.Add(this.wHENTextBox);
            this.grpBox.Controls.Add(dESCRIPTIONLabel);
            this.grpBox.Controls.Add(this.dESCRIPTIONTextBox);
            this.grpBox.Enabled = false;
            this.grpBox.Location = new System.Drawing.Point(17, 23);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(360, 266);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
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
            this.splitContainer1.Size = new System.Drawing.Size(1203, 658);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eVENTIDDataGridViewTextBoxColumn,
            this.eVENTDataGridViewTextBoxColumn,
            this.wHENDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(798, 658);
            this.dgv.TabIndex = 0;
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
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ta
            // 
            this.ta.ClearBeforeFill = true;
            // 
            // eVENTIDLabel
            // 
            eVENTIDLabel.AutoSize = true;
            eVENTIDLabel.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eVENTIDLabel.Location = new System.Drawing.Point(61, 65);
            eVENTIDLabel.Name = "eVENTIDLabel";
            eVENTIDLabel.Size = new System.Drawing.Size(53, 18);
            eVENTIDLabel.TabIndex = 0;
            eVENTIDLabel.Text = "EVENTID:";
            // 
            // eVENTIDTextBox
            // 
            this.eVENTIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EVENTID", true));
            this.eVENTIDTextBox.Enabled = false;
            this.eVENTIDTextBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eVENTIDTextBox.Location = new System.Drawing.Point(150, 62);
            this.eVENTIDTextBox.Name = "eVENTIDTextBox";
            this.eVENTIDTextBox.Size = new System.Drawing.Size(100, 25);
            this.eVENTIDTextBox.TabIndex = 1;
            // 
            // eVENTLabel
            // 
            eVENTLabel.AutoSize = true;
            eVENTLabel.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eVENTLabel.Location = new System.Drawing.Point(61, 91);
            eVENTLabel.Name = "eVENTLabel";
            eVENTLabel.Size = new System.Drawing.Size(43, 18);
            eVENTLabel.TabIndex = 2;
            eVENTLabel.Text = "EVENT:";
            // 
            // eVENTTextBox
            // 
            this.eVENTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "EVENT", true));
            this.eVENTTextBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eVENTTextBox.Location = new System.Drawing.Point(150, 88);
            this.eVENTTextBox.Name = "eVENTTextBox";
            this.eVENTTextBox.Size = new System.Drawing.Size(100, 25);
            this.eVENTTextBox.TabIndex = 3;
            // 
            // wHENLabel
            // 
            wHENLabel.AutoSize = true;
            wHENLabel.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            wHENLabel.Location = new System.Drawing.Point(61, 117);
            wHENLabel.Name = "wHENLabel";
            wHENLabel.Size = new System.Drawing.Size(42, 18);
            wHENLabel.TabIndex = 4;
            wHENLabel.Text = "WHEN:";
            // 
            // wHENTextBox
            // 
            this.wHENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "WHEN", true));
            this.wHENTextBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wHENTextBox.Location = new System.Drawing.Point(150, 114);
            this.wHENTextBox.Name = "wHENTextBox";
            this.wHENTextBox.Size = new System.Drawing.Size(100, 25);
            this.wHENTextBox.TabIndex = 5;
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dESCRIPTIONLabel.Location = new System.Drawing.Point(61, 143);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(79, 18);
            dESCRIPTIONLabel.TabIndex = 6;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(150, 140);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(100, 25);
            this.dESCRIPTIONTextBox.TabIndex = 7;
            // 
            // frmEVENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 658);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEVENTS";
            this.Text = "frmEVENTS";
            this.Load += new System.EventHandler(this.frmEVENTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bs;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private DSTableAdapters.EVENTSTableAdapter ta;
        private System.Windows.Forms.TextBox eVENTIDTextBox;
        private System.Windows.Forms.TextBox eVENTTextBox;
        private System.Windows.Forms.TextBox wHENTextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
    }
}