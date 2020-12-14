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
            bd.lireLesEtapes();
            lvEtapeNormee.Items.Clear();
            foreach (Etape uneEtape in Globale.lesEtapes)
            {
                ListViewItem maLigne = new ListViewItem();
                if (uneEtape.GetType().Name == "EtapeNormee")
                {
                    maLigne.Text = (uneEtape as EtapeNormee).getEtpNum().ToString();
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpLibelle());
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpNorme());
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpDateNorme().ToShortDateString());
                    maLigne.SubItems.Add((uneEtape as EtapeNormee).getEtpUser().ToString());

                    lvEtapeNormee.Items.Add(maLigne);
                }
            }
        }

        private void frmMAJEtapeNormee_Load(object sender, EventArgs e)
        {
            gbEtapeNormee.Visible = false;
            chargerListeEtapeNorme();
        }

        private void lvEtapeNormee_Click(object sender, EventArgs e)
        {
            int numeroligne = lvEtapeNormee.SelectedIndices[0];
            int etpNum = int.Parse(lvEtapeNormee.Items[numeroligne].Text);
            gbEtapeNormee.Visible = true;
            tbNorme.Text = (Globale.lesEtapes.ElementAt(etpNum - 1) as EtapeNormee).getEtpNorme();
            tbDateNorme.Text = (Globale.lesEtapes.ElementAt(etpNum - 1) as EtapeNormee).getEtpDateNorme().ToShortDateString();
            tbUtilisateur.Text = (Globale.lesEtapes.ElementAt(etpNum - 1) as EtapeNormee).getEtpUser().ToString();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            int numeroligne = lvEtapeNormee.SelectedIndices[0];
            int etpNum = int.Parse(lvEtapeNormee.Items[numeroligne].Text);

            if (tbDateNorme.Text == "" || tbNorme.Text == "")
            {
                MessageBox.Show("Données manquantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bd.MAJEtapeNormee(DateTime.Parse(tbDateNorme.Text), tbNorme.Text, etpNum, int.Parse(tbUtilisateur.Text)))
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
