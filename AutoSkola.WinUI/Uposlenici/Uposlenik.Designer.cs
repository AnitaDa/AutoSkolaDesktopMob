namespace AutoSkola.WinUI.Uposlenici
{
    partial class Uposlenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uposlenik));
            this.pictureUposlenik = new System.Windows.Forms.PictureBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUposlenik)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureUposlenik
            // 
            this.pictureUposlenik.Image = ((System.Drawing.Image)(resources.GetObject("pictureUposlenik.Image")));
            this.pictureUposlenik.Location = new System.Drawing.Point(4, 4);
            this.pictureUposlenik.Name = "pictureUposlenik";
            this.pictureUposlenik.Size = new System.Drawing.Size(191, 176);
            this.pictureUposlenik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUposlenik.TabIndex = 0;
            this.pictureUposlenik.TabStop = false;
            this.pictureUposlenik.Click += new System.EventHandler(this.pictureUposlenik_Click);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblImePrezime.Location = new System.Drawing.Point(14, 183);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(170, 44);
            this.lblImePrezime.TabIndex = 1;
            this.lblImePrezime.Text = "label1";
            // 
            // Uposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.pictureUposlenik);
            this.Name = "Uposlenik";
            this.Size = new System.Drawing.Size(198, 227);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUposlenik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureUposlenik;
        private System.Windows.Forms.Label lblImePrezime;
    }
}
