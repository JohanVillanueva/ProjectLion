using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjectLion.Views
{
    public partial class MenuReportes : TabbedPage
    {
        public MenuReportes()
        {
            InitializeComponent();
            var dispositivosPage = new Dispositivos();
            dispositivosPage.Title = "Dispositivos";
			//dispositivosPage.Icon = "dispositivo_icon.png";
            var infractoresPage = new Infractores();
            infractoresPage.Title = "Infractores";
            //infractoresPage.Icon = "infractores_icon.png";
            var fechaPage = new Fecha();
            fechaPage.Title = "Fecha";
            //fechaPage.Icon = "fecha_icon.png";
			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					dispositivosPage.Icon = "dispositivo_icon.png";
                    infractoresPage.Icon = "infractores_icon.png";
                    fechaPage.Icon = "fecha_icon.png";
					break;
				case Device.Android:
				case Device.WinPhone:
				case Device.Windows:
				default:					
					break;
			}
			Children.Add(dispositivosPage);
            Children.Add(fechaPage);
            Children.Add(infractoresPage);

        }
    }
}
