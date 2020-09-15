using Microsoft.Reporting.WinForms;

namespace AutoSkola.WinUI.Uplate.Izvjestaj
{
    partial class frmUplateIzvjestajj
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
            this.dtpUplata = new System.Windows.Forms.DateTimePicker();
            this.cbKandidat = new System.Windows.Forms.ComboBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.UplateKandidatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetUplate = new AutoSkola.WinUI.Uplate.Izvjestaj.DataSetUplate();
            this.UplateKandidatiTableAdapter = new AutoSkola.WinUI.Uplate.Izvjestaj.DataSetUplateTableAdapters.UplateKandidatiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewerUplate = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.UplateKandidatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetUplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpUplata
            // 
            this.dtpUplata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUplata.Location = new System.Drawing.Point(299, 16);
            this.dtpUplata.Name = "dtpUplata";
            this.dtpUplata.Size = new System.Drawing.Size(98, 20);
            this.dtpUplata.TabIndex = 0;
            this.dtpUplata.ValueChanged += new System.EventHandler(this.dtpUplata_ValueChanged);
            this.dtpUplata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpUplata_KeyDown);
            // 
            // cbKandidat
            // 
            this.cbKandidat.FormattingEnabled = true;
            this.cbKandidat.Location = new System.Drawing.Point(421, 16);
            this.cbKandidat.Name = "cbKandidat";
            this.cbKandidat.Size = new System.Drawing.Size(121, 21);
            this.cbKandidat.TabIndex = 1;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUcitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitaj.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUcitaj.Location = new System.Drawing.Point(693, 9);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(95, 38);
            this.btnUcitaj.TabIndex = 2;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = false;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // UplateKandidatiBindingSource
            // 
            this.UplateKandidatiBindingSource.DataMember = "UplateKandidati";
            this.UplateKandidatiBindingSource.DataSource = this.DataSetUplate;
            // 
            // DataSetUplate
            // 
            this.DataSetUplate.DataSetName = "DataSetUplate";
            this.DataSetUplate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UplateKandidatiTableAdapter
            // 
            this.UplateKandidatiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odaberite datum ili kandidata ";
            // 
            // reportViewerUplate
            // 
            reportDataSource1.Name = "DataSetUplate";
            reportDataSource1.Value = this.UplateKandidatiBindingSource;
            this.reportViewerUplate.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerUplate.LocalReport.ReportEmbeddedResource = "AutoSkola.WinUI.Uplate.Izvjestaj.ReportUplate.rdlc";
            this.reportViewerUplate.Location = new System.Drawing.Point(26, 52);
            this.reportViewerUplate.Name = "reportViewerUplate";
            this.reportViewerUplate.ServerReport.BearerToken = null;
            this.reportViewerUplate.Size = new System.Drawing.Size(762, 396);
            this.reportViewerUplate.TabIndex = 5;
            // 
            // frmUplateIzvjestajj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerUplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.cbKandidat);
            this.Controls.Add(this.dtpUplata);
            this.Name = "frmUplateIzvjestajj";
            this.Text = "frmUplateIzvjestajj";
            this.Load += new System.EventHandler(this.frmUplateIzvjestajj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UplateKandidatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetUplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpUplata;
        private System.Windows.Forms.ComboBox cbKandidat;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.BindingSource UplateKandidatiBindingSource;
        private DataSetUplate DataSetUplate;
        private DataSetUplateTableAdapters.UplateKandidatiTableAdapter UplateKandidatiTableAdapter;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerUplate;
    }
}