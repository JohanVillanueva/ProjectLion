using System;
using System.Collections.Generic;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;

namespace ProjectLion.Controller
{
    public class ChartsController
    {
		
        public List<SfChart> charts
        {
            get;
            set;
        }
        public ChartsController()
        {
			charts = new List<SfChart>();
            //for (int i = 0; i < cantidad;i++)
            //{
            //    charts.Add(new SfChart());
               
            //}
        }

        public List<SfChart> getCharts()
        {
            return charts;
        }
        public void BindingCharts(Object context)
		{
			foreach (SfChart chart in charts)
			{
                chart.BindingContext = (BindableObject)context;

			}
		}

        public void chartBarras(SfChart chart, string xpath, string ypath, string unids, string title)
        {
            chart.Title.Text = title;
            chart.Legend = new ChartLegend();
			CategoryAxis primaryAxis = new CategoryAxis();
            primaryAxis.Title.Text = xpath;
			chart.PrimaryAxis = primaryAxis;

	        NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Title.Text = ypath + " ( " + unids + " ) " ;
	        chart.SecondaryAxis = secondaryAxis;

            ColumnSeries series = new ColumnSeries();
			series.SetBinding(ChartSeries.ItemsSourceProperty, "Data");
            series.XBindingPath = xpath;
            series.YBindingPath = ypath;
			series.EnableAnimation = true;
			series.AnimationDuration = 0.9;
			series.EnableTooltip = true;
            chart.Series.Add(series);
            charts.Add(chart);
		}
        public void chartSemiDonut(SfChart chart, string xpath, string ypath, string unids, IEnumerable<object> data, string title)
        {
			DoughnutSeries doughnutSeries = new DoughnutSeries()
		    { ItemsSource = data,
			  XBindingPath = "Name",
			  YBindingPath = "Height",
			  StartAngle = 180,
			  EndAngle = 360
			};
            chart.Series.Add(doughnutSeries);
            charts.Add(chart);
		}
    }
}
