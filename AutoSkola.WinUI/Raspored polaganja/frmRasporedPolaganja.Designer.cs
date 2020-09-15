namespace AutoSkola.WinUI.Raspored_polganja
{
    partial class frmRasporedPolaganja
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
            this.flpRasporedPolaganja = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNoviRaspored = new System.Windows.Forms.Button();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpRasporedPolaganja
            // 
            this.flpRasporedPolaganja.AutoScroll = true;
            this.flpRasporedPolaganja.Location = new System.Drawing.Point(12, 43);
            this.flpRasporedPolaganja.Name = "flpRasporedPolaganja";
            this.flpRasporedPolaganja.Size = new System.Drawing.Size(776, 403);
            this.flpRasporedPolaganja.TabIndex = 0;
            // 
            // btnNoviRaspored
            // 
            this.btnNoviRaspored.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNoviRaspored.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNoviRaspored.Location = new System.Drawing.Point(12, 452);
            this.btnNoviRaspored.Name = "btnNoviRaspored";
            this.btnNoviRaspored.Size = new System.Drawing.Size(159, 29);
            this.btnNoviRaspored.TabIndex = 1;
            this.btnNoviRaspored.Text = "Dodaj novi raspored";
            this.btnNoviRaspored.UseVisualStyleBackColor = false;
            this.btnNoviRaspored.Click += new System.EventHandler(this.btnNoviRaspored_Click);
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(13, 13);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(100, 20);
            this.dtpDatumPolaganja.TabIndex = 2;
            this.dtpDatumPolaganja.ValueChanged += new System.EventHandler(this.dtpDatumPolaganja_ValueChanged);
            this.dtpDatumPolaganja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDatumPolaganja_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raspored polaganja";
            // 
            // frmRasporedPolaganja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Controls.Add(this.btnNoviRaspored);
            this.Controls.Add(this.flpRasporedPolaganja);
            this.Name = "frmRasporedPolaganja";
            this.Text = "frmRasporedPolaganja";
            this.Load += new System.EventHandler(this.frmRasporedPolaganja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRasporedPolaganja;
        private System.Windows.Forms.Button btnNoviRaspored;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.Label label1;
    }
}