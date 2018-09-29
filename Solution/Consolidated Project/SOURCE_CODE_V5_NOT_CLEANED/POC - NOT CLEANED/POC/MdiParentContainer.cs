using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POC
{
    public partial class MdiParentContainer : Form
    {
        public MdiParentContainer()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSMTPSETTINGS f = new frmSMTPSETTINGS();
            f.MdiParent = this;
            f.Show();
        }

        private void videoGrayAndContrastAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); 
            f.MdiParent = this;
            f.Show();
        }

        private void incidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmINCIDENTS f = new frmINCIDENTS();
            f.MdiParent = this;
            f.Show();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEVENTS f = new frmEVENTS();
            f.MdiParent = this;
            f.Show();
        }

        private void faceDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSideCamera f = new frmSideCamera();
            f.MdiParent = this;
            f.Show();
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMAINFORM f = new frmMAINFORM();
            f.MdiParent = this;
            f.Show();
        }
    }
}
