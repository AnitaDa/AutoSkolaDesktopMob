namespace AutoSkola.WinUI.Raspored_casova
{
    partial class ListaKandidataZaRaspored
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
            this.btnKandidat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKandidat
            // 
            this.btnKandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKandidat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnKandidat.Location = new System.Drawing.Point(0, 0);
            this.btnKandidat.Name = "btnKandidat";
            this.btnKandidat.Size = new System.Drawing.Size(177, 55);
            this.btnKandidat.TabIndex = 0;
            this.btnKandidat.Text = "Ime prezime";
            this.btnKandidat.UseVisualStyleBackColor = true;
            this.btnKandidat.Click += new System.EventHandler(this.btnKandidat_Click);
            // 
            // ListaKandidataZaRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKandidat);
            this.Name = "ListaKandidataZaRaspored";
            this.Size = new System.Drawing.Size(177, 55);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKandidat;
    }
}
