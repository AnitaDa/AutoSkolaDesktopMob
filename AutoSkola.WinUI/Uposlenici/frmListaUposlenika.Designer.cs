namespace AutoSkola.WinUI.Uposlenici
{
    partial class frmListaUposlenika
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
            this.flpUposlenici = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUposlenik = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUposlenik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpUposlenici
            // 
            this.flpUposlenici.AutoScroll = true;
            this.flpUposlenici.Location = new System.Drawing.Point(-1, 45);
            this.flpUposlenici.Name = "flpUposlenici";
            this.flpUposlenici.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.flpUposlenici.Size = new System.Drawing.Size(798, 396);
            this.flpUposlenici.TabIndex = 0;
            // 
            // txtUposlenik
            // 
            this.txtUposlenik.Location = new System.Drawing.Point(564, 13);
            this.txtUposlenik.Name = "txtUposlenik";
            this.txtUposlenik.Size = new System.Drawing.Size(142, 20);
            this.txtUposlenik.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(712, 11);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(346, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uposlenici";
            // 
            // btnUposlenik
            // 
            this.btnUposlenik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUposlenik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUposlenik.Location = new System.Drawing.Point(12, 447);
            this.btnUposlenik.Name = "btnUposlenik";
            this.btnUposlenik.Size = new System.Drawing.Size(149, 30);
            this.btnUposlenik.TabIndex = 4;
            this.btnUposlenik.Text = "Novi uposlenik";
            this.btnUposlenik.UseVisualStyleBackColor = false;
            this.btnUposlenik.Click += new System.EventHandler(this.btnUposlenik_Click);
            // 
            // frmListaUposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnUposlenik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtUposlenik);
            this.Controls.Add(this.flpUposlenici);
            this.Name = "frmListaUposlenika";
            this.Text = "frmListaUposlenika";
            this.Load += new System.EventHandler(this.frmListaUposlenika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUposlenici;
        private System.Windows.Forms.TextBox txtUposlenik;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUposlenik;
    }
}