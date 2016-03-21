using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCS_Pulse
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnNovaAval_Click(object sender, EventArgs e)
        {
            frm_Avaliacao frmAval = new frm_Avaliacao();
            frmAval.MdiParent = this;
            frmAval.Show();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            frmMonitor frmMon = new frmMonitor();
            frmMon.MdiParent = this;
            frmMon.Show();
        }
    }
}
