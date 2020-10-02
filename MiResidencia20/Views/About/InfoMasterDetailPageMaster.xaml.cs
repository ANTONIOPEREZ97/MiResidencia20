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

namespace MiResidencia20.Views.About
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public InfoMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new InfoMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class InfoMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<InfoMasterDetailPageMenuItem> MenuItems { get; set; }

            public InfoMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<InfoMasterDetailPageMenuItem>(new[]
                {
                    new InfoMasterDetailPageMenuItem { Id = 0, Title = "Perfil", TargetType=typeof(PerfilPage), Icon="icono_Usuario.png"},
                    new InfoMasterDetailPageMenuItem { Id = 1, Title = "Acerca de...", TargetType=typeof(ObjetivoAppPage), Icon="icono_Acercade.png"},
                    //new InfoMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    //new InfoMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    //new InfoMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
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
