namespace AutoSkola.WinUI.Potvrde.Izvjestaj
{
    partial class frmIzvjestajPotvrde
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPotvrde = new AutoSkola.WinUI.Potvrde.Izvjestaj.DataSetPotvrde();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.reportViewerPotvrde = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new AutoSkola.WinUI.Potvrde.Izvjestaj.DataSetPotvrdeTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetPotvrde;
            // 
            // DataSetPotvrde
            // 
            this.DataSetPotvrde.DataSetName = "DataSetPotvrde";
            this.DataSetPotvrde.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(13, 13);
            this.dtpDatumPolaganja.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(103, 20);
            this.dtpDatumPolaganja.TabIndex = 1;
            this.dtpDatumPolaganja.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDatumPolaganja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDatumPolaganja_KeyDown);
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(156, 12);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(121, 21);
            this.cbKategorije.TabIndex = 2;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUcitaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUcitaj.Location = new System.Drawing.Point(735, 2);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(87, 38);
            this.btnUcitaj.TabIndex = 3;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = false;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // reportViewerPotvrde
            // 
            reportDataSource1.Name = "DataSetPotvrde";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewerPotvrde.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPotvrde.LocalReport.ReportEmbeddedResource = "AutoSkola.WinUI.Potvrde.Izvjestaj.IzvjestajPotvrde.rdlc";
            this.reportViewerPotvrde.Location = new System.Drawing.Point(12, 46);
            this.reportViewerPotvrde.Name = "reportViewerPotvrde";
            this.reportViewerPotvrde.ServerReport.BearerToken = null;
            this.reportViewerPotvrde.Size = new System.Drawing.Size(810, 438);
            this.reportViewerPotvrde.TabIndex = 4;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // frmIzvjestajPotvrde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 496);
            this.Controls.Add(this.reportViewerPotvrde);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.cbKategorije);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Name = "frmIzvjestajPotvrde";
            this.Text = "IzvjestajPotvrde";
            this.Load += new System.EventHandler(this.IzvjestajPotvrde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPotvrde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.ComboBox cbKategorije;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetPotvrde DataSetPotvrde;
        private DataSetPotvrdeTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPotvrde;
    }
}