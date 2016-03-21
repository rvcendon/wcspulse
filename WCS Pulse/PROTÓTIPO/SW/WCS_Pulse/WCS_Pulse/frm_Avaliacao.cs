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
    public partial class frm_Avaliacao : Form
    {

        private DateTime StartTime;
        private int fcMin;
        private int fcMax;
        private int fcMed = 0;
        private double kCal = 0;
        List<int> fcs = new List<int>();
        cPessoa Pessoa;
        

        public frm_Avaliacao()
        {
            InitializeComponent();
            Pessoa = null;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int iCodPessoa = 0;
            frm_PesquisaPessoa frmPes = new frm_PesquisaPessoa();
            frmPes.ShowDialog(this.MdiParent);
            iCodPessoa = frmPes.GetCod();

            Pessoa = new cPessoa();
            Pessoa.ID = iCodPessoa;

            if (Pessoa.CarregaPessoa())
            {
                edtNome.Text  = Pessoa.sNome;
                edtIdade.Text = ((DateTime.Today - Pessoa.dtDataNasc).Days / 365)  .ToString();
            }
            else {
                MessageBox.Show("ERRO AO CARREGAR USUARIO");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                StartTime = DateTime.Now;

                //Get the port name from the application list box.
                //  the PortName attribute is a string name of the COM
                //  port (e.g. - "COM1").

                serial.PortName = cbCom.Text;

                //Open the COM port.
                serial.Open();
                String discard = serial.ReadExisting();
                serial.DiscardInBuffer();
                timer.Enabled = true;

                btnIniciar.Enabled = false;
                btnParar.Enabled = true;
                cbCom.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir porta de comunicação. Verifique e tente novamente!");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            String buffer = String.Empty;
            string fc = string.Empty;
            //lblTempo.Text = (DateTime.Now - StartTime).ToString();

            if (serial.ReadBufferSize > 15)
            {
                buffer = serial.ReadExisting();
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (buffer[i] == 'F')
                        if (buffer[i + 1] == 'C')
                            if (buffer[i + 2] == '=')
                            {
                                fc = String.Empty;
                                fc += buffer[i + 3];
                                fc += buffer[i + 4];
                                fc += buffer[i + 5];
                                break;
                            }
                }
            }

            if (fc != string.Empty)

                if ((int.Parse(fc) > 40) && (int.Parse(fc) < 220))
                {
                    int ifc = int.Parse(fc);

                    chartFc.Series[0].Points.Add((double) edtZAMin.Value);
                    chartFc.Series[1].Points.Add((double) edtZAMax.Value);
                    chartFc.Series[2].Points.Add(ifc);
                    

                    if (fcMin == 0) fcMin = ifc;
                    if (fcMax == 0) fcMax = ifc;

                    fcs.Add(ifc);

                    if (ifc < fcMin) fcMin = ifc;
                    if (ifc > fcMax) fcMax = ifc;

                    fcMed = 0;

                    for (int i = 0; i < fcs.Count; i++)
                        fcMed += fcs[i];
                    fcMed = fcMed / fcs.Count;

                    //Cálculo baseado na formula do TMR do Nutrimed
                    kCal += (0.0002422430 * (fcMed * fcMed)) / 30;

                    //lblFcMax.Text = fcMax.ToString();
                    //lblFcMin.Text = fcMin.ToString();
                    //lblFcMed.Text = fcMed.ToString();
                    int tmpKCal = (int)kCal;
                    //lblKCal.Text = tmpKCal.ToString();
                }

            String discard = serial.ReadExisting();
        }

        private void chartFc_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            serial.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Pessoa == null) {
                MessageBox.Show("Pessoa não selecionada!");
                return;
            }

            cAvaliacao ava = new cAvaliacao();

            ava.altura = float.Parse(edtAltura.Text);
            ava.atividade = edtAtividade.Text;
            ava.data_hora = DateTime.Now;
            ava.fc_basal = 0;
            ava.fc_max = 0;
            ava.fc_med = 0;
            ava.fc_min = 0;
            ava.gordura = float.Parse(edtGordura.Text);
            ava.id_pessoa = Pessoa.ID;
            ava.idade = int.Parse(edtIdade.Text);
            ava.nivel_atividade = cbNivel.SelectedIndex;
            ava.observacoes = edtObs.Text;
            ava.peso = float.Parse(edtPeso.Text);
            ava.tmb = 0;
            ava.vo2 = 0;

            int id = ava.InsereAvaliacao();
            MessageBox.Show("Avaliação inserida!!! \r\nCod: " + id.ToString());

        }
    }
}
