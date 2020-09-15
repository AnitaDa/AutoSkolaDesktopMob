namespace AutoSkola.WinUI.Kategorije
{
    partial class RowKategorije
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNaziv.Location = new System.Drawing.Point(30, 14);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(41, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "label1";
            // 
            // lblOpis
            // 
            this.lblOpis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOpis.Location = new System.Drawing.Point(103, 14);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(315, 29);
            this.lblOpis.TabIndex = 0;
            this.lblOpis.Text = "label1";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnObrisi.Location = new System.Drawing.Point(505, 6);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 29);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzmjeni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzmjeni.Location = new System.Drawing.Point(424, 6);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 29);
            this.btnIzmjeni.TabIndex = 1;
            this.btnIzmjeni.Text = "Izmijeni";
            this.btnIzmjeni.UseVisualStyleBackColor = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // RowKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Name = "RowKategorije";
            this.Size = new System.Drawing.Size(807, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmjeni;
    }
}
