

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Flurl;

using Flurl.Http;

using AutoSkola.Model;
using System.Windows.Forms.DataVisualization.Charting;
using AutoSkola.Model.Requests;
using System.Windows.Forms;

namespace AutoSkola.WinUI

{

    public class APIService

    {
        public static MKorisnik trenutniKorisnik { get; set; }
 
        public static string Username { get; set; } 
        public static string Password { get; set; }
        private readonly string _route;
        public static string UlogaNaziv { get; set; }

        public APIService(string route)

        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)

        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
                if (search != null)
                {
                    url += "?";
                    url +=  search.ToString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            { 
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Pogrešan username ili password!");
                }

                throw;
            }
        }


        public async Task<T> GetById<T>(object Id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{Id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

               return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        
        }
        public async Task<T> Update<T>(int? id, object request)
        {

                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>(); 
        }

        public async Task<bool> Delete(int? id)
        {

                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<bool>();
           
            }
        public async Task<MKorisnik> Authenticate(AuthenticateRequest request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/Authenticate";
            trenutniKorisnik= await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<MKorisnik>();
          
            return trenutniKorisnik;
        }
       
    }



}


