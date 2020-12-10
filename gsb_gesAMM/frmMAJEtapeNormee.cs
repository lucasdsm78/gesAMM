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
    public partial class frmMAJEtapeNormee : Form
    {
        public frmMAJEtapeNormee()
        {
            InitializeComponent();
        }

        private void frmMAJEtapeNormee_Load(object sender, EventArgs e)
        {
            gbEtapeNormee.Visible = false;

            bd.lireLesClientsAvecFactures();
            foreach (Etape uneEtape in Globale.)
            {
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = leClient.getNom();
                maLigne.SubItems.Add(laFacture.getNumFact().ToString());
                maLigne.SubItems.Add(laFacture.getDateFact().ToShortDateString());
                maLigne.SubItems.Add(laFacture.getMtFact().ToString());
                lvEtapeNormee.Items.Add(maLigne);
                
            }
        }
    }
}
