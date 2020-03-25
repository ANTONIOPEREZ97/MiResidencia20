﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MiResidencia20.Views;

namespace MiResidencia20
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage (new BienvenidaPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
