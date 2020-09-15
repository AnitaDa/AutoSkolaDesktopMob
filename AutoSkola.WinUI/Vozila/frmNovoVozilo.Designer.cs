namespace AutoSkola.WinUI.Vozila
{
    partial class frmNovoVozilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoVozilo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GRegOznaka = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.txtRegOznaka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureVozilo = new System.Windows.Forms.PictureBox();
            this.ofdNovoVozilo = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.GRegOznaka);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.btnUcitajSliku);
            this.groupBox1.Controls.Add(this.cbModel);
            this.groupBox1.Controls.Add(this.cbKategorija);
            this.groupBox1.Controls.Add(this.txtRegOznaka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureVozilo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo vozilo";
            // 
            // GRegOznaka
            // 
            this.GRegOznaka.AutoSize = true;
            this.GRegOznaka.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GRegOznaka.ForeColor = System.Drawing.Color.Red;
            this.GRegOznaka.Location = new System.Drawing.Point(202, 200);
            this.GRegOznaka.Name = "GRegOznaka";
            this.GRegOznaka.Size = new System.Drawing.Size(107, 17);
            this.GRegOznaka.TabIndex = 5;
            this.GRegOznaka.Text = "Obavezno polje";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSacuvaj.Location = new System.Drawing.Point(186, 315);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(162, 32);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajSliku.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUcitajSliku.Location = new System.Drawing.Point(333, 230);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(63, 28);
            this.btnUcitajSliku.TabIndex = 4;
            this.btnUcitajSliku.Text = "...";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(42, 132);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(154, 24);
            this.cbModel.TabIndex = 3;
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(42, 66);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(154, 24);
            this.cbKategorija.TabIndex = 3;
            // 
            // txtRegOznaka
            // 
            this.txtRegOznaka.Location = new System.Drawing.Point(42, 197);
            this.txtRegOznaka.Name = "txtRegOznaka";
            this.txtRegOznaka.Size = new System.Drawing.Size(154, 23);
            this.txtRegOznaka.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Registarska oznaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategorija:";
            // 
            // pictureVozilo
            // 
            this.pictureVozilo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureVozilo.Image = ((System.Drawing.Image)(resources.GetObject("pictureVozilo.Image")));
            this.pictureVozilo.Location = new System.Drawing.Point(333, 31);
            this.pictureVozilo.Name = "pictureVozilo";
            this.pictureVozilo.Size = new System.Drawing.Size(187, 193);
            this.pictureVozilo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVozilo.TabIndex = 0;
            this.pictureVozilo.TabStop = false;
            // 
            // ofdNovoVozilo
            // 
            this.ofdNovoVozilo.FileName = "ofdNovoVozilo";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(402, 230);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(123, 23);
            this.txtFileName.TabIndex = 6;
            // 
            // frmNovoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 389);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovoVozilo";
            this.Text = "frmNovoVozilo";
            this.Load += new System.EventHandler(this.frmNovoVozilo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVozilo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.TextBox txtRegOznaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.OpenFileDialog ofdNovoVozilo;
        private System.Windows.Forms.Label GRegOznaka;
        private System.Windows.Forms.TextBox txtFileName;
    }
}