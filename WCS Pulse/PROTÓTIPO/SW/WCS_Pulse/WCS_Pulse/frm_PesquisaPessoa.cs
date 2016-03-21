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
    public partial class frm_PesquisaPessoa : Form
    {
        private string[][] sTable;
        private int iCod;

        public frm_PesquisaPessoa()
        {
            InitializeComponent();
            iCod = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ListarPessoas();
        }

        private void ListarPessoas(){
            dbGrid.Rows.Clear();
            dbGrid.Refresh();
            cPessoa pes = new cPessoa();

            if (edtNome.Text != string.Empty)
                pes.sNome = edtNome.Text;

            int iSize = pes.ListarPessoas(ref sTable);
            if (iSize <= 0)
                return;
            dbGrid.Rows.Add(iSize);
            dbGrid.Refresh();
            for (int i = 0; i < iSize; i++) {
                dbGrid[0, i].Value = sTable[i][0];
                dbGrid[1, i].Value = sTable[i][1];       
            }
        }

        private void dbGrid_DoubleClick(object sender, EventArgs e)
        {
            String sCod = dbGrid[0, dbGrid.SelectedCells[0].RowIndex].Value.ToString();
            iCod = int.Parse(sCod);
            this.Close();
            ListarPessoas();
        }

        public int GetCod()
        {
            return iCod;
        }

        private void dbGrid_Click(object sender, EventArgs e)
        {

        }

        private void frm_PesquisaPessoa_Leave(object sender, EventArgs e)
        {

        }

        private void dbGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Pessoa f = new frm_Pessoa();
            f.ShowDialog();
            
        }
    }
}
