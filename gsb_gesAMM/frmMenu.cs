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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmWorkFlowMed open = new frmWorkFlowMed();
            open.MdiParent = this;
            open.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void papierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaisieDecisionEtape open = new frmSaisieDecisionEtape();
            open.MdiParent = this;
            open.Show();
        }

        private void numeriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMAJEtapeNormee open = new frmMAJEtapeNormee();
            open.MdiParent = this;
            open.Show();
        }
        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulMedCoursValid open = new frmConsulMedCoursValid();
            open.MdiParent = this;
            open.Show();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedAuto open = new frmMedAuto();
            open.MdiParent = this;
            open.Show();
        }
    }
}
