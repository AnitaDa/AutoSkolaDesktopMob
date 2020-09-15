namespace AutoSkola.WinUI.Kategorije
{
    partial class frmNovaKategorija
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.rtOpis = new System.Windows.Forms.RichTextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Poruka = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.Poruka);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.rtOpis);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova kategorija";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSacuvaj.Location = new System.Drawing.Point(56, 220);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(154, 27);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // rtOpis
            // 
            this.rtOpis.Location = new System.Drawing.Point(84, 112);
            this.rtOpis.Name = "rtOpis";
            this.rtOpis.Size = new System.Drawing.Size(146, 63);
            this.rtOpis.TabIndex = 2;
            this.rtOpis.Text = "";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(84, 54);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(146, 23);
            this.txtNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // Poruka
            // 
            this.Poruka.AutoSize = true;
            this.Poruka.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Poruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poruka.ForeColor = System.Drawing.Color.Red;
            this.Poruka.Location = new System.Drawing.Point(81, 80);
            this.Poruka.Name = "Poruka";
            this.Poruka.Size = new System.Drawing.Size(81, 13);
            this.Poruka.TabIndex = 4;
            this.Poruka.Text = "Obavezno polje";
            this.Poruka.Visible = false;
            // 
            // frmNovaKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 270);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovaKategorija";
            this.Text = "frmNovaKategorija";
            this.Load += new System.EventHandler(this.frmNovaKategorija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.RichTextBox rtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Poruka;
    }
}