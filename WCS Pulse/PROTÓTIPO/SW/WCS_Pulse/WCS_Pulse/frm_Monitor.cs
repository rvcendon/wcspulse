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
    public partial class frmMonitor : Form
    {
        private DateTime StartTime;
        private int fcMin;
        private int fcMax;
        private int fcMed = 0;
        private double kCal = 0;
        List<int> fcs = new List<int>();
        
        public frmMonitor()
        {
            InitializeComponent(); 

            System.Drawing.Bitmap Img = new System.Drawing.Bitmap("C:\\Users\\villaverde\\Desktop\\Kairos\\Cardiomed\\WCS Pulse\\SW\\WCS_Pulse\\WCS_Pulse\\Resources\\monitor_bg.bmp");
            Img.MakeTransparent(Img.GetPixel(1, 1));
            this.BackgroundImage = Img;
            this.TransparencyKey = Img.GetPixel(1, 1);
            fcMin = 0;
            fcMax = 0;
            fcMed = 0;
        }

        private void frmMonitor_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //Dispose the In and Out buffers;
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();

                //Close the COM port
                serialPort1.Close();
            }
            //If there was an exeception then there isn't much we can
            //  do.  The port is no longer available.
            catch { }

            Close();
        }

        private void btnIniciar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                StartTime = DateTime.Now;
                lblTempo.Text = "00:00:00";

                serialPort1.PortName = cbCom.Text;

                serialPort1.Open();
                String discard = serialPort1.ReadExisting();
                serialPort1.DiscardInBuffer();
                tmrUSB.Enabled = true;
                cbCom.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir porta de comunicação. Verifique e tente novamente!");
            }
        }

        private void btnParar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrUSB_Tick(object sender, EventArgs e)
        {
            String buffer = String.Empty;

            lblTempo.Text = (DateTime.Now - StartTime).ToString();

            if (serialPort1.ReadBufferSize > 15)
            {
                buffer = serialPort1.ReadExisting();
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (buffer[i] == 'F') 
                        if (buffer[i+1] == 'C')
                            if (buffer[i+2] == '=')
                            {
                                lblFc.Text = String.Empty;
                                lblFc.Text += buffer[i + 3];
                                lblFc.Text += buffer[i + 4];
                                lblFc.Text += buffer[i + 5];
                                break;
                            }
                }
            }

            if (lblFc.Text != "---") 

            if ((int.Parse(lblFc.Text) > 40) && (int.Parse(lblFc.Text) < 220)) {
                int fc = int.Parse(lblFc.Text);

                if (fcMin == 0) fcMin = fc;
                if (fcMax == 0) fcMax = fc;

                fcs.Add(fc);

                if (fc < fcMin) fcMin = fc;
                if (fc > fcMax) fcMax = fc;

                fcMed = 0;

                for (int i = 0; i < fcs.Count; i++)
                    fcMed += fcs[i];
                fcMed = fcMed / fcs.Count;

                //Cálculo baseado na formula do TMR do Nutrimed
                kCal += (0.0002422430 * (fcMed * fcMed)) / 30;

                lblFcMax.Text = fcMax.ToString();
                lblFcMin.Text = fcMin.ToString();
                lblFcMed.Text = fcMed.ToString();
                int tmpKCal = (int)kCal;
                lblKCal.Text = tmpKCal.ToString();
            }

            String discard = serialPort1.ReadExisting();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            lblFc.Text = "---";
            tmrUSB.Enabled = false;
            serialPort1.Close();
            fcs.Clear();
            fcMed = 0;
        }
    }
}
