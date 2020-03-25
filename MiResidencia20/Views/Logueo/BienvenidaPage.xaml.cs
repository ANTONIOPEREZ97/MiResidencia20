using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MiResidencia20.Views; //Llamo a la carpeta Views


namespace MiResidencia20.Views
{
    public partial class BienvenidaPage : ContentPage
    {
        public BienvenidaPage()
        {
            InitializeComponent();
        }

        void Btn_IrARegistro(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegistroPage());
          
        }
    }
}
