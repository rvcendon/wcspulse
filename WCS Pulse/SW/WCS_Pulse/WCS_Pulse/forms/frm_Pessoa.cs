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
    public partial class frm_Pessoa : Form
    {
        public frm_Pessoa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cPessoa pes = new cPessoa();
            pes.sNome = edtNome.Text;
            pes.dtDataNasc = dtNasc.Value;
            pes.sSexo = cbSexo.Text;
            if (pes.InserePessoa())
            {
                MessageBox.Show("Pessoa cadastrada com sucesso!");
                Close();
            }
            else {
                MessageBox.Show("Falha no cadastro!\r\nVerifique os dados e tente novamente.");
            }
        }
    }
}
