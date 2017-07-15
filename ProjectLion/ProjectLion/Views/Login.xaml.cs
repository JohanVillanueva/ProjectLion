using Newtonsoft.Json;
using ProjectLion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectLion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btnIngresar.Clicked += BtnIngresar_Clicked;
        }

        private async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.GetAsync("https://apimultas.azurewebsites.net/api/usuarios?user=" + txtUser.Text + "&password=" + txtPassword.Text);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    Variables.Globales.propietario = JsonConvert.DeserializeObject<List<Propietario>>(json).FirstOrDefault();
                    Application.Current.MainPage = new MultaView();
                }
                else
                {
                    await DisplayAlert("Error", "Usuario incorrecto", "OK");
                }
            }
            catch (Exception)
            {
                await DisplayAlert("Error", "No se pudo realizar la peticion", "OK");
            }
        }

    }
}