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
        public Consulta()
        {
            InitializeComponent();
            MultasController multa = new MultasController();
            grid.BindingContext = multa;
            grid.ItemsSource = multa.data;
            grid.VerticalOptions = LayoutOptions.FillAndExpand;
        }
    }
}