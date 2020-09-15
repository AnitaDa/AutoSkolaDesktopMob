namespace AutoSkola.WinUI.Raspored_polganja.TerminiRasporedaPolaganja
{
    partial class frmTerminRasporedaPolaganja
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
            this.flpTerminiRasporedaPolaganja = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoviTermin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpTerminiRasporedaPolaganja
            // 
            this.flpTerminiRasporedaPolaganja.AutoScroll = true;
            this.flpTerminiRasporedaPolaganja.Location = new System.Drawing.Point(0, 40);
            this.flpTerminiRasporedaPolaganja.Name = "flpTerminiRasporedaPolaganja";
            this.flpTerminiRasporedaPolaganja.Size = new System.Drawing.Size(798, 396);
            this.flpTerminiRasporedaPolaganja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termini polaganja";
            // 
            // btnNoviTermin
            // 
            this.btnNoviTermin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNoviTermin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNoviTermin.Location = new System.Drawing.Point(12, 442);
            this.btnNoviTermin.Name = "btnNoviTermin";
            this.btnNoviTermin.Size = new System.Drawing.Size(154, 32);
            this.btnNoviTermin.TabIndex = 2;
            this.btnNoviTermin.Text = "Evidentiraj novi termin";
            this.btnNoviTermin.UseVisualStyleBackColor = false;
            this.btnNoviTermin.Click += new System.EventHandler(this.btnNoviTermin_Click);
            // 
            // frmTerminRasporedaPolaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnNoviTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpTerminiRasporedaPolaganja);
            this.Name = "frmTerminRasporedaPolaganja";
            this.Text = "frmTerminRasporedaPolaganja";
            this.Load += new System.EventHandler(this.frmTerminRasporedaPolaganja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTerminiRasporedaPolaganja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoviTermin;
    }
}