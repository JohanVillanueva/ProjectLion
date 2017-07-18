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
            Button boton = (Button)sender;
            boton.BackgroundColor = Color.FromHex("#418ED6");
            btnDNI.BackgroundColor = Color.FromHex("#DADAD4");
            modoBusqueda = 2;
            txtBuscar.Placeholder = "Ingrese N° de Placa";
        }
        private void btnDNI_Clicked(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackgroundColor = Color.FromHex("#418ED6");
            btnPlaca.BackgroundColor = Color.FromHex("#DADAD4");            
            modoBusqueda = 1;
            txtBuscar.Placeholder = "Ingrese N° de DNI";
        }
    }
}