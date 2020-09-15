namespace AutoSkola.WinUI.Uplate
{
    partial class frmNovaUplata
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
            System.Windows.Forms.GroupBox groupBox1;
            this.numericIznos = new System.Windows.Forms.NumericUpDown();
            this.dtpDatumUplate = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbKandidat = new System.Windows.Forms.ComboBox();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GSvrha = new System.Windows.Forms.Label();
            this.GIznos = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            groupBox1.Controls.Add(this.GIznos);
            groupBox1.Controls.Add(this.GSvrha);
            groupBox1.Controls.Add(this.numericIznos);
            groupBox1.Controls.Add(this.dtpDatumUplate);
            groupBox1.Controls.Add(this.btnSacuvaj);
            groupBox1.Controls.Add(this.cbKandidat);
            groupBox1.Controls.Add(this.txtSvrha);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.label2);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(355, 389);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova uplata";
            // 
            // numericIznos
            // 
            this.numericIznos.Location = new System.Drawing.Point(22, 70);
            this.numericIznos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericIznos.Name = "numericIznos";
            this.numericIznos.Size = new System.Drawing.Size(120, 23);
            this.numericIznos.TabIndex = 5;
            // 
            // dtpDatumUplate
            // 
            this.dtpDatumUplate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumUplate.Location = new System.Drawing.Point(22, 137);
            this.dtpDatumUplate.Name = "dtpDatumUplate";
            this.dtpDatumUplate.Size = new System.Drawing.Size(121, 23);
            this.dtpDatumUplate.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSacuvaj.Location = new System.Drawing.Point(88, 334);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(171, 30);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbKandidat
            // 
            this.cbKandidat.DisplayMember = "Id";
            this.cbKandidat.FormattingEnabled = true;
            this.cbKandidat.Location = new System.Drawing.Point(22, 271);
            this.cbKandidat.Name = "cbKandidat";
            this.cbKandidat.Size = new System.Drawing.Size(171, 24);
            this.cbKandidat.TabIndex = 2;
            this.cbKandidat.ValueMember = "Id";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(22, 205);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(171, 23);
            this.txtSvrha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(19, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kandidat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(19, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Svrha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datum uplate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznos";
            // 
            // GSvrha
            // 
            this.GSvrha.AutoSize = true;
            this.GSvrha.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GSvrha.ForeColor = System.Drawing.Color.Red;
            this.GSvrha.Location = new System.Drawing.Point(199, 205);
            this.GSvrha.Name = "GSvrha";
            this.GSvrha.Size = new System.Drawing.Size(121, 17);
            this.GSvrha.TabIndex = 6;
            this.GSvrha.Text = "Obavezno polje";
            this.GSvrha.Visible = false;
            // 
            // GIznos
            // 
            this.GIznos.AutoSize = true;
            this.GIznos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GIznos.ForeColor = System.Drawing.Color.Red;
            this.GIznos.Location = new System.Drawing.Point(148, 72);
            this.GIznos.Name = "GIznos";
            this.GIznos.Size = new System.Drawing.Size(153, 17);
            this.GIznos.TabIndex = 6;
            this.GIznos.Text = "Iznos ne moze biti 0";
            this.GIznos.Visible = false;
            // 
            // frmNovaUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 413);
            this.Controls.Add(groupBox1);
            this.Name = "frmNovaUplata";
            this.Text = "frmNovaUplata";
            this.Load += new System.EventHandler(this.frmNovaUplata_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIznos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumUplate;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbKandidat;
        private System.Windows.Forms.TextBox txtSvrha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericIznos;
        private System.Windows.Forms.Label GIznos;
        private System.Windows.Forms.Label GSvrha;
    }
}