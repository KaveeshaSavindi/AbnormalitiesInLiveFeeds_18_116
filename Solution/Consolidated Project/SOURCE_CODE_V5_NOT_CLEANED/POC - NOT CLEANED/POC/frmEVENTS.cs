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
    public partial class frmEVENTS : Form
    {
        public frmEVENTS()
        {
            InitializeComponent();
        }

        private void frmEVENTS_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS.EVENTS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ta.Fill(this.dS.EVENTS);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            grpBox.Enabled = true;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            grpBox.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bs.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
            this.ta.Fill(this.dS.EVENTS);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to remove this Setup?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                this.Validate();
                this.bs.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dS);
                this.ta.Fill(this.dS.EVENTS);
            }
        }
    }
}
