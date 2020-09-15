using Acr.UserDialogs;
using AutoSkola.Mobile.ViewModels;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

namespace AutoSkola.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacanjeKarticom : ContentPage
    {
        public int UkupnoZaUplatu;
        public Token StripeToken;
        public TokenService TokenService;
        private PlacanjeKarticomViewModel model=null;
        private string brojKarticeReg = @"\b(?:(?:\d[ -]*?){17,}|((?:\d[ -]*?){13,16}))\b";
        private string mjesecReg = @"(^0?[1-9]$)|(^1[0-2]$)";
        private string godinaReg = @"^[2]\d{3}$";
        private string cvvReg = @"^[0-9]{3,4}$";
        private bool karticaIspravna;
        private bool mjesecIspravan;
        private bool godinaIspravna;
        private bool cvvIspravan;
        public string ApiKey = "pk_test_51HL4VxEXw1IKAS4JFGoLOHuXeo0YE7MJbpbEFjjaNIwvSwZGuc5NJ09UB3Q7LQLHju6eZnEUGQDUWo5AWRLQukSP001uROxDmB";
        public PlacanjeKarticom(int ukupnoZaUplatu)
        {
            InitializeComponent();
            UkupnoZaUplatu = ukupnoZaUplatu;
            BindingContext = model = new PlacanjeKarticomViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            karticaIspravna = true;
            mjesecIspravan = true;
            godinaIspravna = true;
            cvvIspravan = true;
            GreskaBrKartice.IsVisible = false;
            GreskaGodina.IsVisible = false;
            GreskaCVV.IsVisible = false;
            GreskaMjesec.IsVisible = false;
         
            model.Ukupno = UkupnoZaUplatu;
            await PlacanjeSaKartice();
        }
        private void ValidacijaPolja()
        {
            

            if (!(Regex.IsMatch(BrojKartice.Text, brojKarticeReg)))
            {
                GreskaBrKartice.Text = "Broj kartice nije validan!";
                GreskaBrKartice.IsVisible = true;
                karticaIspravna = false;
            }
            if(!(Regex.IsMatch(MjesecIsteka.Text, mjesecReg)))
            {
                GreskaMjesec.Text = "Mjesec nije validan!";
                GreskaMjesec.IsVisible = true;
                mjesecIspravan = false;
            }
            if (!(Regex.IsMatch(GodinaIsteka.Text, godinaReg)))
            {
                GreskaGodina.Text = "Godina nije validna!";
               GreskaGodina.IsVisible = true;
                godinaIspravna = false;
            }
            if (!(Regex.IsMatch(CVV.Text, cvvReg)))
            {
                GreskaCVV.Text = "cvv nije validan!";
                GreskaCVV.IsVisible = true;
                cvvIspravan = false;
            }
        }
        public async Task PlacanjeSaKartice()
        {
            ValidacijaPolja();
            if (cvvIspravan==true && godinaIspravna==true && mjesecIspravan==true && karticaIspravna==true)

            {
                bool TransakcijaUspesna = false;
                CancellationTokenSource tokenSource = new CancellationTokenSource();
                CancellationToken cancellationToken = tokenSource.Token;
                try
                {
                    
                    //await Task.Run(async () =>
                    //{
                        var Token = KreirajToken();
                        Console.WriteLine("Payment Gateway" + "Token:" + Token);
                        if (Token != null)
                        {
                            TransakcijaUspesna = NapravljenPayment();
                            //ukoliko je uspjesna transakcija pohrani uplatu u bazu auto skole
                            if (TransakcijaUspesna)
                                await model.KreirajUplatu();
                        }
                        else
                        {
                            await Application.Current.MainPage.DisplayAlert("Greska","Neispravni podaci", "OK");
                        }
                    //}
                    //);
                }
                catch (Exception ex)
                {
                   
                      await  Application.Current.MainPage.DisplayAlert("Greska",ex.Message,"OK");
                }
                finally
                {
                    if (TransakcijaUspesna)
                    {
                        await Navigation.PushAsync(new MainPage());
                    }
                }
            }
        }
        public bool NapravljenPayment()
        {
            try
            {
#pragma warning disable CS0618 // 'StripeConfiguration.SetApiKey(string)' is obsolete: 'Use StripeConfiguration.ApiKey setter instead.'
                StripeConfiguration.SetApiKey("sk_test_51HL4VxEXw1IKAS4Jk8MyJIk7Rl1Ad0JcWMA8LR4VuuDnBLYaI7sjWzNKDIYRTrDCNCoH6isCf8uRVWbV2kuT2TFg00RYrnnwrh");
#pragma warning restore CS0618 // 'StripeConfiguration.SetApiKey(string)' is obsolete: 'Use StripeConfiguration.ApiKey setter instead.'
                var opcija = new ChargeCreateOptions
                {
                    Amount = (long?)(UkupnoZaUplatu*100),
                    Currency = "Bam",
                    Description = "Uplata",
                    StatementDescriptor = "Test",
                    Capture = true,
                    ReceiptEmail = "anitadautovic@outlook.com",
                    Source = StripeToken.Id
                };
                var service = new ChargeService();
                Charge charge = service.Create(opcija);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string KreirajToken()
        {
            try
            {
#pragma warning disable CS0618 // 'StripeConfiguration.SetApiKey(string)' is obsolete: 'Use StripeConfiguration.ApiKey setter instead.'
                StripeConfiguration.SetApiKey(ApiKey);
#pragma warning restore CS0618 // 'StripeConfiguration.SetApiKey(string)' is obsolete: 'Use StripeConfiguration.ApiKey setter instead.'
                var service = new ChargeService();  
                var token = new TokenCreateOptions()
                {
                    Card = new CreditCardOptions()
                    {
                        Number = BrojKartice.Text,
                        ExpMonth = int.Parse(MjesecIsteka.Text),
                        ExpYear = int.Parse(GodinaIsteka.Text),
                        Cvc = CVV.Text
                    }
                };
                TokenService = new TokenService();
                StripeToken = TokenService.Create(token);
                
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
            }
            return StripeToken.Id;
        }
    }
}