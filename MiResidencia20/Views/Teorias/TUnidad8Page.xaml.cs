﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;

namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad8Page : ContentPage
    {
        public TUnidad8Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU8(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad8Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
        }
    }
}
