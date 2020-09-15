namespace AutoSkola.WinUI.UserControls
{
    partial class ListaUplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUplata));
            this.SlikaKandidata = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblSvrha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SlikaKandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // SlikaKandidata
            // 
            this.SlikaKandidata.Image = ((System.Drawing.Image)(resources.GetObject("SlikaKandidata.Image")));
            this.SlikaKandidata.InitialImage = ((System.Drawing.Image)(resources.GetObject("SlikaKandidata.InitialImage")));
            this.SlikaKandidata.Location = new System.Drawing.Point(5, 4);
            this.SlikaKandidata.Name = "SlikaKandidata";
            this.SlikaKandidata.Size = new System.Drawing.Size(104, 101);
            this.SlikaKandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SlikaKandidata.TabIndex = 0;
            this.SlikaKandidata.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(115, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kandidat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(115, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Svrha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(115, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Iznos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(115, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Datum:";
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(182, 13);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(35, 13);
            this.lblImePrezime.TabIndex = 2;
            this.lblImePrezime.Text = "label5";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(182, 58);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(35, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "label5";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(182, 80);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(35, 13);
            this.lblIznos.TabIndex = 2;
            this.lblIznos.Text = "label5";
            // 
            // lblSvrha
            // 
            this.lblSvrha.AutoSize = true;
            this.lblSvrha.Location = new System.Drawing.Point(182, 35);
            this.lblSvrha.Name = "lblSvrha";
            this.lblSvrha.Size = new System.Drawing.Size(35, 13);
            this.lblSvrha.TabIndex = 2;
            this.lblSvrha.Text = "label5";
            // 
            // ListaUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSvrha);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SlikaKandidata);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "ListaUplata";
            this.Size = new System.Drawing.Size(349, 106);
            ((System.ComponentModel.ISupportInitialize)(this.SlikaKandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SlikaKandidata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblSvrha;
    }
}
