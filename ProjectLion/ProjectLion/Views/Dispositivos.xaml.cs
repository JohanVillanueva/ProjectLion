using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ProjectLion.Controller;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms.Xaml;
using ProjectLion.Variables;
using System.Linq;

namespace ProjectLion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dispositivos : ContentPage
    {
        //MultasController multa;

       
        public Dispositivos()
        {
            InitializeComponent();
            //multa = new MultasController();
            BindingContext = new ViewModel();
         
            InicializarChart1();
            inicializarChart2();
            //Content = chart1;
            StackLayout layout = new StackLayout();
            layout.Padding = new Thickness(4, 4, 4, 4);
            layout.Children.Add(chart1);
            layout.Children.Add(chart2);
            layout.Children.Add(chart1);
            ScrollView sv = new ScrollView()
            {
                Content = layout
            };
            Content = sv;
        }
        SfChart chart1,chart2;
		public void InicializarChart1()
		{
             chart1 = new SfChart();
			 chart1.Title.Text = "Infracciones por Dispositivo";

			CategoryAxis primaryAxis = new CategoryAxis();
            primaryAxis.Title.Text = "Direccion";
			chart1.PrimaryAxis = primaryAxis;

			 NumericalAxis secondaryAxis = new NumericalAxis();
			 secondaryAxis.Title.Text = "Infracciones (unidades)";
			 chart1.SecondaryAxis = secondaryAxis;

            ColumnSeries series = new ColumnSeries();
            ColumnSeries series2 = new ColumnSeries();

			series.SetBinding(ChartSeries.ItemsSourceProperty, "DataHombres");
            series2.SetBinding(ChartSeries.ItemsSourceProperty, "DataMujeres");

			series.XBindingPath = "Direccione";
			series.YBindingPath = "Infracciones";
			series.EnableAnimation = true;
			series.AnimationDuration = 0.9;
			series.EnableTooltip = true;
            series.EnableDataPointSelection = true;
            series.Label = "Hombres";
            series.DataMarker = new ChartDataMarker();

			series2.XBindingPath = "Direccione";
			series2.YBindingPath = "Infracciones";
			series2.EnableAnimation = true;
			series2.AnimationDuration = 0.9;
			series2.EnableTooltip = true;
			series2.EnableDataPointSelection = true;
			series2.Label = "Mujeres";
            series2.DataMarker = new ChartDataMarker();

			chart1.Legend = new ChartLegend();
			chart1.Series.Add(series);
            chart1.Series.Add(series2);

            chart1.Legend.ToggleSeriesVisibility = true;
            chart1.Margin = new Thickness(5, 6, 5, 5);

            chart1.VerticalOptions = LayoutOptions.FillAndExpand;
        }

        public void inicializarChart2()
        {
            chart2 = new SfChart();
			ViewModel vm = new ViewModel();
			DoughnutSeries doughnutSeries = new DoughnutSeries()
			{

				ItemsSource = vm.Data,
				XBindingPath = "Direccione",
				YBindingPath = "Infracciones",
				StartAngle =0,
				EndAngle = 360
			};
           
            doughnutSeries.Label = "Infracciones";
            doughnutSeries.EnableTooltip=true;
            doughnutSeries.EnableDataPointSelection = true;
            doughnutSeries.EnableAnimation = true;
            doughnutSeries.AnimationDuration = 0.9;
            doughnutSeries.EnableSmartLabels = true;
            doughnutSeries.DataMarker = new ChartDataMarker();
			chart2.Title.Text = "Infracciones por Dispositivo";
            chart2.Legend = new ChartLegend();
            chart2.Series.Add(doughnutSeries);
            chart2.Margin = new Thickness(5, 6, 5, 5);
			chart2.Legend.ToggleSeriesVisibility = true;
            chart2.VerticalOptions = LayoutOptions.FillAndExpand;
        }
    }
	public class Ubicacion
	{
		public string Direccione { get; set; }
        public int Infracciones { get; set; }      
	}
	public class ViewModel
	{
		public List<Ubicacion> Data { get; set; }
        public List<Ubicacion> DataHombres { get; set; }
        public List<Ubicacion> DataMujeres { get; set; }

		public ViewModel()
		{
			var queryHombres = from multa in Globales.multas where multa.Sexo == "H"
							   group multa by multa.Direccion into grupoDir
							   select new Ubicacion
							   {
								   Direccione = grupoDir.First().Direccion,
								   Infracciones = grupoDir.Count()
							   };
            DataHombres = queryHombres.ToList();


            var query = from multa in Globales.multas
						group multa by multa.Direccion into grupoDir
                              select new Ubicacion
						{
							Direccione = grupoDir.First().Direccion,
							Infracciones = grupoDir.Count()
						};
            Data = query.ToList();


			var queryMujeres = from multa in Globales.multas where multa.Sexo=="M"
						group multa by multa.Direccion into grupoDir
						select new Ubicacion
						{
							Direccione = grupoDir.First().Direccion,
							Infracciones = grupoDir.Count()
						};

			DataMujeres = queryMujeres.ToList();
		}
	}
}
