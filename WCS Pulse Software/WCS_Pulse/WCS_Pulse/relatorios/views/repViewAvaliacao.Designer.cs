namespace WCS_Pulse
{
    partial class repViewAvaliacao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.repOrcamentoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repAvaliacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repOrcamentoVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAvaliacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // repOrcamentoVendaBindingSource
            // 
            this.repOrcamentoVendaBindingSource.DataMember = "repOrcamentoVenda";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsAvaliacao";
            reportDataSource1.Value = this.repAvaliacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WCS_Pulse.relatorios.rdlcs.repAvaliacao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(471, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // repAvaliacaoBindingSource
            // 
            this.repAvaliacaoBindingSource.DataSource = typeof(WCS_Pulse.repAvaliacao);
            // 
            // repViewAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 412);
            this.Controls.Add(this.reportViewer1);
            this.Name = "repViewAvaliacao";
            this.Text = "Relatório de Avaliação";
            this.Load += new System.EventHandler(this.repViewAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repOrcamentoVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAvaliacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource repOrcamentoVendaBindingSource;
        private System.Windows.Forms.BindingSource repAvaliacaoBindingSource;
    }
}