﻿namespace AutoSkola.WinUI.Uplate
{
    partial class frmNavBarUplat
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
            this.novaUplataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaUplataToolStripMenuItem,
            this.izvještajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaUplataToolStripMenuItem
            // 
            this.novaUplataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.novaUplataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.novaUplataToolStripMenuItem.Name = "novaUplataToolStripMenuItem";
            this.novaUplataToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.novaUplataToolStripMenuItem.Text = "Nova uplata";
            this.novaUplataToolStripMenuItem.Click += new System.EventHandler(this.novaUplataToolStripMenuItem_Click);
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.izvještajToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.izvještajToolStripMenuItem.Text = "Izvještaj";
            this.izvještajToolStripMenuItem.Click += new System.EventHandler(this.izvještajToolStripMenuItem_Click);
            // 
            // frmNavBarUplat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 35);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNavBarUplat";
            this.Text = "frmNavBarUplat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaUplataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajToolStripMenuItem;
    }
}