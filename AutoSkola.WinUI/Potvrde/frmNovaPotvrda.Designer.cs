namespace AutoSkola.WinUI.Potvrde
{
    partial class frmNovaPotvrda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.cbKandidati = new System.Windows.Forms.ComboBox();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GReferent = new System.Windows.Forms.Label();
            this.GKandidat = new System.Windows.Forms.Label();
            this.GKategorija = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbUposlenik = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datum polaganja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kandidat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Potvrdu evidentirao:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(56, 93);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(145, 24);
            this.cbKategorija.TabIndex = 1;
            // 
            // cbKandidati
            // 
            this.cbKandidati.FormattingEnabled = true;
            this.cbKandidati.Location = new System.Drawing.Point(56, 232);
            this.cbKandidati.Name = "cbKandidati";
            this.cbKandidati.Size = new System.Drawing.Size(145, 24);
            this.cbKandidati.TabIndex = 1;
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(56, 162);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(145, 23);
            this.dtpDatumPolaganja.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.GReferent);
            this.groupBox1.Controls.Add(this.GKandidat);
            this.groupBox1.Controls.Add(this.GKategorija);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.dtpDatumPolaganja);
            this.groupBox1.Controls.Add(this.cbUposlenik);
            this.groupBox1.Controls.Add(this.cbKandidati);
            this.groupBox1.Controls.Add(this.cbKategorija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evidencija potvrde";
            // 
            // GReferent
            // 
            this.GReferent.AutoSize = true;
            this.GReferent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GReferent.ForeColor = System.Drawing.Color.Red;
            this.GReferent.Location = new System.Drawing.Point(220, 308);
            this.GReferent.Name = "GReferent";
            this.GReferent.Size = new System.Drawing.Size(107, 17);
            this.GReferent.TabIndex = 4;
            this.GReferent.Text = "Obavezno polje";
            this.GReferent.Visible = false;
            // 
            // GKandidat
            // 
            this.GKandidat.AutoSize = true;
            this.GKandidat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GKandidat.ForeColor = System.Drawing.Color.Red;
            this.GKandidat.Location = new System.Drawing.Point(220, 232);
            this.GKandidat.Name = "GKandidat";
            this.GKandidat.Size = new System.Drawing.Size(107, 17);
            this.GKandidat.TabIndex = 4;
            this.GKandidat.Text = "Obavezno polje";
            this.GKandidat.Visible = false;
            // 
            // GKategorija
            // 
            this.GKategorija.AutoSize = true;
            this.GKategorija.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GKategorija.ForeColor = System.Drawing.Color.Red;
            this.GKategorija.Location = new System.Drawing.Point(220, 93);
            this.GKategorija.Name = "GKategorija";
            this.GKategorija.Size = new System.Drawing.Size(107, 17);
            this.GKategorija.TabIndex = 4;
            this.GKategorija.Text = "Obavezno polje";
            this.GKategorija.Visible = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSacuvaj.Location = new System.Drawing.Point(171, 387);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(141, 29);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbUposlenik
            // 
            this.cbUposlenik.FormattingEnabled = true;
            this.cbUposlenik.Location = new System.Drawing.Point(56, 305);
            this.cbUposlenik.Name = "cbUposlenik";
            this.cbUposlenik.Size = new System.Drawing.Size(145, 24);
            this.cbUposlenik.TabIndex = 1;
            // 
            // frmNovaPotvrda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 496);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovaPotvrda";
            this.Text = "frmNovaPotvrda";
            this.Load += new System.EventHandler(this.frmNovaPotvrda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.ComboBox cbKandidati;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUposlenik;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label GReferent;
        private System.Windows.Forms.Label GKandidat;
        private System.Windows.Forms.Label GKategorija;
    }
}