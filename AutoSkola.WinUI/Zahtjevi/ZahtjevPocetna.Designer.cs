namespace AutoSkola.WinUI.Zahtjevi
{
    partial class ZahtjevPocetna
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsluga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKandidat
            // 
            this.lblKandidat.AutoSize = true;
            this.lblKandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKandidat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKandidat.Location = new System.Drawing.Point(3, 11);
            this.lblKandidat.Name = "lblKandidat";
            this.lblKandidat.Size = new System.Drawing.Size(105, 22);
            this.lblKandidat.TabIndex = 0;
            this.lblKandidat.Text = "Ime prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usluga:";
            // 
            // lblUsluga
            // 
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsluga.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsluga.Location = new System.Drawing.Point(56, 33);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(52, 15);
            this.lblUsluga.TabIndex = 0;
            this.lblUsluga.Text = "Usluga";
            // 
            // ZahtjevPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblUsluga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKandidat);
            this.Name = "ZahtjevPocetna";
            this.Size = new System.Drawing.Size(217, 62);
            this.Click += new System.EventHandler(this.ZahtjevPocetna_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKandidat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsluga;
    }
}
