using System;
using System.Collections.Generic;
using MiResidencia20.Views.Ejercicios;
using Xamarin.Forms;


namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad1Page : ContentPage
    {
        public TUnidad1Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU1(System.Object sender, System.EventArgs e)
        {
             Navigation.PushAsync(new EjercicioU1Page());

        }
    }
}
