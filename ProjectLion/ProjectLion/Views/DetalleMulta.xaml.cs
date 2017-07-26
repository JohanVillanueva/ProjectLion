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
using Xamarin.Forms.GoogleMaps;

namespace ProjectLion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleMulta : ContentPage
    {
        Multa multaDetail = null;
		public DetalleMulta(Multa multa)
		{
			InitializeComponent();

			BindingContext = multa;
            multaDetail = multa;
            DrawMap();
		}

        public void DrawMap(){
			Map map = new Map();
            map.InitialCameraUpdate = CameraUpdateFactory.NewPositionZoom(new Position(Convert.ToDouble(multaDetail.Latitud), Convert.ToDouble(multaDetail.Longitud)), 15);

			map.VerticalOptions = LayoutOptions.FillAndExpand;
            map.HorizontalOptions = LayoutOptions.FillAndExpand;
			
				var pin = new Pin
				{
					Type = PinType.Place,
                Position = new Position(Convert.ToDouble(multaDetail.Latitud), Convert.ToDouble(multaDetail.Longitud)),
                Label=multaDetail.Placa,
                Address = multaDetail.Direccion
				};
				map.Pins.Add(pin);
			
            ContenedorMapaDetalle.Children.Add(map);
        }

    }
}
