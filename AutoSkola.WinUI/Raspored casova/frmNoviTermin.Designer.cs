namespace AutoSkola.WinUI.Raspored_casova
{
    partial class frmNoviTermin
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
            this.GInstruktor = new System.Windows.Forms.Label();
            this.checkBoxPrakticno = new System.Windows.Forms.CheckBox();
            this.checkBoxTeorija = new System.Windows.Forms.CheckBox();
            this.GKandidat = new System.Windows.Forms.Label();
            this.GVozilo = new System.Windows.Forms.Label();
            this.GDo = new System.Windows.Forms.Label();
            this.GOd = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbInstruktori = new System.Windows.Forms.ComboBox();
            this.cbKandidati = new System.Windows.Forms.ComboBox();
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GCheck = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.GCheck);
            this.groupBox1.Controls.Add(this.GInstruktor);
            this.groupBox1.Controls.Add(this.checkBoxPrakticno);
            this.groupBox1.Controls.Add(this.checkBoxTeorija);
            this.groupBox1.Controls.Add(this.GKandidat);
            this.groupBox1.Controls.Add(this.GVozilo);
            this.groupBox1.Controls.Add(this.GDo);
            this.groupBox1.Controls.Add(this.GOd);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.cbInstruktori);
            this.groupBox1.Controls.Add(this.cbKandidati);
            this.groupBox1.Controls.Add(this.cbVozilo);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.txtDo);
            this.groupBox1.Controls.Add(this.txtOd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi termin";
            // 
            // GInstruktor
            // 
            this.GInstruktor.AutoSize = true;
            this.GInstruktor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GInstruktor.ForeColor = System.Drawing.Color.Red;
            this.GInstruktor.Location = new System.Drawing.Point(198, 258);
            this.GInstruktor.Name = "GInstruktor";
            this.GInstruktor.Size = new System.Drawing.Size(95, 13);
            this.GInstruktor.TabIndex = 8;
            this.GInstruktor.Text = "Obavezno polje";
            this.GInstruktor.Visible = false;
            // 
            // checkBoxPrakticno
            // 
            this.checkBoxPrakticno.AutoSize = true;
            this.checkBoxPrakticno.Location = new System.Drawing.Point(208, 290);
            this.checkBoxPrakticno.Name = "checkBoxPrakticno";
            this.checkBoxPrakticno.Size = new System.Drawing.Size(95, 21);
            this.checkBoxPrakticno.TabIndex = 7;
            this.checkBoxPrakticno.Text = "Prakticno";
            this.checkBoxPrakticno.UseVisualStyleBackColor = true;
            // 
            // checkBoxTeorija
            // 
            this.checkBoxTeorija.AutoSize = true;
            this.checkBoxTeorija.Location = new System.Drawing.Point(58, 290);
            this.checkBoxTeorija.Name = "checkBoxTeorija";
            this.checkBoxTeorija.Size = new System.Drawing.Size(78, 21);
            this.checkBoxTeorija.TabIndex = 6;
            this.checkBoxTeorija.Text = "Teorija";
            this.checkBoxTeorija.UseVisualStyleBackColor = true;
            // 
            // GKandidat
            // 
            this.GKandidat.AutoSize = true;
            this.GKandidat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GKandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GKandidat.ForeColor = System.Drawing.Color.Red;
            this.GKandidat.Location = new System.Drawing.Point(60, 258);
            this.GKandidat.Name = "GKandidat";
            this.GKandidat.Size = new System.Drawing.Size(95, 13);
            this.GKandidat.TabIndex = 5;
            this.GKandidat.Text = "Obavezno polje";
            this.GKandidat.Visible = false;
            // 
            // GVozilo
            // 
            this.GVozilo.AutoSize = true;
            this.GVozilo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVozilo.ForeColor = System.Drawing.Color.Red;
            this.GVozilo.Location = new System.Drawing.Point(195, 183);
            this.GVozilo.Name = "GVozilo";
            this.GVozilo.Size = new System.Drawing.Size(95, 13);
            this.GVozilo.TabIndex = 5;
            this.GVozilo.Text = "Obavezno polje";
            this.GVozilo.Visible = false;
            // 
            // GDo
            // 
            this.GDo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDo.ForeColor = System.Drawing.Color.Red;
            this.GDo.Location = new System.Drawing.Point(195, 88);
            this.GDo.Name = "GDo";
            this.GDo.Size = new System.Drawing.Size(103, 28);
            this.GDo.TabIndex = 5;
            this.GDo.Text = "Obavezno polje";
            this.GDo.Visible = false;
            // 
            // GOd
            // 
            this.GOd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOd.ForeColor = System.Drawing.Color.Red;
            this.GOd.Location = new System.Drawing.Point(60, 88);
            this.GOd.Name = "GOd";
            this.GOd.Size = new System.Drawing.Size(102, 28);
            this.GOd.TabIndex = 5;
            this.GOd.Text = "Obavezno polje";
            this.GOd.Visible = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSacuvaj.Location = new System.Drawing.Point(99, 362);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(196, 33);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbInstruktori
            // 
            this.cbInstruktori.FormattingEnabled = true;
            this.cbInstruktori.Location = new System.Drawing.Point(198, 231);
            this.cbInstruktori.Name = "cbInstruktori";
            this.cbInstruktori.Size = new System.Drawing.Size(135, 24);
            this.cbInstruktori.TabIndex = 3;
            // 
            // cbKandidati
            // 
            this.cbKandidati.FormattingEnabled = true;
            this.cbKandidati.Location = new System.Drawing.Point(57, 231);
            this.cbKandidati.Name = "cbKandidati";
            this.cbKandidati.Size = new System.Drawing.Size(135, 24);
            this.cbKandidati.TabIndex = 3;
            // 
            // cbVozilo
            // 
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(198, 150);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(135, 24);
            this.cbVozilo.TabIndex = 3;
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(62, 150);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(100, 23);
            this.dtpDatum.TabIndex = 2;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(198, 62);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(100, 23);
            this.txtDo.TabIndex = 1;
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(62, 62);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(100, 23);
            this.txtOd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(195, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Instruktor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(54, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kandidat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(195, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vozilo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(59, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(195, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od";
            // 
            // GCheck
            // 
            this.GCheck.AutoSize = true;
            this.GCheck.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.GCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCheck.ForeColor = System.Drawing.Color.Red;
            this.GCheck.Location = new System.Drawing.Point(91, 314);
            this.GCheck.Name = "GCheck";
            this.GCheck.Size = new System.Drawing.Size(0, 13);
            this.GCheck.TabIndex = 9;
            this.GCheck.Visible = false;
            // 
            // frmNoviTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNoviTermin";
            this.Text = "frmNoviTermin";
            this.Load += new System.EventHandler(this.frmNoviTermin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbVozilo;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.ComboBox cbKandidati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GKandidat;
        private System.Windows.Forms.Label GVozilo;
        private System.Windows.Forms.Label GDo;
        private System.Windows.Forms.Label GOd;
        private System.Windows.Forms.ComboBox cbInstruktori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxPrakticno;
        private System.Windows.Forms.CheckBox checkBoxTeorija;
        private System.Windows.Forms.Label GInstruktor;
        private System.Windows.Forms.Label GCheck;
    }
}