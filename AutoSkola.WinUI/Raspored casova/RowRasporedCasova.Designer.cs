namespace AutoSkola.WinUI.UserControls
{
    partial class RowRasporedCasova
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(3, 11);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(46, 17);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "label1";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOd.Location = new System.Drawing.Point(142, 11);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(46, 17);
            this.lblOd.TabIndex = 0;
            this.lblOd.Text = "label1";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDo.Location = new System.Drawing.Point(231, 11);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(46, 17);
            this.lblDo.TabIndex = 0;
            this.lblDo.Text = "label1";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzmjeni.Location = new System.Drawing.Point(468, 8);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 1;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVozilo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblVozilo.Location = new System.Drawing.Point(348, 11);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(46, 17);
            this.lblVozilo.TabIndex = 0;
            this.lblVozilo.Text = "label1";
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEvidentiraj.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEvidentiraj.Location = new System.Drawing.Point(468, 8);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(75, 31);
            this.btnEvidentiraj.TabIndex = 2;
            this.btnEvidentiraj.Text = "Evidentiraj";
            this.btnEvidentiraj.UseVisualStyleBackColor = false;
            this.btnEvidentiraj.Visible = false;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // RowRasporedCasova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.lblDatum);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "RowRasporedCasova";
            this.Size = new System.Drawing.Size(595, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Button btnEvidentiraj;
    }
}
