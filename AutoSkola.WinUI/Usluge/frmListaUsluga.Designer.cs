namespace AutoSkola.WinUI.Usluge
{
    partial class frmListaUsluga
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
            this.flpUsluge = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovaUsluga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpUsluge
            // 
            this.flpUsluge.AutoScroll = true;
            this.flpUsluge.Location = new System.Drawing.Point(12, 44);
            this.flpUsluge.Name = "flpUsluge";
            this.flpUsluge.Size = new System.Drawing.Size(776, 386);
            this.flpUsluge.TabIndex = 0;
            // 
            // btnNovaUsluga
            // 
            this.btnNovaUsluga.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovaUsluga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovaUsluga.Location = new System.Drawing.Point(13, 442);
            this.btnNovaUsluga.Name = "btnNovaUsluga";
            this.btnNovaUsluga.Size = new System.Drawing.Size(167, 31);
            this.btnNovaUsluga.TabIndex = 2;
            this.btnNovaUsluga.Text = "Evidentiraj uslugu";
            this.btnNovaUsluga.UseVisualStyleBackColor = false;
            this.btnNovaUsluga.Click += new System.EventHandler(this.btnNovaUsluga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usluge";
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(13, 17);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(121, 21);
            this.cbKategorije.TabIndex = 4;
            this.cbKategorije.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            this.cbKategorije.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbKategorije_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategorija";
            // 
            // frmListaUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKategorije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovaUsluga);
            this.Controls.Add(this.flpUsluge);
            this.Name = "frmListaUsluga";
            this.Text = "frmListaUsluga";
            this.Load += new System.EventHandler(this.frmListaUsluga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUsluge;
        private System.Windows.Forms.Button btnNovaUsluga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategorije;
        private System.Windows.Forms.Label label2;
    }
}