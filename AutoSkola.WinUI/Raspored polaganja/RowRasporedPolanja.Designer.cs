namespace AutoSkola.WinUI.Raspored_polganja
{
    partial class RowRasporedPolanja
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
            this.lblDatumPolaganja = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatumPolaganja
            // 
            this.lblDatumPolaganja.AutoSize = true;
            this.lblDatumPolaganja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumPolaganja.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatumPolaganja.Location = new System.Drawing.Point(105, 14);
            this.lblDatumPolaganja.Name = "lblDatumPolaganja";
            this.lblDatumPolaganja.Size = new System.Drawing.Size(46, 17);
            this.lblDatumPolaganja.TabIndex = 0;
            this.lblDatumPolaganja.Text = "label1";
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDetalji.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetalji.Location = new System.Drawing.Point(664, 4);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(84, 34);
            this.btnDetalji.TabIndex = 1;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // RowRasporedPolanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.lblDatumPolaganja);
            this.Name = "RowRasporedPolanja";
            this.Size = new System.Drawing.Size(776, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumPolaganja;
        private System.Windows.Forms.Button btnDetalji;
    }
}
