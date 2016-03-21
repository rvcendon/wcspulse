using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCS_Pulse.forms
{
    public partial class frmTMR : Form
    {
        private int iTMB;
        private int iFcMin;
        private int iTotFc; 
        private int iLastFc;
        private int protocol_step;
        private bool WcsPulseUsbConnected;
        private int ifc = 0;

        public frmTMR()
        {
            InitializeComponent();
            cbDuracao.SelectedIndex = 0;
            WcsPulseUsbConnected = false;

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

                    if (WcsPulseUsbConnected)
                        break;

                    serial.Close();
                }
                catch
                {

                }
            }

            if (CommPort == 20)
            {
                MessageBox.Show("Receptor WCS Pulse USB não localizado!\r\nReconecte o dispositivo e tente novamente.");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iTMB = 0;
            iFcMin = 0;

            iTotFc = 0;
            iLastFc = 0;

            protocol_step = 0;

            switch (cbDuracao.SelectedIndex)
            {
                case 0: // 05 minutos
                    pgBar.Maximum = 150;
                    pgBar.Value = 0;
                    btnIniciar.Enabled = false;
                    timer.Enabled = true;
                    break;

                case 1: // 10 minutos
                    pgBar.Maximum = 300;
                    pgBar.Value = 0;
                    btnIniciar.Enabled = false;
                    timer.Enabled = true;
                    break;

                case 2: // 15 minutos
                    pgBar.Maximum = 450;
                    pgBar.Value = 0;
                    btnIniciar.Enabled = false;
                    timer.Enabled = true;
                    break;
            }
        }

        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serial.BytesToRead > 0)
            {
                byte ch = (byte)serial.ReadByte();
                switch (protocol_step)
                {
                    case 0:
                        if (ch == 0xAA)
                            protocol_step++;
                        break;
                    case 1:
                        if (ch == 0xFF)
                            protocol_step++;
                        else
                            protocol_step = 0;
                        break;
                    case 2:
                        WcsPulseUsbConnected = true;
                        ifc = ch;
                        protocol_step = 0;
                        break;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int fcMed = 0;

            if ((ifc > 30) && (ifc < 220))
            {
                lblFC.Text = "FC: " + ifc.ToString() + "bpm";
                iTotFc++;
                iLastFc += ifc;
                fcMed = (iLastFc / iTotFc);

                iTMB = (int) (0.0002422430 * (fcMed * fcMed) * 60 * 24);
                lblTMB.Text = "TMB: " + iTMB.ToString() + "KCal";
            }
            pgBar.Increment(1);

            if (pgBar.Maximum == pgBar.Value)
            {
                timer.Enabled = false;
                btnIniciar.Enabled = true;
            }

        }
    }
}
