namespace AutoSkola.WinUI.Raspored_polganja.TerminiRasporedaPolaganja
{
    partial class RowTerminRasporedPolaganja
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
            this.lblKandidat = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKandidat
            // 
            this.lblKandidat.AutoSize = true;
            this.lblKandidat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKandidat.Location = new System.Drawing.Point(88, 12);
            this.lblKandidat.Name = "lblKandidat";
            this.lblKandidat.Size = new System.Drawing.Size(35, 13);
            this.lblKandidat.TabIndex = 0;
            this.lblKandidat.Text = "label1";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOd.Location = new System.Drawing.Point(260, 12);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(35, 13);
            this.lblOd.TabIndex = 0;
            this.lblOd.Text = "label1";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDo.Location = new System.Drawing.Point(452, 12);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(35, 13);
            this.lblDo.TabIndex = 0;
            this.lblDo.Text = "label1";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzmjeni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzmjeni.Location = new System.Drawing.Point(595, 6);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 29);
            this.btnIzmjeni.TabIndex = 1;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnObrisi.Location = new System.Drawing.Point(676, 7);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 28);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // RowTerminRasporedPolaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.lblKandidat);
            this.Name = "RowTerminRasporedPolaganja";
            this.Size = new System.Drawing.Size(798, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKandidat;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
