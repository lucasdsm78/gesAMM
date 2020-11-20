using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_gesAMM
{
    public partial class frmNouvMed : Form
    {
        public frmNouvMed()
        {
            InitializeComponent();
        }

        private void frmNouvMed_Load(object sender, EventArgs e)
        {

        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNouv_Click(object sender, EventArgs e)
        {
            tbDepot.Text = "";
            tbNomComm.Text = "";
            tbCompo.Text = "";
            tbEffets.Text = "";
            tbContreIndic.Text = "";
            cbFamille.Text = "";
        }
    }
}
