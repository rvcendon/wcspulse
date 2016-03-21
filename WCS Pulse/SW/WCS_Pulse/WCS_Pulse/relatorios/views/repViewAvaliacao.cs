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
    public partial class repViewAvaliacao : Form
    {
        public repViewAvaliacao(repAvaliacao []reps)
        {
            InitializeComponent();

            repAvaliacaoBindingSource.DataSource = reps;
        }

        private void repViewAvaliacao_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 50;
            this.reportViewer1.RefreshReport();
        }
    }
}
