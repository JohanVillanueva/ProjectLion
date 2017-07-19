using ProjectLion.Controller;
using ProjectLion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xuni.Forms.FlexGrid;

namespace ProjectLion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Consulta : ContentPage
    {
        int modoBusqueda = 1;
        public Consulta()
        {
            InitializeComponent();
            MultasController multa = new MultasController();
            grid.BindingContext = multa;
            grid.ItemsSource = multa.data;
            grid.VerticalOptions = LayoutOptions.FillAndExpand;
            
        }
       
        
        private void btnPlaca_Clicked(object sender, EventArgs e)
        {
            grid.IsVisible = false;
            txtBuscar.Text = string.Empty;
            Button boton = (Button)sender;
            boton.BackgroundColor = Color.FromHex("#418ED6");
            btnDNI.BackgroundColor = Color.FromHex("#DADAD4");
            modoBusqueda = 2;
            txtBuscar.Keyboard = Keyboard.Text;
            txtBuscar.Placeholder = "Ingrese N° de Placa";

        }
        private void btnDNI_Clicked(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtBuscar.Text = string.Empty;
            grid.IsVisible = false;
            boton.BackgroundColor = Color.FromHex("#418ED6");
            btnPlaca.BackgroundColor = Color.FromHex("#DADAD4");            
            modoBusqueda = 1;
            txtBuscar.Keyboard = Keyboard.Numeric;
            txtBuscar.Placeholder = "Ingrese N° de DNI";
        }

        private void btnBuscar_Clicked(object sender, EventArgs e)
        {
            grid.IsVisible = true;
            btnBuscar.IsEnabled = false;
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            int caracteres = txtBuscar.Text.Length;
            txtBuscar.Text=  txtBuscar.Text.ToString().ToUpper();
            if (modoBusqueda == 1)
            {
                if (caracteres == 8)
                {
                    btnBuscar.IsEnabled = true;
                }
                else
                {
                    btnBuscar.IsEnabled = false;
                }
            }
            else if (modoBusqueda == 2) {
                if (caracteres == 8)
                {
                    btnBuscar.IsEnabled = true;
                }
                else
                {
                    btnBuscar.IsEnabled = false;
                }
            }
        }
    }
}