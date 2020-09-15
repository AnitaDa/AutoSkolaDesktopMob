namespace AutoSkola.WinUI.Potvrde
{
    partial class RowPotvrda
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
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblPotvrduIzdao = new System.Windows.Forms.Label();
            this.lblDatumPolaganja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKandidat
            // 
            this.lblKandidat.AutoSize = true;
            this.lblKandidat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKandidat.Location = new System.Drawing.Point(49, 17);
            this.lblKandidat.Name = "lblKandidat";
            this.lblKandidat.Size = new System.Drawing.Size(35, 13);
            this.lblKandidat.TabIndex = 0;
            this.lblKandidat.Text = "label1";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKategorija.Location = new System.Drawing.Point(469, 17);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(35, 13);
            this.lblKategorija.TabIndex = 0;
            this.lblKategorija.Text = "label1";
            // 
            // lblPotvrduIzdao
            // 
            this.lblPotvrduIzdao.AutoSize = true;
            this.lblPotvrduIzdao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPotvrduIzdao.Location = new System.Drawing.Point(636, 17);
            this.lblPotvrduIzdao.Name = "lblPotvrduIzdao";
            this.lblPotvrduIzdao.Size = new System.Drawing.Size(35, 13);
            this.lblPotvrduIzdao.TabIndex = 0;
            this.lblPotvrduIzdao.Text = "label1";
            // 
            // lblDatumPolaganja
            // 
            this.lblDatumPolaganja.AutoSize = true;
            this.lblDatumPolaganja.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatumPolaganja.Location = new System.Drawing.Point(276, 17);
            this.lblDatumPolaganja.Name = "lblDatumPolaganja";
            this.lblDatumPolaganja.Size = new System.Drawing.Size(35, 13);
            this.lblDatumPolaganja.TabIndex = 0;
            this.lblDatumPolaganja.Text = "label1";
            // 
            // RowPotvrda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lblPotvrduIzdao);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblDatumPolaganja);
            this.Controls.Add(this.lblKandidat);
            this.Name = "RowPotvrda";
            this.Size = new System.Drawing.Size(808, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKandidat;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblPotvrduIzdao;
        private System.Windows.Forms.Label lblDatumPolaganja;
    }
}
