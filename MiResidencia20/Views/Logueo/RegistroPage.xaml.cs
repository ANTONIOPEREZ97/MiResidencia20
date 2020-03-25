using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MiResidencia20.Views.Logueo;

namespace MiResidencia20.Views
{
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

          async void  Btn_Registrar(System.Object sender, System.EventArgs e)
        {
           await DisplayAlert("Felicitaciones","Registro Exitosamente","Comenzar");
           await Navigation.PushAsync(new MenuTabbedPage());

        }
    }
     
}
