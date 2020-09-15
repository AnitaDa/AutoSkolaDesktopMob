using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoSkola.Mobile
{
    public class APIService

    {
        public static MKorisnik trenutniKorisnik{get;set;}

        public static string Username { get; set; }
        public static string Password { get; set; }
        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:5000/api";
#endif

#if RELEASE
        private string _apiUrl = "http://localhost:5000/api/";

#endif
        public APIService(string route)

        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)

        {
            try
            {
                var url = $"{_apiUrl}/{_route}";
                if (search != null)
                {
                    url += "?";
                    url += search.ToString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");
                }

                throw;
            }
        }


        public async Task<T> GetById<T>(object Id)
        {
            var url = $"{_apiUrl}/{_route}/{Id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

        }
        public async Task<T> Update<T>(int? id, object request)
        {

            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<bool> Delete(int? id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<bool>();

        }
        public async Task<MKorisnik> Authenticate(AuthenticateRequest request)
        {
            var url = $"{_apiUrl}/{_route}/Authenticate";
            trenutniKorisnik= await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<MKorisnik>();
            return trenutniKorisnik;
        }
       
    }

}
