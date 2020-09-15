namespace AutoSkola.WinUI.Kategorije
{
    partial class frmListaKategorija
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
            this.flpKategorije = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovaKategorija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpKategorije
            // 
            this.flpKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpKategorije.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.flpKategorije.Location = new System.Drawing.Point(-3, 37);
            this.flpKategorije.Name = "flpKategorije";
            this.flpKategorije.Size = new System.Drawing.Size(807, 396);
            this.flpKategorije.TabIndex = 0;
            // 
            // btnNovaKategorija
            // 
            this.btnNovaKategorija.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovaKategorija.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovaKategorija.Location = new System.Drawing.Point(12, 442);
            this.btnNovaKategorija.Name = "btnNovaKategorija";
            this.btnNovaKategorija.Size = new System.Drawing.Size(156, 30);
            this.btnNovaKategorija.TabIndex = 1;
            this.btnNovaKategorija.Text = "Evidentiraj kategoriju";
            this.btnNovaKategorija.UseVisualStyleBackColor = false;
            this.btnNovaKategorija.Click += new System.EventHandler(this.btnNovaKategorija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(358, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategorije";
            // 
            // frmListaKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovaKategorija);
            this.Controls.Add(this.flpKategorije);
            this.Name = "frmListaKategorija";
            this.Text = "frmListaKategorija";
            this.Load += new System.EventHandler(this.frmListaKategorija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKategorije;
        private System.Windows.Forms.Button btnNovaKategorija;
        private System.Windows.Forms.Label label1;
    }
}