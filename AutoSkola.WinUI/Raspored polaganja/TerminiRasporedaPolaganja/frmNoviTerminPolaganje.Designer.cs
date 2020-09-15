namespace AutoSkola.WinUI.Raspored_polaganja.TerminiRasporedaPolaganja
{
    partial class frmNoviTerminPolaganje
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
            this.cbKandidat = new System.Windows.Forms.ComboBox();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.cbKandidat);
            this.groupBox1.Controls.Add(this.txtDo);
            this.groupBox1.Controls.Add(this.txtOd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi termin";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSacuvaj.Location = new System.Drawing.Point(69, 216);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(183, 29);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbKandidat
            // 
            this.cbKandidat.FormattingEnabled = true;
            this.cbKandidat.Location = new System.Drawing.Point(104, 156);
            this.cbKandidat.Name = "cbKandidat";
            this.cbKandidat.Size = new System.Drawing.Size(187, 24);
            this.cbKandidat.TabIndex = 2;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(104, 105);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(108, 23);
            this.txtDo.TabIndex = 1;
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(104, 61);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(108, 23);
            this.txtOd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kandidat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od:";
            // 
            // frmNoviTerminPolaganje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNoviTerminPolaganje";
            this.Text = "frmNoviTermin";
            this.Load += new System.EventHandler(this.frmNoviTermin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbKandidat;
        private System.Windows.Forms.TextBox txtDo;
    }
}