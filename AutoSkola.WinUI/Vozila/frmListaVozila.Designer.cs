namespace AutoSkola.WinUI.Vozila
{
    partial class frmListaVozila
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
            this.flpListaVozila = new System.Windows.Forms.FlowLayoutPanel();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoVozilo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpListaVozila
            // 
            this.flpListaVozila.AutoScroll = true;
            this.flpListaVozila.Location = new System.Drawing.Point(5, 40);
            this.flpListaVozila.Name = "flpListaVozila";
            this.flpListaVozila.Size = new System.Drawing.Size(789, 393);
            this.flpListaVozila.TabIndex = 0;
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(27, 13);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(121, 21);
            this.cbMarka.TabIndex = 1;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vozila";
            // 
            // btnNovoVozilo
            // 
            this.btnNovoVozilo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovoVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoVozilo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovoVozilo.Location = new System.Drawing.Point(13, 442);
            this.btnNovoVozilo.Name = "btnNovoVozilo";
            this.btnNovoVozilo.Size = new System.Drawing.Size(155, 30);
            this.btnNovoVozilo.TabIndex = 3;
            this.btnNovoVozilo.Text = "Novo vozilo";
            this.btnNovoVozilo.UseVisualStyleBackColor = false;
            this.btnNovoVozilo.Click += new System.EventHandler(this.btnNovoVozilo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(24, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka";
            // 
            // frmListaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovoVozilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.flpListaVozila);
            this.Name = "frmListaVozila";
            this.Text = "frmListaVozila";
            this.Load += new System.EventHandler(this.frmListaVozila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListaVozila;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoVozilo;
        private System.Windows.Forms.Label label2;
    }
}