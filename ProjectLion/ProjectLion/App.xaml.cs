using Newtonsoft.Json;
using ProjectLion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Xamarin.Forms;

namespace ProjectLion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ProjectLion.Views.MultaView();
        }

        public async void iniciar()
        {
            var client = new HttpClient();
            string json;
            try
            {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("https://apimultas.azurewebsites.net/api/multas/");
            json = response.Content.ReadAsStringAsync().Result;
                Variables.Globales.multas = JsonConvert.DeserializeObject<List<Multa>>(json);              
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        protected override void OnStart()
        {
            iniciar();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
