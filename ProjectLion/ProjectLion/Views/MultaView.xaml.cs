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
    public partial class MultaView : MasterDetailPage
    {
        public MultaView()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MultaViewMenuItem;
            if (item == null)
                return;


            if (Variables.Globales.propietario == null && (item.TargetType == typeof(Resumen) || item.TargetType == typeof(Mapa)))
            {
                DisplayAlert("Autenticacion requerida", "Necesita autenticarse para acceder a esta opcion", "OK");
                MasterPage.ListView.SelectedItem = null;
            }
            else if (item.TargetType == typeof(int))
            {
                MasterPage.ListView.SelectedItem = null;
                App.Current.MainPage = new MultaView();
            }
            else if (item.TargetType == null)
            {
                Variables.Globales.propietario = null;
                MasterPage.ListView.SelectedItem = null;
                App.Current.MainPage = new MultaView();
            }
            else
            {
                var page = (Page)Activator.CreateInstance(item.TargetType);

                Detail = new NavigationPage(page);
                IsPresented = false;

                MasterPage.ListView.SelectedItem = null;
            }
        }
    }
}