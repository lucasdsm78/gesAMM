﻿using System;
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
    }
}
