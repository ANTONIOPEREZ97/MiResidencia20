using System;
using System.Collections.Generic;
using MiResidencia20.Views.Ejercicios;

using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{

    public partial class EUnidad1Page : ContentPage
    {

        public EUnidad1Page()
        {
            InitializeComponent();

        }

        void Btn_verificar(System.Object sender, System.EventArgs e)
        {


        }

        void Btn_concluir(System.Object sender, System.EventArgs e)
        {

            //Pregunta 1
            if (CheckRB1.IsChecked == true && CheckA1.IsChecked == false && CheckC1.IsChecked == false)
            {
                DisplayAlert("Pregunta 1", "Correcto", "Ok");

            }

            else
            {

                DisplayAlert("Pregunta 1", "Incorrecto", "Ok");
            }

            //cierre del boton
        }

    }

 }
    

