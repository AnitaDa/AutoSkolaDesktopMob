namespace AutoSkola.WinUI.Raspored_casova
{
    partial class frmRasporedCasova
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
            this.btnNoviTermin = new System.Windows.Forms.Button();
            this.dtpDatumTermina = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaKandidata = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.flpRasporedCasova = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKandidati = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNoviTermin
            // 
            this.btnNoviTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviTermin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNoviTermin.Location = new System.Drawing.Point(13, 441);
            this.btnNoviTermin.Name = "btnNoviTermin";
            this.btnNoviTermin.Size = new System.Drawing.Size(164, 30);
            this.btnNoviTermin.TabIndex = 2;
            this.btnNoviTermin.Text = "Evidentiraj novi termin";
            this.btnNoviTermin.UseVisualStyleBackColor = true;
            this.btnNoviTermin.Click += new System.EventHandler(this.btnNoviTermin_Click);
            // 
            // dtpDatumTermina
            // 
            this.dtpDatumTermina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumTermina.Location = new System.Drawing.Point(12, 9);
            this.dtpDatumTermina.Name = "dtpDatumTermina";
            this.dtpDatumTermina.Size = new System.Drawing.Size(98, 20);
            this.dtpDatumTermina.TabIndex = 3;
            this.dtpDatumTermina.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDatumTermina.ValueChanged += new System.EventHandler(this.dtpDatumTermina_ValueChanged);
            this.dtpDatumTermina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDatumTermina_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Raspored časova";
            // 
            // txtPretragaKandidata
            // 
            this.txtPretragaKandidata.Location = new System.Drawing.Point(603, 26);
            this.txtPretragaKandidata.Name = "txtPretragaKandidata";
            this.txtPretragaKandidata.Size = new System.Drawing.Size(113, 20);
            this.txtPretragaKandidata.TabIndex = 5;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(722, 24);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // flpRasporedCasova
            // 
            this.flpRasporedCasova.AutoScroll = true;
            this.flpRasporedCasova.Location = new System.Drawing.Point(13, 65);
            this.flpRasporedCasova.Name = "flpRasporedCasova";
            this.flpRasporedCasova.Size = new System.Drawing.Size(595, 370);
            this.flpRasporedCasova.TabIndex = 7;
            // 
            // flpKandidati
            // 
            this.flpKandidati.AutoScroll = true;
            this.flpKandidati.Location = new System.Drawing.Point(615, 65);
            this.flpKandidati.Name = "flpKandidati";
            this.flpKandidati.Size = new System.Drawing.Size(191, 370);
            this.flpKandidati.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nakon odabira datuma, odaberite kandidata, kako bi filtrirali termine\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(600, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ime prezime";
            // 
            // frmRasporedCasova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpKandidati);
            this.Controls.Add(this.flpRasporedCasova);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretragaKandidata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumTermina);
            this.Controls.Add(this.btnNoviTermin);
            this.Name = "frmRasporedCasova";
            this.Text = "frmRasporedCasova";
            this.Load += new System.EventHandler(this.frmRasporedCasova_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNoviTermin;
        private System.Windows.Forms.DateTimePicker dtpDatumTermina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaKandidata;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.FlowLayoutPanel flpRasporedCasova;
        private System.Windows.Forms.FlowLayoutPanel flpKandidati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}