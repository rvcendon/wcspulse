namespace WCS_Pulse.forms
{
    partial class frmTMR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDuracao = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.lblTMB = new System.Windows.Forms.Label();
            this.lblFC = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDuracao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedimento";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(30, 64);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(99, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duração:";
            // 
            // cbDuracao
            // 
            this.cbDuracao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuracao.FormattingEnabled = true;
            this.cbDuracao.Items.AddRange(new object[] {
            "5 minutos",
            "10 minutos",
            "15 minutos"});
            this.cbDuracao.Location = new System.Drawing.Point(16, 37);
            this.cbDuracao.Name = "cbDuracao";
            this.cbDuracao.Size = new System.Drawing.Size(135, 21);
            this.cbDuracao.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgBar);
            this.groupBox2.Controls.Add(this.lblTMB);
            this.groupBox2.Controls.Add(this.lblFC);
            this.groupBox2.Location = new System.Drawing.Point(182, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acompanhamento";
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(6, 63);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(285, 23);
            this.pgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgBar.TabIndex = 4;
            // 
            // lblTMB
            // 
            this.lblTMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMB.Location = new System.Drawing.Point(146, 28);
            this.lblTMB.Name = "lblTMB";
            this.lblTMB.Size = new System.Drawing.Size(145, 19);
            this.lblTMB.TabIndex = 3;
            this.lblTMB.Text = "TMR: X.XXX KCal";
            this.lblTMB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFC
            // 
            this.lblFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFC.Location = new System.Drawing.Point(6, 28);
            this.lblFC.Name = "lblFC";
            this.lblFC.Size = new System.Drawing.Size(118, 19);
            this.lblFC.TabIndex = 2;
            this.lblFC.Text = "FC: XXX BPM";
            this.lblFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serial
            // 
            this.serial.PortName = "COM3";
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // frmTMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 147);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTMR";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TMR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDuracao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Label lblTMB;
        private System.Windows.Forms.Label lblFC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
        private System.IO.Ports.SerialPort serial;
    }
}