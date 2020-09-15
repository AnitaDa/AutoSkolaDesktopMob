namespace AutoSkola.WinUI.Uplate
{
    partial class frmUplate
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
            this.flowLayoutPanelUplate = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpUplate = new System.Windows.Forms.DateTimePicker();
            this.txtPretragaUplate = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelUplate
            // 
            this.flowLayoutPanelUplate.AutoScroll = true;
            this.flowLayoutPanelUplate.Location = new System.Drawing.Point(-8, 39);
            this.flowLayoutPanelUplate.Name = "flowLayoutPanelUplate";
            this.flowLayoutPanelUplate.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flowLayoutPanelUplate.Size = new System.Drawing.Size(814, 452);
            this.flowLayoutPanelUplate.TabIndex = 0;
            // 
            // dtpUplate
            // 
            this.dtpUplate.CustomFormat = " ";
            this.dtpUplate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUplate.Location = new System.Drawing.Point(12, 12);
            this.dtpUplate.MaxDate = new System.DateTime(2150, 12, 31, 0, 0, 0, 0);
            this.dtpUplate.Name = "dtpUplate";
            this.dtpUplate.Size = new System.Drawing.Size(110, 20);
            this.dtpUplate.TabIndex = 1;
            this.dtpUplate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpUplate.ValueChanged += new System.EventHandler(this.dtpUplate_ValueChanged);
            this.dtpUplate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpUplate_KeyDown);
            // 
            // txtPretragaUplate
            // 
            this.txtPretragaUplate.Location = new System.Drawing.Point(545, 13);
            this.txtPretragaUplate.Name = "txtPretragaUplate";
            this.txtPretragaUplate.Size = new System.Drawing.Size(160, 20);
            this.txtPretragaUplate.TabIndex = 2;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(711, 12);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(347, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uplate";
            // 
            // frmUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretragaUplate);
            this.Controls.Add(this.dtpUplate);
            this.Controls.Add(this.flowLayoutPanelUplate);
            this.Name = "frmUplate";
            this.Text = "frmUplate";
            this.Load += new System.EventHandler(this.frmUplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUplate;
        private System.Windows.Forms.DateTimePicker dtpUplate;
        private System.Windows.Forms.TextBox txtPretragaUplate;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label1;
    }
}