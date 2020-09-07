﻿using System;
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
             Navigation.PushAsync(new EUnidad1Page());

        }

         public void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
            var anchura = 500;
            WebView.HeightRequest = anchura; 
            var meWebUnidad1 = WebView.Source;
        }

        public async void WebView_Navigated(System.Object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            var CanGoBack = WebView.CanGoBack;
            await DisplayAlert("Navegando","Página Cargada", "Ok");

        }
    }
}
