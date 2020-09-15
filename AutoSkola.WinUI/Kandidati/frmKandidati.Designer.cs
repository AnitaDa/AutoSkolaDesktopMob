namespace AutoSkola.WinUI.Korisnici
{
    partial class frmKandidati
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.flowLayoutPanelKandidati = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(551, 13);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(141, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(698, 12);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 21);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // flowLayoutPanelKandidati
            // 
            this.flowLayoutPanelKandidati.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanelKandidati.Name = "flowLayoutPanelKandidati";
            this.flowLayoutPanelKandidati.Size = new System.Drawing.Size(802, 450);
            this.flowLayoutPanelKandidati.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(338, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kandidati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(548, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime prezime";
            // 
            // frmKandidati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelKandidati);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmKandidati";
            this.Text = "frmKandidati";
            this.Load += new System.EventHandler(this.frmKandidati_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKandidati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}