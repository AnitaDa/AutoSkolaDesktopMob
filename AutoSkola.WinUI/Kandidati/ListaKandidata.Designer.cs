namespace AutoSkola.WinUI.UserControls
{
    partial class ListaKandidata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaKandidata));
            this.lblKandidat = new System.Windows.Forms.Label();
            this.slikaKandidata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikaKandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKandidat
            // 
            this.lblKandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKandidat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKandidat.Location = new System.Drawing.Point(3, 126);
            this.lblKandidat.Name = "lblKandidat";
            this.lblKandidat.Size = new System.Drawing.Size(141, 25);
            this.lblKandidat.TabIndex = 0;
            this.lblKandidat.Text = "Ime prezime";
            // 
            // slikaKandidata
            // 
            this.slikaKandidata.Image = ((System.Drawing.Image)(resources.GetObject("slikaKandidata.Image")));
            this.slikaKandidata.InitialImage = ((System.Drawing.Image)(resources.GetObject("slikaKandidata.InitialImage")));
            this.slikaKandidata.Location = new System.Drawing.Point(0, 4);
            this.slikaKandidata.Name = "slikaKandidata";
            this.slikaKandidata.Size = new System.Drawing.Size(146, 119);
            this.slikaKandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slikaKandidata.TabIndex = 1;
            this.slikaKandidata.TabStop = false;
            this.slikaKandidata.Click += new System.EventHandler(this.slikaKandidata_Click);
            // 
            // ListaKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.slikaKandidata);
            this.Controls.Add(this.lblKandidat);
            this.Name = "ListaKandidata";
            this.Size = new System.Drawing.Size(147, 154);
            ((System.ComponentModel.ISupportInitialize)(this.slikaKandidata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKandidat;
        private System.Windows.Forms.PictureBox slikaKandidata;
    }
}
