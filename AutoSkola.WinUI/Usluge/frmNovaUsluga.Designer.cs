namespace AutoSkola.WinUI.Usluge
{
    partial class frmNovaUsluga
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GKategorija = new System.Windows.Forms.Label();
            this.GCijena = new System.Windows.Forms.Label();
            this.GNaziv = new System.Windows.Forms.Label();
            this.nCijena = new System.Windows.Forms.NumericUpDown();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.rtOpis = new System.Windows.Forms.RichTextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.GKategorija);
            this.groupBox1.Controls.Add(this.GCijena);
            this.groupBox1.Controls.Add(this.GNaziv);
            this.groupBox1.Controls.Add(this.nCijena);
            this.groupBox1.Controls.Add(this.cbKategorija);
            this.groupBox1.Controls.Add(this.rtOpis);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova usluga";
            // 
            // GKategorija
            // 
            this.GKategorija.AutoSize = true;
            this.GKategorija.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GKategorija.ForeColor = System.Drawing.Color.Red;
            this.GKategorija.Location = new System.Drawing.Point(123, 269);
            this.GKategorija.Name = "GKategorija";
            this.GKategorija.Size = new System.Drawing.Size(95, 13);
            this.GKategorija.TabIndex = 8;
            this.GKategorija.Text = "Obavezno polje";
            this.GKategorija.Visible = false;
            // 
            // GCijena
            // 
            this.GCijena.AutoSize = true;
            this.GCijena.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCijena.ForeColor = System.Drawing.Color.Red;
            this.GCijena.Location = new System.Drawing.Point(113, 134);
            this.GCijena.Name = "GCijena";
            this.GCijena.Size = new System.Drawing.Size(125, 13);
            this.GCijena.TabIndex = 7;
            this.GCijena.Text = "Cijena ne moze biti 0";
            this.GCijena.Visible = false;
            // 
            // GNaziv
            // 
            this.GNaziv.AutoSize = true;
            this.GNaziv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNaziv.ForeColor = System.Drawing.Color.Red;
            this.GNaziv.Location = new System.Drawing.Point(113, 70);
            this.GNaziv.Name = "GNaziv";
            this.GNaziv.Size = new System.Drawing.Size(95, 13);
            this.GNaziv.TabIndex = 6;
            this.GNaziv.Text = "Obavezno polje";
            this.GNaziv.Visible = false;
            // 
            // nCijena
            // 
            this.nCijena.Location = new System.Drawing.Point(116, 108);
            this.nCijena.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCijena.Name = "nCijena";
            this.nCijena.Size = new System.Drawing.Size(168, 23);
            this.nCijena.TabIndex = 5;
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(125, 242);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(159, 24);
            this.cbKategorija.TabIndex = 4;
            // 
            // rtOpis
            // 
            this.rtOpis.Location = new System.Drawing.Point(116, 168);
            this.rtOpis.Name = "rtOpis";
            this.rtOpis.Size = new System.Drawing.Size(169, 43);
            this.rtOpis.TabIndex = 3;
            this.rtOpis.Text = "";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(116, 44);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(169, 23);
            this.txtNaziv.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSacuvaj.Location = new System.Drawing.Point(59, 295);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(185, 29);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategorija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cijena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // frmNovaUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 361);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovaUsluga";
            this.Text = "frmNovaUsluga";
            this.Load += new System.EventHandler(this.frmNovaUsluga_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCijena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.RichTextBox rtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nCijena;
        private System.Windows.Forms.Label GCijena;
        private System.Windows.Forms.Label GNaziv;
        private System.Windows.Forms.Label GKategorija;
    }
}