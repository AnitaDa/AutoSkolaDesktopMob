namespace AutoSkola.WinUI.Potvrde
{
    partial class frmListaPotvrda
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
            this.flpListaPotvrda = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpListaPotvrda
            // 
            this.flpListaPotvrda.Location = new System.Drawing.Point(0, 47);
            this.flpListaPotvrda.Name = "flpListaPotvrda";
            this.flpListaPotvrda.Size = new System.Drawing.Size(800, 430);
            this.flpListaPotvrda.TabIndex = 0;
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(13, 13);
            this.dtpDatumPolaganja.MaxDate = new System.DateTime(2105, 12, 25, 0, 0, 0, 0);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(102, 20);
            this.dtpDatumPolaganja.TabIndex = 1;
            this.dtpDatumPolaganja.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDatumPolaganja.ValueChanged += new System.EventHandler(this.dtpDatumPolaganja_ValueChanged);
            this.dtpDatumPolaganja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDatumPolaganja_KeyDown);
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(132, 13);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbKategorija.TabIndex = 2;
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista potvrda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(129, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategorija";
            // 
            // frmListaPotvrda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Controls.Add(this.flpListaPotvrda);
            this.Name = "frmListaPotvrda";
            this.Text = "frmListaPotvrda";
            this.Load += new System.EventHandler(this.frmListaPotvrda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListaPotvrda;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}