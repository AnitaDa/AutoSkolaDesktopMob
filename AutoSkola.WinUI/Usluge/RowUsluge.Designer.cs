namespace AutoSkola.WinUI.Usluge
{
    partial class RowUsluge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNaziv.Location = new System.Drawing.Point(13, 13);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(35, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "label1";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCijena.Location = new System.Drawing.Point(503, 13);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(35, 13);
            this.lblCijena.TabIndex = 0;
            this.lblCijena.Text = "label1";
            // 
            // lblKategorija
            // 
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKategorija.Location = new System.Drawing.Point(371, 13);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(89, 20);
            this.lblKategorija.TabIndex = 0;
            this.lblKategorija.Text = "label1";
            // 
            // lblOpis
            // 
            this.lblOpis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOpis.Location = new System.Drawing.Point(169, 13);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(169, 64);
            this.lblOpis.TabIndex = 0;
            this.lblOpis.Text = "label1";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzmjeni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzmjeni.Location = new System.Drawing.Point(585, 5);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 28);
            this.btnIzmjeni.TabIndex = 1;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnObrisi.Location = new System.Drawing.Point(666, 5);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 28);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // RowUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblNaziv);
            this.Name = "RowUsluge";
            this.Size = new System.Drawing.Size(776, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
