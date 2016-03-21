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
        private int ifc = 0;
        private double kCal = 0;
        List<int> fcs = new List<int>();
        List<int> fcsd = new List<int>();
        cPessoa Pessoa;
        bool WcsPulseUsbConnected;
        cDados[] dados;

        private int protocol_step;

        public frm_Avaliacao()
        {
            InitializeComponent();
            Pessoa = null;
            WcsPulseUsbConnected = false;
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

            if (iCodPessoa == -1)
                return;
            Pessoa = new cPessoa();
            Pessoa.ID = iCodPessoa;

            if (Pessoa.CarregaPessoa())
            {
                edtNome.Text  = Pessoa.sNome;
                edtIdade.Text = ((DateTime.Today - Pessoa.dtDataNasc).Days / 365)  .ToString();
                edtZAMax.Value = 220 - ((DateTime.Today - Pessoa.dtDataNasc).Days / 365);
                edtZAMin.Value = edtZAMax.Value * (decimal) 0.7;

            }
            else {
                MessageBox.Show("ERRO AO CARREGAR USUARIO");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CommPort = 1;
            for (CommPort = 1; CommPort < 20; CommPort++)
            {
                try
                {
                    serial.PortName = "COM" + CommPort.ToString();

                    //Open the COM port.
                    serial.Open();
                    String discard = serial.ReadExisting();
                    serial.DiscardInBuffer();

                    System.Threading.Thread.Sleep(1500);

                    if(WcsPulseUsbConnected)
                        break;

                    serial.Close();
                }
                catch
                {
                    
                }
            }

            if (CommPort == 20) {
                MessageBox.Show("Receptor WCS Pulse USB não localizado!\r\nReconecte o dispositivo e tente novamente.");
                return;
            }

            dados = new cDados[0];
            StartTime = DateTime.Now;
            protocol_step = 0;
            timer.Enabled = true;

            btnIniciar.Enabled = false;
            btnParar.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (fcsd.Count > 0)
            {
                ifc = fcsd[0];
                fcsd.RemoveAt(0);
            }
            else {
                return;
            }
            if ((ifc > 40) && (ifc < 220))
            {
                chartFc.Series[0].Points.Add((double)edtZAMin.Value);
                chartFc.Series[1].Points.Add((double)edtZAMax.Value);
                chartFc.Series[2].Points.Add(ifc);

                txtFcAtual.Text = ifc.ToString() + " bpm";

                if (fcMin == 0) fcMin = ifc;
                if (fcMax == 0) fcMax = ifc;

                fcs.Add(ifc);
                txtRR.Text += ((decimal)1 / ((decimal)ifc / 60)).ToString("0.000").Replace(',', '.') + "\r\n";
                txtRR.Select(txtRR.Text.Length - 1, 1);

                if (ifc < fcMin) fcMin = ifc;
                if (ifc > fcMax) fcMax = ifc;

                txtFcMin.Text = fcMin.ToString() + " bpm";
                txtFcMax.Text = fcMax.ToString() + " bpm";

                fcMed = 0;

                for (int i = 0; i < fcs.Count; i++)
                    fcMed += fcs[i];
                fcMed = fcMed / fcs.Count;
                txtFcMedia.Text = fcMed.ToString() + " bpm";

                //Cálculo baseado na formula do TMR do Nutrimed
                kCal += (0.0002422430 * (fcMed * fcMed)) / 30;

                txtKcal.Text = kCal.ToString("0") + " Kcal";


                int tmpKCal = (int)kCal;
 
                txtTempo.Text = (DateTime.Now - StartTime).TotalMinutes.ToString("0") + " min.";

                Array.Resize(ref dados, dados.Length + 1);
                dados[dados.Length - 1] = new cDados();
                dados[dados.Length - 1].data = DateTime.Now;
                dados[dados.Length - 1].fc = ifc;
                dados[dados.Length - 1].id_avaliacao = -1;

                ifc = 0;
            }
        }

        private void chartFc_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
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

            for (int i = 0; i < dados.Length; i++) {
                dados[i].id_avaliacao = id;
                dados[i].InsereDado();                
            }

            
            MessageBox.Show("Avaliação inserida!!! \r\nCod: " + id.ToString());

        }

        private void cbCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serial.BytesToRead > 0)
            {
                byte ch = (byte) serial.ReadByte();
                switch (protocol_step) { 
                    case 0:
                        if (ch == 0xAA)
                            protocol_step++;
                        break;
                    case 1:
                        if (ch == 0xFF)
                            protocol_step++;
                        else
                            if (ch == 0xAA)
                                protocol_step = 1;
                            else
                                protocol_step = 0;
                        break;
                    case 2:
                        WcsPulseUsbConnected = true;
                        fcsd.Add(ch);
                        protocol_step = 0;
                        break;
                }
            }
        }

        private void frm_Avaliacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            forms.frmTMR f = new forms.frmTMR();
            f.ShowDialog();
        }
    }
}
