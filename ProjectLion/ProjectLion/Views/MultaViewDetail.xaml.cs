using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectLion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultaViewDetail : ContentPage
    {
        public MultaViewDetail()
        {
            InitializeComponent();
            // Botón Consulta Rápida
            var consulta_tap = new TapGestureRecognizer();
            consulta_tap.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new Consulta());
            };
            btnConsulta.GestureRecognizers.Add(consulta_tap);

            // Botón Puntos de Control
            var puntos_tap = new TapGestureRecognizer();
            puntos_tap.Tapped += (s, e) =>
            {
                //if (Variables.Globales.propietario == null)
                //    Navigation.PushAsync(new Login());
                //else
                    Navigation.PushAsync(new Mapa());
            };
            btnPuntosDeControl.GestureRecognizers.Add(puntos_tap);

            // Botón Resumen de deudas
            var resumen_tap = new TapGestureRecognizer();
            resumen_tap.Tapped += (s, e) =>
            {
                if (Variables.Globales.propietario == null)
                    Navigation.PushAsync(new Login());
                else
                    Navigation.PushAsync(new Resumen());
            };
            btnDeudas.GestureRecognizers.Add(resumen_tap);

            // Botón Contacto
            var contacto_tap = new TapGestureRecognizer();
            contacto_tap.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new Contacto());
            };
            btnContacto.GestureRecognizers.Add(contacto_tap);
        }
    }
}