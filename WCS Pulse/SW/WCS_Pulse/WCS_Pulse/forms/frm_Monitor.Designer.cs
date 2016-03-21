namespace WCS_Pulse
{
    partial class frmMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Panel();
            this.lblFc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Panel();
            this.btnParar = new System.Windows.Forms.Panel();
            this.tmrUSB = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblKCal = new System.Windows.Forms.Label();
            this.lblFcMax = new System.Windows.Forms.Label();
            this.lblFcMed = new System.Windows.Forms.Label();
            this.lblFcMin = new System.Windows.Forms.Label();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(496, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseClick);
            // 
            // lblFc
            // 
            this.lblFc.BackColor = System.Drawing.Color.Transparent;
            this.lblFc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFc.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFc.Location = new System.Drawing.Point(74, 56);
            this.lblFc.Name = "lblFc";
            this.lblFc.Size = new System.Drawing.Size(234, 114);
            this.lblFc.TabIndex = 1;
            this.lblFc.Text = "---";
            this.lblFc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "bpm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Location = new System.Drawing.Point(94, 332);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(70, 35);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnIniciar_Paint);
            this.btnIniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnIniciar_MouseClick);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Transparent;
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.Location = new System.Drawing.Point(215, 332);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(70, 35);
            this.btnParar.TabIndex = 4;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            this.btnParar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnParar_Paint);
            // 
            // tmrUSB
            // 
            this.tmrUSB.Interval = 2000;
            this.tmrUSB.Tick += new System.EventHandler(this.tmrUSB_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.PortName = "COM3";
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTempo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(359, 56);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(101, 25);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "--:--:--";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKCal
            // 
            this.lblKCal.BackColor = System.Drawing.Color.Transparent;
            this.lblKCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKCal.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKCal.ForeColor = System.Drawing.Color.White;
            this.lblKCal.Location = new System.Drawing.Point(368, 103);
            this.lblKCal.Name = "lblKCal";
            this.lblKCal.Size = new System.Drawing.Size(64, 25);
            this.lblKCal.TabIndex = 6;
            this.lblKCal.Text = "---";
            this.lblKCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKCal.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFcMax
            // 
            this.lblFcMax.BackColor = System.Drawing.Color.Transparent;
            this.lblFcMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFcMax.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFcMax.ForeColor = System.Drawing.Color.White;
            this.lblFcMax.Location = new System.Drawing.Point(368, 168);
            this.lblFcMax.Name = "lblFcMax";
            this.lblFcMax.Size = new System.Drawing.Size(82, 25);
            this.lblFcMax.TabIndex = 7;
            this.lblFcMax.Text = "---";
            this.lblFcMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFcMed
            // 
            this.lblFcMed.BackColor = System.Drawing.Color.Transparent;
            this.lblFcMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFcMed.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFcMed.ForeColor = System.Drawing.Color.White;
            this.lblFcMed.Location = new System.Drawing.Point(368, 224);
            this.lblFcMed.Name = "lblFcMed";
            this.lblFcMed.Size = new System.Drawing.Size(82, 25);
            this.lblFcMed.TabIndex = 8;
            this.lblFcMed.Text = "---";
            this.lblFcMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFcMin
            // 
            this.lblFcMin.BackColor = System.Drawing.Color.Transparent;
            this.lblFcMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFcMin.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFcMin.ForeColor = System.Drawing.Color.White;
            this.lblFcMin.Location = new System.Drawing.Point(368, 281);
            this.lblFcMin.Name = "lblFcMin";
            this.lblFcMin.Size = new System.Drawing.Size(82, 25);
            this.lblFcMin.TabIndex = 9;
            this.lblFcMin.Text = "---";
            this.lblFcMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCom
            // 
            this.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.cbCom.Location = new System.Drawing.Point(150, 268);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(87, 21);
            this.cbCom.TabIndex = 10;
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::WCS_Pulse.Properties.Resources.monitor_bg;
            this.ClientSize = new System.Drawing.Size(525, 406);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.lblFcMin);
            this.Controls.Add(this.lblFcMed);
            this.Controls.Add(this.lblFcMax);
            this.Controls.Add(this.lblKCal);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFc);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM DO MONITOR DE FC";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmMonitor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnExit;
        private System.Windows.Forms.Label lblFc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btnIniciar;
        private System.Windows.Forms.Panel btnParar;
        private System.Windows.Forms.Timer tmrUSB;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblKCal;
        private System.Windows.Forms.Label lblFcMax;
        private System.Windows.Forms.Label lblFcMed;
        private System.Windows.Forms.Label lblFcMin;
        private System.Windows.Forms.ComboBox cbCom;
    }
}