namespace AutoSkola.WinUI.Pocetna
{
    partial class frmPocetnaKartica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flpNoviZahtjevi = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGodinaUplata = new System.Windows.Forms.ComboBox();
            this.cbGodinaUpis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartUplate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUpis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartUplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUpis)).BeginInit();
            this.SuspendLayout();
            // 
            // flpNoviZahtjevi
            // 
            this.flpNoviZahtjevi.AutoScroll = true;
            this.flpNoviZahtjevi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpNoviZahtjevi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpNoviZahtjevi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.flpNoviZahtjevi.Location = new System.Drawing.Point(610, 75);
            this.flpNoviZahtjevi.Name = "flpNoviZahtjevi";
            this.flpNoviZahtjevi.Size = new System.Drawing.Size(227, 377);
            this.flpNoviZahtjevi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(606, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novi zahtjevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(322, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Statistika uplata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(41, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statistika zahtjeva";
            // 
            // cbGodinaUplata
            // 
            this.cbGodinaUplata.FormattingEnabled = true;
            this.cbGodinaUplata.Location = new System.Drawing.Point(387, 70);
            this.cbGodinaUplata.Name = "cbGodinaUplata";
            this.cbGodinaUplata.Size = new System.Drawing.Size(86, 21);
            this.cbGodinaUplata.TabIndex = 4;
            this.cbGodinaUplata.SelectedIndexChanged += new System.EventHandler(this.cbGodinaUplata_SelectedIndexChanged);
            // 
            // cbGodinaUpis
            // 
            this.cbGodinaUpis.FormattingEnabled = true;
            this.cbGodinaUpis.Location = new System.Drawing.Point(106, 69);
            this.cbGodinaUpis.Name = "cbGodinaUpis";
            this.cbGodinaUpis.Size = new System.Drawing.Size(84, 21);
            this.cbGodinaUpis.TabIndex = 4;
            this.cbGodinaUpis.SelectedIndexChanged += new System.EventHandler(this.cbGodinaUpis_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(42, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Godina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(323, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Godina:";
            // 
            // chartUplate
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUplate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUplate.Legends.Add(legend1);
            this.chartUplate.Location = new System.Drawing.Point(276, 116);
            this.chartUplate.Name = "chartUplate";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "IznosUplata";
            this.chartUplate.Series.Add(series1);
            this.chartUplate.Size = new System.Drawing.Size(328, 336);
            this.chartUplate.TabIndex = 6;
            this.chartUplate.Text = "chart1";
            // 
            // chartUpis
            // 
            chartArea2.Name = "ChartArea1";
            this.chartUpis.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartUpis.Legends.Add(legend2);
            this.chartUpis.Location = new System.Drawing.Point(-9, 116);
            this.chartUpis.Name = "chartUpis";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "BrojZahtjeva";
            this.chartUpis.Series.Add(series2);
            this.chartUpis.Size = new System.Drawing.Size(303, 348);
            this.chartUpis.TabIndex = 7;
            this.chartUpis.Text = "chart1";
            // 
            // frmPocetnaKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 496);
            this.Controls.Add(this.chartUplate);
            this.Controls.Add(this.chartUpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGodinaUpis);
            this.Controls.Add(this.cbGodinaUplata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpNoviZahtjevi);
            this.Name = "frmPocetnaKartica";
            this.Text = "frmPocetnaKartica";
            this.Load += new System.EventHandler(this.frmPocetnaKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUpis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpNoviZahtjevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGodinaUplata;
        private System.Windows.Forms.ComboBox cbGodinaUpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUplate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUpis;
    }
}