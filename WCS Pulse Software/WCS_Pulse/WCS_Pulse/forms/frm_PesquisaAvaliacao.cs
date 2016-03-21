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
    public partial class frm_PesquisaAvaliacao : Form
    {
        private string[][] sTable;
        private int iCod;
        public frm_PesquisaAvaliacao()
        {
            InitializeComponent();
            iCod = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_PesquisaAvaliacao_Load(object sender, EventArgs e)
        {

        }

        private void ListarAvaliacoes()
        {
            dbGrid.Rows.Clear();
            dbGrid.Refresh();
            cAvaliacao ava = new cAvaliacao();

            if (edtNome.Text != string.Empty)
                ava.x_nome = edtNome.Text;

            int iSize = ava.ListarAvaliacoes(ref sTable);
            if (iSize <= 0)
                return;

            dbGrid.Rows.Add(iSize);
            dbGrid.Refresh();
            for (int i = 0; i < iSize; i++)
            {
                dbGrid[0, i].Value = sTable[i][0];
                dbGrid[1, i].Value = sTable[i][1];
                dbGrid[2, i].Value = sTable[i][2];
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ListarAvaliacoes();
        }

        private void dbGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0){
                cAvaliacao ava = new cAvaliacao();
                ava.id = int.Parse(dbGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                ava.CarregaAvaliacao();

                cDados data = new cDados();
                cDados[] dados = new cDados[0];

                data.id_avaliacao = ava.id;
                int size = data.ListarDados(ref dados);

                repAvaliacao[] rep = new repAvaliacao[0];
                for (int i = 0; i < size; i++)
                {
                    Array.Resize(ref rep, i + 1);
                    rep[i] = new repAvaliacao();

                    rep[i].id = ava.id;
                    rep[i].nome = ava.x_nome;
                    rep[i].data_avaliacao = ava.data_hora.ToShortDateString() + " " + ava.data_hora.ToShortTimeString();
                    rep[i].dthr_medida = dados[i].data;
                    rep[i].fc = dados[i].fc;
                }
                repViewAvaliacao frm = new repViewAvaliacao(rep);
                frm.Show();
            }
        }
    }
}
