using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectLion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultaViewMaster : ContentPage
    {
        public ListView ListView;

        public MultaViewMaster()
        {
            InitializeComponent();

            BindingContext = new MultaViewMasterViewModel();
            ListView = MenuItemsListView;
           
        }

        class MultaViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MultaViewMenuItem> MenuItems { get; set; }

            public MultaViewMasterViewModel()
            {
                if (Variables.Globales.propietario != null)
                    MenuItems = Variables.Globales.menuLogin;
                else
                    MenuItems = Variables.Globales.menuNoLogin;
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}