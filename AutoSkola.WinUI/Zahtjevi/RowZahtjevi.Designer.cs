namespace AutoSkola.WinUI.UserControls
{
    partial class RowZahtjevi
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
            this.lblUsluga = new System.Windows.Forms.Label();
            this.lblKandidat = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsluga
            // 
            this.lblUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsluga.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsluga.Location = new System.Drawing.Point(175, 14);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(155, 54);
            this.lblUsluga.TabIndex = 0;
            this.lblUsluga.Text = "label1";
            // 
            // lblKandidat
            // 
            this.lblKandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKandidat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKandidat.Location = new System.Drawing.Point(23, 14);
            this.lblKandidat.Name = "lblKandidat";
            this.lblKandidat.Size = new System.Drawing.Size(152, 54);
            this.lblKandidat.TabIndex = 0;
            this.lblKandidat.Text = "label1";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKategorija.Location = new System.Drawing.Point(336, 14);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(46, 17);
            this.lblKategorija.TabIndex = 0;
            this.lblKategorija.Text = "label1";
            // 
            // btnOdobri
            // 
            this.btnOdobri.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOdobri.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOdobri.Location = new System.Drawing.Point(630, 7);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(85, 31);
            this.btnOdobri.TabIndex = 1;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.BackColor = System.Drawing.Color.Red;
            this.btnOdbaci.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOdbaci.Location = new System.Drawing.Point(721, 7);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(76, 31);
            this.btnOdbaci.TabIndex = 1;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = false;
            this.btnOdbaci.Click += new System.EventHandler(this.btnOdbaci_Click);
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruktor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInstruktor.Location = new System.Drawing.Point(465, 14);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(150, 54);
            this.lblInstruktor.TabIndex = 0;
            this.lblInstruktor.Text = "label1";
            // 
            // RowZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.lblInstruktor);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblKandidat);
            this.Controls.Add(this.lblUsluga);
            this.Name = "RowZahtjevi";
            this.Size = new System.Drawing.Size(800, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.Label lblKandidat;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnOdbaci;
        private System.Windows.Forms.Label lblInstruktor;
    }
}
