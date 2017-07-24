﻿using ProjectLion.Controller;
using ProjectLion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace ProjectLion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {
        public Mapa()
        {
            InitializeComponent();
            Map map = new Map();
			//var map = new Map(MapSpan.FromCenterAndRadius(
			//    new Position(-8.113097, -79.0315039),
			//    Distance.FromMiles(0.5)))
			//{
			//    IsShowingUser = true,
			//    VerticalOptions = LayoutOptions.FillAndExpand
			//};
            map.InitialCameraUpdate=CameraUpdateFactory.NewPositionZoom(new Position(-8.113097, -79.0315039), 10);

            map.VerticalOptions=LayoutOptions.FillAndExpand;
            MultasController mc = new MultasController();
            List<Multa> multas = new List<Multa>();

            if (Variables.Globales.propietario != null )
                multas = mc.data.Where(x => x.IdPropietario == Variables.Globales.propietario.IdPropietario).ToList();
            else
                multas = mc.data;

            foreach (var item in multas)
            {
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud)),
                    Label = item.Fecha.ToString(),
                    Address = item.Direccion
                };
                map.Pins.Add(pin);
            }
            Content = map;
        }
    }
}