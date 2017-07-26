using System;
using System.Collections.Generic;
using ProjectLion.Controller;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectLion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieChartReport : ContentPage
    {
        public PieChartReport()
        {
            InitializeComponent();
			MultasController multa = new MultasController();
            piechart.BindingContext = multa;
            piechart.ItemsSource = multa.data;

            piechart.VerticalOptions = LayoutOptions.FillAndExpand;
        }
    }
}
