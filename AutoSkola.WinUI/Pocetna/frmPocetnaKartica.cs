using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WinUI.Zahtjevi;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutoSkola.WinUI.Pocetna
{
    public partial class frmPocetnaKartica : Form
    {
        private APIService _zahtjevi = new APIService("Zahtjevi");
        private APIService _uplate = new APIService("Uplate");

        private frmPocetna frmPocetna;
        private Panel pnlPocetna;

        public frmPocetnaKartica(frmPocetna frmPocetna, Panel pnlPocetna)
        {
            InitializeComponent();
            this.frmPocetna = frmPocetna;
            this.pnlPocetna = pnlPocetna;
        }
        
        private async void frmPocetnaKartica_Load(object sender, EventArgs e)
        {
            //prikazuje sve zahtjeve ikad podnesene
            var zahtjeviStatistika = await _zahtjevi.Get<List<MZahtjevi>>(new ZahtjeviSearchRequest {pocetnaPrikaz=true });
            //prikazuje zahteve koji nit su prihvaceni, nit odbijeni
            var zahtjevi = await _zahtjevi.Get<List<MZahtjevi>>(null);
            PrikaziZahtjeve(zahtjevi);
            var brojGodina = DateTime.Now.Year-1999;
            int pocetna = 2000;
            int[] godineUpisa = new int[brojGodina];
            int[] godineUplata = new int[brojGodina];

            for (int i = 0; i < brojGodina; i++)
            {
                godineUpisa[i] = new int();
                godineUpisa[i] =pocetna;
                godineUplata[i] = new int();
                godineUplata[i] = pocetna++;
            }
            
            cbGodinaUpis.DataSource = godineUpisa;
            cbGodinaUplata.DataSource = godineUplata;

            var uplate = await _uplate.Get<List<MUplate>>(null);
            fillChartUplate(uplate);
            fillChartZahtjevi(zahtjeviStatistika);
        }
        private void PrikaziZahtjeve(List<MZahtjevi> zahtjevi)
        {
            ZahtjevPocetna[] listaZahtjeva = new ZahtjevPocetna[zahtjevi.Count()];
            for(int i = 0; i < zahtjevi.Count(); i++)
            {
                listaZahtjeva[i] = new ZahtjevPocetna(frmPocetna,pnlPocetna);
                listaZahtjeva[i].ZahtjevId = zahtjevi[i].Id;
                listaZahtjeva[i].Kandidat = zahtjevi[i].Kandidat;
                listaZahtjeva[i].Usluga = zahtjevi[i].Usluga;
                flpNoviZahtjevi.Controls.Add(listaZahtjeva[i]);
            }
        }

        private void fillChartUplate(List<MUplate> uplate)
        {
            chartUplate.Series["IznosUplata"].Points.Clear();
            string[] Meseci = { "Jan", "Feb", "Mar", "Apr", "Maj", "Jun", "Jul", "Avg", "Sep", "Okt", "Nov", "Dec" };
      
            float sumaJanuar = 0;
            float sumaFebruar = 0;
            float sumaMart = 0;
            float sumaApril = 0;
            float sumaMaj = 0;
            float sumaJun = 0;
            float sumaJul = 0;
            float sumaAvgust = 0;
            float sumaSeptembar = 0;
            float sumaOktobar = 0;
            float sumaNovembar = 0;
            float sumaDecembar = 0;
        
            for (int i = 0; i < uplate.Count(); i++)
            {
                if (uplate[i].DatumUplate.Month == 1)
                {
                    sumaJanuar += uplate[i].Iznos;
                    
                }
                else if (uplate[i].DatumUplate.Month == 2)
                {
                    
                    sumaFebruar += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 3)
                {
                  
                    sumaMart += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 4)
                {
                    
                    sumaApril += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 5)
                {
                   
                    sumaMaj += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 6)
                {
                  
                    sumaJun += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 7)
                {
                   
                    sumaJul += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 8)
                {
                    
                    sumaAvgust += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 9)
                {
                  
                    sumaSeptembar += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 10)
                {
                  
                    sumaOktobar += uplate[i].Iznos;
                }
                else if (uplate[i].DatumUplate.Month == 11)
                {
                 
                    sumaNovembar += uplate[i].Iznos;
                }
               
                else if (uplate[i].DatumUplate.Month == 12)
                {
                    sumaDecembar += uplate[i].Iznos;
                }
            }
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[0], sumaJanuar);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[1], sumaFebruar);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[2], sumaMart);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[3], sumaApril);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[4], sumaMaj);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[5],sumaJun);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[6], sumaJul);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[7], sumaAvgust);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[8],sumaSeptembar);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[9],sumaOktobar);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[10],sumaNovembar);
            chartUplate.Series["IznosUplata"].Points.AddXY(Meseci[11],sumaDecembar);
        }
        private void fillChartZahtjevi(List<MZahtjevi> zahtjevi)
        {
            chartUpis.Series["BrojZahtjeva"].Points.Clear();
            string[] Meseci = { "Jan", "Feb", "Mar", "Apr", "Maj", "Jun", "Jul", "Avg", "Sep", "Okt", "Nov", "Dec" };
            int upisJan = 0;
            int upisFeb = 0;
            int upisMart = 0;
            int upisApril = 0;
            int upisMaj = 0;
            int upisJun = 0;
            int upisJul = 0;
            int upisAvg = 0;
            int upisSep = 0;
            int upisOkt = 0;
            int upisNov = 0;
            int upisDec = 0;

            for (int i = 0; i < zahtjevi.Count(); i++)
            {
                if (zahtjevi[i].DatumPodnosenja.Month == 1)
                {
                    upisJan++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 2 )
                {
                    upisFeb++;
                }
               
                else if (zahtjevi[i].DatumPodnosenja.Month == 3 )
                {
                    upisMart++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 4)
                {
                    upisApril++;
                }            
                else if (zahtjevi[i].DatumPodnosenja.Month == 5)
                {
                    upisMaj++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 6)
                {
                    upisJul++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 7)
                {
                    upisJul++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 8)
                {
                    upisAvg++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 9)
                {
                    upisSep++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 10 )
                {
                    upisOkt++;
                }

                else if (zahtjevi[i].DatumPodnosenja.Month == 11)
                {
                    upisNov++;
                }
                else if (zahtjevi[i].DatumPodnosenja.Month == 12)
                {
                    upisDec++;
                }
            }
            chartUpis.ChartAreas[0].AxisY.Interval = 1;
            chartUpis.ChartAreas[0].AxisX.Interval = 2;

            chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[0], upisJan);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[1], upisFeb);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[2], upisMart);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[3], upisApril);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[4], upisMaj);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[5], upisJun);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[6], upisJul);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[7], upisAvg);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[8], upisSep);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[9], upisOkt);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[10], upisNov);
                chartUpis.Series["BrojZahtjeva"].Points.AddXY(Meseci[11], upisDec);
            
        }

        private async void cbGodinaUpis_SelectedIndexChanged(object sender, EventArgs e)
        {
            var search = new ZahtjeviSearchRequest();
            var odabranaGodina = cbGodinaUpis.SelectedValue;
            if (int.TryParse(odabranaGodina.ToString(), out int OGodina))
            {
                search.Godina = OGodina;
            }
            var zahtjevi = await _zahtjevi.Get<List<MZahtjevi>>(search);
                 
                fillChartZahtjevi(zahtjevi);
       
        }

        private async void cbGodinaUplata_SelectedIndexChanged(object sender, EventArgs e)
        {
            var search = new UplataSearchRequest();
            var odabranaGodina = cbGodinaUplata.SelectedValue;
            if (int.TryParse(odabranaGodina.ToString(), out int OGodina))
            {
                search.Godina = OGodina;
            }
            var uplate = await _uplate.Get<List<MUplate>>(search);
            
            fillChartUplate(uplate);
        }
    
    }
}
