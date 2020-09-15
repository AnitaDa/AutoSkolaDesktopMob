namespace AutoSkola.WinUI
{
    partial class frmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKorisnikEmail = new System.Windows.Forms.Label();
            this.lblOdjaviSe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKandidati = new XanderUI.XUIButton();
            this.btnUplate = new XanderUI.XUIButton();
            this.btnZahtjevi = new XanderUI.XUIButton();
            this.btnRasporedCasova = new XanderUI.XUIButton();
            this.btnRasporedPolaganja = new XanderUI.XUIButton();
            this.btnUsluge = new XanderUI.XUIButton();
            this.btnKategorije = new XanderUI.XUIButton();
            this.btnPotvrde = new XanderUI.XUIButton();
            this.panelReferent = new System.Windows.Forms.Panel();
            this.buttonInstruktor = new XanderUI.XUIButton();
            this.btnPocetnaKartica = new XanderUI.XUIButton();
            this.btnUposlenici = new XanderUI.XUIButton();
            this.btnVozila = new XanderUI.XUIButton();
            this.pnlPocetna = new System.Windows.Forms.Panel();
            this.pnlPomoc = new System.Windows.Forms.Panel();
            this.pnlInstruktor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelReferent.SuspendLayout();
            this.pnlInstruktor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pnlInstruktor);
            this.panel1.Controls.Add(this.lblKorisnikEmail);
            this.panel1.Controls.Add(this.lblOdjaviSe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 51);
            this.panel1.TabIndex = 0;
            // 
            // lblKorisnikEmail
            // 
            this.lblKorisnikEmail.AutoSize = true;
            this.lblKorisnikEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnikEmail.ForeColor = System.Drawing.Color.LightYellow;
            this.lblKorisnikEmail.Location = new System.Drawing.Point(825, 21);
            this.lblKorisnikEmail.Name = "lblKorisnikEmail";
            this.lblKorisnikEmail.Size = new System.Drawing.Size(113, 17);
            this.lblKorisnikEmail.TabIndex = 2;
            this.lblKorisnikEmail.Text = "emailKorisnika";
            this.lblKorisnikEmail.Click += new System.EventHandler(this.lblKorisnikEmail_Click);
            // 
            // lblOdjaviSe
            // 
            this.lblOdjaviSe.AutoSize = true;
            this.lblOdjaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdjaviSe.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblOdjaviSe.Location = new System.Drawing.Point(1027, 21);
            this.lblOdjaviSe.Name = "lblOdjaviSe";
            this.lblOdjaviSe.Size = new System.Drawing.Size(67, 17);
            this.lblOdjaviSe.TabIndex = 1;
            this.lblOdjaviSe.Text = "Odjavi se";
            this.lblOdjaviSe.Click += new System.EventHandler(this.lblOdjaviSe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "E Auto škola";
            // 
            // btnKandidati
            // 
            this.btnKandidati.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnKandidati.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnKandidati.ButtonImage")));
            this.btnKandidati.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnKandidati.ButtonText = "Kandidati";
            this.btnKandidati.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnKandidati.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnKandidati.CornerRadius = 5;
            this.btnKandidati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKandidati.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnKandidati.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnKandidati.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnKandidati.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnKandidati.Location = new System.Drawing.Point(11, 69);
            this.btnKandidati.Name = "btnKandidati";
            this.btnKandidati.Size = new System.Drawing.Size(200, 50);
            this.btnKandidati.TabIndex = 1;
            this.btnKandidati.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKandidati.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnKandidati.Click += new System.EventHandler(this.btnKandidati_Click);
            // 
            // btnUplate
            // 
            this.btnUplate.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnUplate.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUplate.ButtonImage")));
            this.btnUplate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUplate.ButtonText = "Uplate";
            this.btnUplate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUplate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUplate.CornerRadius = 5;
            this.btnUplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUplate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUplate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnUplate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUplate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUplate.Location = new System.Drawing.Point(11, 125);
            this.btnUplate.Name = "btnUplate";
            this.btnUplate.Size = new System.Drawing.Size(200, 50);
            this.btnUplate.TabIndex = 1;
            this.btnUplate.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUplate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUplate.Click += new System.EventHandler(this.btnUplate_Click);
            // 
            // btnZahtjevi
            // 
            this.btnZahtjevi.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnZahtjevi.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnZahtjevi.ButtonImage")));
            this.btnZahtjevi.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnZahtjevi.ButtonText = "Zahtjevi";
            this.btnZahtjevi.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnZahtjevi.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZahtjevi.CornerRadius = 5;
            this.btnZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZahtjevi.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZahtjevi.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnZahtjevi.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZahtjevi.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnZahtjevi.Location = new System.Drawing.Point(11, 181);
            this.btnZahtjevi.Name = "btnZahtjevi";
            this.btnZahtjevi.Size = new System.Drawing.Size(200, 50);
            this.btnZahtjevi.TabIndex = 1;
            this.btnZahtjevi.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZahtjevi.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZahtjevi.Click += new System.EventHandler(this.btnZahtjevi_Click);
            // 
            // btnRasporedCasova
            // 
            this.btnRasporedCasova.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnRasporedCasova.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRasporedCasova.ButtonImage")));
            this.btnRasporedCasova.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRasporedCasova.ButtonText = "Raspored časova";
            this.btnRasporedCasova.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnRasporedCasova.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRasporedCasova.CornerRadius = 5;
            this.btnRasporedCasova.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRasporedCasova.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRasporedCasova.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnRasporedCasova.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRasporedCasova.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRasporedCasova.Location = new System.Drawing.Point(11, 237);
            this.btnRasporedCasova.Name = "btnRasporedCasova";
            this.btnRasporedCasova.Size = new System.Drawing.Size(200, 50);
            this.btnRasporedCasova.TabIndex = 1;
            this.btnRasporedCasova.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRasporedCasova.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRasporedCasova.Click += new System.EventHandler(this.btnRasporedCasova_Click);
            // 
            // btnRasporedPolaganja
            // 
            this.btnRasporedPolaganja.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnRasporedPolaganja.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRasporedPolaganja.ButtonImage")));
            this.btnRasporedPolaganja.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRasporedPolaganja.ButtonText = "Raspored polaganja";
            this.btnRasporedPolaganja.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnRasporedPolaganja.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRasporedPolaganja.CornerRadius = 5;
            this.btnRasporedPolaganja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRasporedPolaganja.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRasporedPolaganja.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnRasporedPolaganja.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRasporedPolaganja.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRasporedPolaganja.Location = new System.Drawing.Point(11, 293);
            this.btnRasporedPolaganja.Name = "btnRasporedPolaganja";
            this.btnRasporedPolaganja.Size = new System.Drawing.Size(200, 50);
            this.btnRasporedPolaganja.TabIndex = 1;
            this.btnRasporedPolaganja.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRasporedPolaganja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRasporedPolaganja.Click += new System.EventHandler(this.btnRasporedPolaganja_Click);
            // 
            // btnUsluge
            // 
            this.btnUsluge.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsluge.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUsluge.ButtonImage")));
            this.btnUsluge.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUsluge.ButtonText = "Usluge";
            this.btnUsluge.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUsluge.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUsluge.CornerRadius = 5;
            this.btnUsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsluge.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUsluge.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnUsluge.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUsluge.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUsluge.Location = new System.Drawing.Point(11, 349);
            this.btnUsluge.Name = "btnUsluge";
            this.btnUsluge.Size = new System.Drawing.Size(200, 50);
            this.btnUsluge.TabIndex = 1;
            this.btnUsluge.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUsluge.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUsluge.Click += new System.EventHandler(this.btnUsluge_Click);
            // 
            // btnKategorije
            // 
            this.btnKategorije.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnKategorije.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnKategorije.ButtonImage")));
            this.btnKategorije.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnKategorije.ButtonText = "Kategorije";
            this.btnKategorije.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnKategorije.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnKategorije.CornerRadius = 5;
            this.btnKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategorije.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnKategorije.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnKategorije.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnKategorije.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnKategorije.Location = new System.Drawing.Point(11, 405);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Size = new System.Drawing.Size(200, 50);
            this.btnKategorije.TabIndex = 1;
            this.btnKategorije.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKategorije.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnPotvrde.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPotvrde.ButtonImage")));
            this.btnPotvrde.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPotvrde.ButtonText = "Potvrde";
            this.btnPotvrde.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnPotvrde.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPotvrde.CornerRadius = 5;
            this.btnPotvrde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrde.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPotvrde.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPotvrde.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPotvrde.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPotvrde.Location = new System.Drawing.Point(11, 461);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(200, 50);
            this.btnPotvrde.TabIndex = 1;
            this.btnPotvrde.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPotvrde.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            // 
            // panelReferent
            // 
            this.panelReferent.AutoScroll = true;
            this.panelReferent.Controls.Add(this.btnPocetnaKartica);
            this.panelReferent.Controls.Add(this.btnKandidati);
            this.panelReferent.Controls.Add(this.btnUposlenici);
            this.panelReferent.Controls.Add(this.btnVozila);
            this.panelReferent.Controls.Add(this.btnPotvrde);
            this.panelReferent.Controls.Add(this.btnUplate);
            this.panelReferent.Controls.Add(this.btnKategorije);
            this.panelReferent.Controls.Add(this.btnZahtjevi);
            this.panelReferent.Controls.Add(this.btnUsluge);
            this.panelReferent.Controls.Add(this.btnRasporedCasova);
            this.panelReferent.Controls.Add(this.btnRasporedPolaganja);
            this.panelReferent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReferent.Location = new System.Drawing.Point(0, 51);
            this.panelReferent.Name = "panelReferent";
            this.panelReferent.Size = new System.Drawing.Size(238, 640);
            this.panelReferent.TabIndex = 2;
            this.panelReferent.Visible = false;
            // 
            // buttonInstruktor
            // 
            this.buttonInstruktor.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInstruktor.ButtonImage = ((System.Drawing.Image)(resources.GetObject("buttonInstruktor.ButtonImage")));
            this.buttonInstruktor.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonInstruktor.ButtonText = "Raspored časova";
            this.buttonInstruktor.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonInstruktor.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonInstruktor.CornerRadius = 5;
            this.buttonInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstruktor.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonInstruktor.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttonInstruktor.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonInstruktor.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonInstruktor.Location = new System.Drawing.Point(0, -1);
            this.buttonInstruktor.Name = "buttonInstruktor";
            this.buttonInstruktor.Size = new System.Drawing.Size(197, 34);
            this.buttonInstruktor.TabIndex = 1;
            this.buttonInstruktor.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInstruktor.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonInstruktor.Visible = false;
            this.buttonInstruktor.Click += new System.EventHandler(this.btnRasporedCasova_Click);
            // 
            // btnPocetnaKartica
            // 
            this.btnPocetnaKartica.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnPocetnaKartica.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPocetnaKartica.ButtonImage")));
            this.btnPocetnaKartica.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnPocetnaKartica.ButtonText = "Početna";
            this.btnPocetnaKartica.ClickBackColor = System.Drawing.Color.Black;
            this.btnPocetnaKartica.ClickTextColor = System.Drawing.Color.Black;
            this.btnPocetnaKartica.CornerRadius = 5;
            this.btnPocetnaKartica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnPocetnaKartica.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPocetnaKartica.HoverBackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnPocetnaKartica.HoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.btnPocetnaKartica.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPocetnaKartica.Location = new System.Drawing.Point(11, 13);
            this.btnPocetnaKartica.Name = "btnPocetnaKartica";
            this.btnPocetnaKartica.Size = new System.Drawing.Size(200, 50);
            this.btnPocetnaKartica.TabIndex = 0;
            this.btnPocetnaKartica.TextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPocetnaKartica.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPocetnaKartica.Click += new System.EventHandler(this.btnPocetnaKartica_Click);
            // 
            // btnUposlenici
            // 
            this.btnUposlenici.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnUposlenici.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUposlenici.ButtonImage")));
            this.btnUposlenici.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUposlenici.ButtonText = "Uposlenici";
            this.btnUposlenici.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUposlenici.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUposlenici.CornerRadius = 5;
            this.btnUposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUposlenici.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUposlenici.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnUposlenici.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUposlenici.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUposlenici.Location = new System.Drawing.Point(11, 571);
            this.btnUposlenici.Name = "btnUposlenici";
            this.btnUposlenici.Size = new System.Drawing.Size(200, 50);
            this.btnUposlenici.TabIndex = 1;
            this.btnUposlenici.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUposlenici.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUposlenici.Click += new System.EventHandler(this.btnUposlenici_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnVozila.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnVozila.ButtonImage")));
            this.btnVozila.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnVozila.ButtonText = "Vozila";
            this.btnVozila.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnVozila.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnVozila.CornerRadius = 5;
            this.btnVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozila.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVozila.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnVozila.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnVozila.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnVozila.Location = new System.Drawing.Point(11, 517);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(200, 50);
            this.btnVozila.TabIndex = 1;
            this.btnVozila.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVozila.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // pnlPocetna
            // 
            this.pnlPocetna.Location = new System.Drawing.Point(244, 103);
            this.pnlPocetna.Name = "pnlPocetna";
            this.pnlPocetna.Size = new System.Drawing.Size(850, 524);
            this.pnlPocetna.TabIndex = 3;
            // 
            // pnlPomoc
            // 
            this.pnlPomoc.Location = new System.Drawing.Point(244, 57);
            this.pnlPomoc.Name = "pnlPomoc";
            this.pnlPomoc.Size = new System.Drawing.Size(850, 40);
            this.pnlPomoc.TabIndex = 4;
            // 
            // pnlInstruktor
            // 
            this.pnlInstruktor.Controls.Add(this.buttonInstruktor);
            this.pnlInstruktor.Location = new System.Drawing.Point(603, 9);
            this.pnlInstruktor.Name = "pnlInstruktor";
            this.pnlInstruktor.Size = new System.Drawing.Size(200, 33);
            this.pnlInstruktor.TabIndex = 2;
            this.pnlInstruktor.Visible = false;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 691);
            this.Controls.Add(this.pnlPomoc);
            this.Controls.Add(this.pnlPocetna);
            this.Controls.Add(this.panelReferent);
            this.Controls.Add(this.panel1);
            this.Name = "frmPocetna";
            this.Text = "EAuto skola";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelReferent.ResumeLayout(false);
            this.pnlInstruktor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnKandidati;
        private XanderUI.XUIButton btnUplate;
        private XanderUI.XUIButton btnZahtjevi;
        private XanderUI.XUIButton btnRasporedCasova;
        private XanderUI.XUIButton btnRasporedPolaganja;
        private XanderUI.XUIButton btnUsluge;
        private XanderUI.XUIButton btnKategorije;
        private XanderUI.XUIButton btnPotvrde;
        private System.Windows.Forms.Panel panelReferent;
        private XanderUI.XUIButton btnUposlenici;
        private XanderUI.XUIButton btnVozila;
        private System.Windows.Forms.Panel pnlPocetna;
        private System.Windows.Forms.Panel pnlPomoc;
        private XanderUI.XUIButton btnPocetnaKartica;
        private XanderUI.XUIButton buttonInstruktor;
        private System.Windows.Forms.Label lblOdjaviSe;
        private System.Windows.Forms.Label lblKorisnikEmail;
        private System.Windows.Forms.Panel pnlInstruktor;
    }
}

