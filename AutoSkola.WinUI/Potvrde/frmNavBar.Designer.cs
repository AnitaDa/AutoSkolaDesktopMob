namespace AutoSkola.WinUI.Potvrde
{
    partial class frmNavBar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaPotvrdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPotvrdaToolStripMenuItem,
            this.izvještajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaPotvrdaToolStripMenuItem
            // 
            this.novaPotvrdaToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.novaPotvrdaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.novaPotvrdaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.novaPotvrdaToolStripMenuItem.Name = "novaPotvrdaToolStripMenuItem";
            this.novaPotvrdaToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.novaPotvrdaToolStripMenuItem.Text = "Nova potvrda";
            this.novaPotvrdaToolStripMenuItem.Click += new System.EventHandler(this.novaPotvrdaToolStripMenuItem_Click);
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.izvještajToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.izvještajToolStripMenuItem.Text = "Izvještaj";
            this.izvještajToolStripMenuItem.Click += new System.EventHandler(this.izvještajToolStripMenuItem_Click);
            // 
            // frmNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 33);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNavBar";
            this.Text = "frmNavBar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaPotvrdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajToolStripMenuItem;
    }
}