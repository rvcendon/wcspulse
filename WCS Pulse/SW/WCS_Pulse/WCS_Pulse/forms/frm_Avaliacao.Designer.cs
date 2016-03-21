namespace WCS_Pulse
{
    partial class frm_Avaliacao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTempo = new System.Windows.Forms.Label();
            this.txtKcal = new System.Windows.Forms.Label();
            this.txtFcMin = new System.Windows.Forms.Label();
            this.txtFcMedia = new System.Windows.Forms.Label();
            this.txtFcMax = new System.Windows.Forms.Label();
            this.txtFcAtual = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.edtZAMax = new System.Windows.Forms.NumericUpDown();
            this.edtZAMin = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.edtVO2 = new System.Windows.Forms.NumericUpDown();
            this.edtGordura = new System.Windows.Forms.NumericUpDown();
            this.edtAltura = new System.Windows.Forms.NumericUpDown();
            this.edtPeso = new System.Windows.Forms.NumericUpDown();
            this.edtIdade = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chartFc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.edtObs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtAtividade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.txtRR = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtZAMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtZAMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtVO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtGordura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTempo);
            this.panel1.Controls.Add(this.txtKcal);
            this.panel1.Controls.Add(this.txtFcMin);
            this.panel1.Controls.Add(this.txtFcMedia);
            this.panel1.Controls.Add(this.txtFcMax);
            this.panel1.Controls.Add(this.txtFcAtual);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.edtZAMax);
            this.panel1.Controls.Add(this.edtZAMin);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.edtVO2);
            this.panel1.Controls.Add(this.edtGordura);
            this.panel1.Controls.Add(this.edtAltura);
            this.panel1.Controls.Add(this.edtPeso);
            this.panel1.Controls.Add(this.edtIdade);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.chartFc);
            this.panel1.Controls.Add(this.cbNivel);
            this.panel1.Controls.Add(this.edtObs);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.edtAtividade);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 333);
            this.panel1.TabIndex = 0;
            // 
            // txtTempo
            // 
            this.txtTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTempo.Location = new System.Drawing.Point(782, 291);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(134, 19);
            this.txtTempo.TabIndex = 49;
            this.txtTempo.Text = "--:--:--";
            this.txtTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKcal
            // 
            this.txtKcal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKcal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKcal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKcal.Location = new System.Drawing.Point(782, 239);
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.Size = new System.Drawing.Size(134, 19);
            this.txtKcal.TabIndex = 48;
            this.txtKcal.Text = "--- Kcal";
            this.txtKcal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFcMin
            // 
            this.txtFcMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFcMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFcMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFcMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFcMin.Location = new System.Drawing.Point(782, 187);
            this.txtFcMin.Name = "txtFcMin";
            this.txtFcMin.Size = new System.Drawing.Size(134, 19);
            this.txtFcMin.TabIndex = 47;
            this.txtFcMin.Text = "--- bpm";
            this.txtFcMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFcMedia
            // 
            this.txtFcMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFcMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFcMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFcMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFcMedia.Location = new System.Drawing.Point(782, 135);
            this.txtFcMedia.Name = "txtFcMedia";
            this.txtFcMedia.Size = new System.Drawing.Size(134, 19);
            this.txtFcMedia.TabIndex = 46;
            this.txtFcMedia.Text = "--- bpm";
            this.txtFcMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFcMax
            // 
            this.txtFcMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFcMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFcMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFcMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFcMax.Location = new System.Drawing.Point(782, 83);
            this.txtFcMax.Name = "txtFcMax";
            this.txtFcMax.Size = new System.Drawing.Size(134, 19);
            this.txtFcMax.TabIndex = 45;
            this.txtFcMax.Text = "--- bpm";
            this.txtFcMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFcAtual
            // 
            this.txtFcAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFcAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFcAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFcAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFcAtual.Location = new System.Drawing.Point(782, 36);
            this.txtFcAtual.Name = "txtFcAtual";
            this.txtFcAtual.Size = new System.Drawing.Size(134, 19);
            this.txtFcAtual.TabIndex = 44;
            this.txtFcAtual.Text = "--- bpm";
            this.txtFcAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(782, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(138, 16);
            this.label24.TabIndex = 43;
            this.label24.Text = "GASTO CALÓRICO";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(782, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 16);
            this.label23.TabIndex = 42;
            this.label23.Text = "FC MÉDIA";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(781, 275);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "TEMPO DECORRIDO";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(782, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "FC MÍNIMA";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(782, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "FC MÁXIMA";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(782, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "FC ATUAL";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtZAMax
            // 
            this.edtZAMax.Location = new System.Drawing.Point(326, 71);
            this.edtZAMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edtZAMax.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.edtZAMax.Name = "edtZAMax";
            this.edtZAMax.Size = new System.Drawing.Size(44, 20);
            this.edtZAMax.TabIndex = 37;
            this.edtZAMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtZAMax.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // edtZAMin
            // 
            this.edtZAMin.Location = new System.Drawing.Point(278, 71);
            this.edtZAMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edtZAMin.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.edtZAMin.Name = "edtZAMin";
            this.edtZAMin.Size = new System.Drawing.Size(44, 20);
            this.edtZAMin.TabIndex = 36;
            this.edtZAMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtZAMin.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(295, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Zona Alvo:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(195, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "bpm";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(195, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "ml/Kg/min";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(113, 170);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 31;
            this.button1.Text = "Calcular TMR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "TMR:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(195, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "%";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "m";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Kg";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "anos";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtVO2
            // 
            this.edtVO2.DecimalPlaces = 2;
            this.edtVO2.Location = new System.Drawing.Point(113, 144);
            this.edtVO2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edtVO2.Name = "edtVO2";
            this.edtVO2.Size = new System.Drawing.Size(76, 20);
            this.edtVO2.TabIndex = 25;
            this.edtVO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtGordura
            // 
            this.edtGordura.DecimalPlaces = 2;
            this.edtGordura.Location = new System.Drawing.Point(113, 118);
            this.edtGordura.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edtGordura.Name = "edtGordura";
            this.edtGordura.Size = new System.Drawing.Size(76, 20);
            this.edtGordura.TabIndex = 24;
            this.edtGordura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtAltura
            // 
            this.edtAltura.DecimalPlaces = 2;
            this.edtAltura.Location = new System.Drawing.Point(113, 92);
            this.edtAltura.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edtAltura.Name = "edtAltura";
            this.edtAltura.Size = new System.Drawing.Size(76, 20);
            this.edtAltura.TabIndex = 23;
            this.edtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtPeso
            // 
            this.edtPeso.DecimalPlaces = 2;
            this.edtPeso.Location = new System.Drawing.Point(113, 66);
            this.edtPeso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edtPeso.Name = "edtPeso";
            this.edtPeso.Size = new System.Drawing.Size(76, 20);
            this.edtPeso.TabIndex = 22;
            this.edtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtIdade
            // 
            this.edtIdade.Location = new System.Drawing.Point(113, 40);
            this.edtIdade.Name = "edtIdade";
            this.edtIdade.ReadOnly = true;
            this.edtIdade.Size = new System.Drawing.Size(76, 20);
            this.edtIdade.TabIndex = 7;
            this.edtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(280, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 20);
            this.button5.TabIndex = 21;
            this.button5.Text = "Calcular VO2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(342, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chartFc
            // 
            this.chartFc.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartFc.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea1.Name = "ChartArea1";
            this.chartFc.ChartAreas.Add(chartArea1);
            this.chartFc.Location = new System.Drawing.Point(383, 13);
            this.chartFc.Name = "chartFc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "serieFc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "serieFmin";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "serieFmax";
            this.chartFc.Series.Add(series1);
            this.chartFc.Series.Add(series2);
            this.chartFc.Series.Add(series3);
            this.chartFc.Size = new System.Drawing.Size(391, 306);
            this.chartFc.TabIndex = 19;
            this.chartFc.Text = "chart1";
            this.chartFc.Click += new System.EventHandler(this.chartFc_Click);
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Sedentário",
            "Normal",
            "Ativo",
            "Atleta"});
            this.cbNivel.Location = new System.Drawing.Point(113, 196);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(257, 21);
            this.cbNivel.TabIndex = 18;
            // 
            // edtObs
            // 
            this.edtObs.Location = new System.Drawing.Point(113, 249);
            this.edtObs.Multiline = true;
            this.edtObs.Name = "edtObs";
            this.edtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtObs.Size = new System.Drawing.Size(257, 70);
            this.edtObs.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Observações:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtAtividade
            // 
            this.edtAtividade.Location = new System.Drawing.Point(113, 223);
            this.edtAtividade.Name = "edtAtividade";
            this.edtAtividade.Size = new System.Drawing.Size(257, 20);
            this.edtAtividade.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Atividade Realizada:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "VO2:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gordura Corporal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nível de Atividade:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Altura:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(113, 13);
            this.edtNome.Name = "edtNome";
            this.edtNome.ReadOnly = true;
            this.edtNome.Size = new System.Drawing.Size(228, 20);
            this.edtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvar.Location = new System.Drawing.Point(863, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIniciar.Location = new System.Drawing.Point(631, 381);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(110, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "&Iniciar Monitoração";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParar
            // 
            this.btnParar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(747, 381);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(110, 23);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "&Parar Monitoração";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(745, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 39);
            this.label10.TabIndex = 6;
            this.label10.Text = "Avaliação";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serial
            // 
            this.serial.PortName = "COM3";
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // txtRR
            // 
            this.txtRR.Location = new System.Drawing.Point(951, 42);
            this.txtRR.Multiline = true;
            this.txtRR.Name = "txtRR";
            this.txtRR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRR.Size = new System.Drawing.Size(257, 333);
            this.txtRR.TabIndex = 18;
            // 
            // frm_Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 411);
            this.Controls.Add(this.txtRR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Avaliacao";
            this.Text = "Avaliação";
            this.Load += new System.EventHandler(this.frm_Avaliacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtZAMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtZAMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtVO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtGordura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.TextBox edtObs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtAtividade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.NumericUpDown edtVO2;
        private System.Windows.Forms.NumericUpDown edtGordura;
        private System.Windows.Forms.NumericUpDown edtAltura;
        private System.Windows.Forms.NumericUpDown edtPeso;
        private System.Windows.Forms.NumericUpDown edtIdade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown edtZAMax;
        private System.Windows.Forms.NumericUpDown edtZAMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label txtTempo;
        private System.Windows.Forms.Label txtKcal;
        private System.Windows.Forms.Label txtFcMin;
        private System.Windows.Forms.Label txtFcMedia;
        private System.Windows.Forms.Label txtFcMax;
        private System.Windows.Forms.Label txtFcAtual;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtRR;
    }
}