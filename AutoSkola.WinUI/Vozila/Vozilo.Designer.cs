namespace AutoSkola.WinUI.Vozila
{
    partial class Vozilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vozilo));
            this.pictureVozilo = new System.Windows.Forms.PictureBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblRegOznaka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureVozilo
            // 
            this.pictureVozilo.Image = ((System.Drawing.Image)(resources.GetObject("pictureVozilo.Image")));
            this.pictureVozilo.Location = new System.Drawing.Point(4, 4);
            this.pictureVozilo.Name = "pictureVozilo";
            this.pictureVozilo.Size = new System.Drawing.Size(227, 194);
            this.pictureVozilo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVozilo.TabIndex = 0;
            this.pictureVozilo.TabStop = false;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDetalji.Location = new System.Drawing.Point(32, 194);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(85, 34);
            this.btnDetalji.TabIndex = 1;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(123, 194);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(84, 34);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblRegOznaka
            // 
            this.lblRegOznaka.AutoSize = true;
            this.lblRegOznaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegOznaka.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRegOznaka.Location = new System.Drawing.Point(88, 168);
            this.lblRegOznaka.Name = "lblRegOznaka";
            this.lblRegOznaka.Size = new System.Drawing.Size(51, 20);
            this.lblRegOznaka.TabIndex = 2;
            this.lblRegOznaka.Text = "label1";
            // 
            // Vozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblRegOznaka);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.pictureVozilo);
            this.Name = "Vozilo";
            this.Size = new System.Drawing.Size(234, 231);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVozilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureVozilo;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblRegOznaka;
    }
}
