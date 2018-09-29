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
    public partial class frmINCIDENTS : Form
    {
        public frmINCIDENTS()
        {
            InitializeComponent();
        }

        private void frmINCIDENTS_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS.INCIDENTS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ta.Fill(this.dS.INCIDENTS);

        }
    }
}
