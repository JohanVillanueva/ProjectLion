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
            map.InitialCameraUpdate=CameraUpdateFactory.NewPositionZoom(new Position(-8.113097, -79.0315039), 15);

            map.VerticalOptions=LayoutOptions.FillAndExpand;
            MultasController mc = new MultasController();
            List<Multa> multas = new List<Multa>();

			multas = mc.data;
            foreach (var item in multas)
            {
				var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud)),
                    Label = "Punto de Control",
                    Address = item.Direccion
                };
                map.Pins.Add(pin);
            }
            Content = map;
        }
    }
}