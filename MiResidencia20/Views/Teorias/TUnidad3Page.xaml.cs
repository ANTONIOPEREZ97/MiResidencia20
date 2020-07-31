using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;

namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad3Page : ContentPage
    {
        public TUnidad3Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU3(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad3Page());
        }
    }
}
