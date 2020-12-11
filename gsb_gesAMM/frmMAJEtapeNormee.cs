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

        private void chargerListeEtapeNorme()
        {
            lvEtapeNormee.Items.Clear();
            bd.lireLesEtapes();
            foreach (Etape uneEtape in Globale.lesEtapes)
            {
                ListViewItem maLigne = new ListViewItem();
                if (uneEtape.GetType().Name == "EtapeNormee")
                {
                    maLigne.Text = (uneEtape as EtapeNormee).getEtpNum().ToString();
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpLibelle());
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpLibelle());
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpLibelle());
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpLibelle());

                }
                lvEtapeNormee.Items.Add(maLigne);
            }
        }

        private void frmMAJEtapeNormee_Load(object sender, EventArgs e)
        {
            gbEtapeNormee.Visible = false;
            chargerListeEtapeNorme();
        }

        private void lvEtapeNormee_Click(object sender, EventArgs e)
        {
            gbEtapeNormee.Visible = true;
            int numeroligne = lvEtapeNormee.SelectedIndices[0];
            tbNorme.Text = lesEtapesNormees.ElementAt(numeroligne).getEtpNorme();
            tbDateNorme.Text = lesEtapesNormees.ElementAt(numeroligne).getEtpDateNorme().ToShortDateString();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            int numeroligne = lvEtapeNormee.SelectedIndices[0];
            int etp_num = lesEtapesNormees.ElementAt(numeroligne).getEtpNum();

            if (tbDateNorme.Text == "" || tbNorme.Text == "")
            {
                MessageBox.Show("Données manquantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bd.MAJEtapeNormee(DateTime.Parse(tbDateNorme.Text), tbNorme.Text, etp_num))
                {
                    MessageBox.Show("L'étape normée a bien été modifiée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chargerListeEtapeNorme();
                }
                else
                {
                    MessageBox.Show("Erreur dans la modification", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
