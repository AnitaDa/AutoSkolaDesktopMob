namespace AutoSkola.WinUI.Zahtjevi
{
    partial class frmZahtjevi
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
            this.flowLayoutZahtjevi = new System.Windows.Forms.FlowLayoutPanel();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutZahtjevi
            // 
            this.flowLayoutZahtjevi.AutoScroll = true;
            this.flowLayoutZahtjevi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutZahtjevi.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutZahtjevi.Name = "flowLayoutZahtjevi";
            this.flowLayoutZahtjevi.Size = new System.Drawing.Size(800, 434);
            this.flowLayoutZahtjevi.TabIndex = 0;
            // 
            // cbUsluga
            // 
            this.cbUsluga.DisplayMember = "Sve";
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(0, 22);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(152, 21);
            this.cbUsluga.TabIndex = 1;
            this.cbUsluga.ValueMember = "Sve";
            this.cbUsluga.SelectedIndexChanged += new System.EventHandler(this.cbUsluga_SelectedIndexChanged);
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(566, 23);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(138, 20);
            this.txtImePrezime.TabIndex = 2;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(713, 21);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zahtjevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usluga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(563, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kandidat";
            // 
            // frmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.flowLayoutZahtjevi);
            this.Name = "frmZahtjevi";
            this.Text = "frmZahtjevi";
            this.Load += new System.EventHandler(this.frmZahtjevi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutZahtjevi;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}