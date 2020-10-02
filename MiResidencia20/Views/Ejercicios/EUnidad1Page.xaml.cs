using System;
using System.Collections.Generic;
using MiResidencia20.Views.Ejercicios;

using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{

    public partial class EUnidad1Page : ContentPage
    {
        //Mis variables globales
        int aciertoCorrecto = 0;

        //<--Ejercios-->
        //Básicos 1/3 | Frame.BackgroundColor="#C4ECE7"  Margin="3,40" CornerRadius="3"
        string[] primerEjercicio=
        {
              //R = Números naturales
            "1.Son aquellos que no necesitan representarse como una fracción o un decimal." +
            " Además no pueden ser negativos:",

            "Números irracionales",
            "*Números naturales",
            "Números enteros"
        };

        string[] segundoEjercicio =
        {
              //R = Números enteros
            "2. Son números naturales, pero también pueden ser negativos:",
            "*Números enteros",
            "Números irracionales",
            "Números naturales"
        };

        string[] tercerEjercicio =
        {
            //R= Números irracionales
            "3.Son aquellos que no pueden expresarse como la fracción de dos enteros:",
            "Números enteros",
            "Números naturales",
            "*Números irracionales"
        };



        //Ejercicio Intermedio 4/6 | Frame.BorderColor="#B0CFF4 "
        string[] cuartoEjercicio =
        {
            //Respuesta = Conmutativa
            "4. Propiedad de los números reales que cuando sumamos o multiplicamos dos números, " +
            "el orden no importa; A+B=B+A, AB=BA:",
            "*Conmutatativa",
            "Distributiva",
            "Asociativa",
        };


        string[] quintoEjercicio =
       {
            //Respuesta = Asociativa
            "5.Propiedad de los números reales que cuando sumamos o multiplicamos tres números, " +
            "no importa cuales dos de ellos sumamos o multiplicamos prirmero; (A+B)+C=A+(B+C), (AB)C=A(BC)",

            "*Asociativa",
            "Conmutatativa",
            "Distributiva"

        };

        string[] sextoEjercicio =
       {
            //Respuesta = Distributiva
            "6.Propiedad de los números reales que cuando multiplicamos un número por una suma de dos números" +
              " obtenemos el mismo resultado si multiplicamos el número por cada uno de los términos" +
              "y luego sumamos los resultados; A(B+C)=AB+AC,(B+C)A=AB+AC:",
                             

            "Conmutatativa",
            "Asociativa",
            "*Distributiva"
        };



        //Ejercicio Avanzado 7/10 | Frame.BorderColor="#F99F8A "

        string[] septimoEjercicio =
        {
            //Respuesta = verdadero
            "8.9.Verficar si  la desigualdad es verdadero o falsa 8 < 9 : ",
            "*Verdadero",
            "Falso"
        };

        string[] octavoEjercicio =
        {
            //Respuesta = Falso 
            "8.Verficar si  la desigualdad es verdadero o falsa  √2 > 1.41:",
            "Verdadero",
            "*Falso"
        };


        string[] novenoEjercicio = 
        {
            //Respuesta = Falso
            "8.9.Verficar si  la desigualdad es verdadero o falsa -1/2 < -1 : ",
            "Verdadero",
            "*Falso"
        };

        

        string[] decimoEjercicio =
        {
            //Respuesta = Verdadero
            "7.Verficar si  la desigualdad es verdadero o falsa -π > -3:",
            "*Verdadero",
            "Falso"
        };

        public EUnidad1Page()
        {
  
            InitializeComponent();

            //Agregando a la vista
            LabelPregunta.Text = primerEjercicio[0];
            LabelPreguntaUno.Text = primerEjercicio[1];
            LabelPreguntaDos.Text = primerEjercicio[2];
            LabelPreguntaTres.Text = primerEjercicio[3];


        }

        void Btn_siguiente(System.Object sender, System.EventArgs e)
        {
            if (check2.IsChecked == true)
            {
                aciertoCorrecto += 1;

                DisplayAlert("Acierto", $"Correcta", "Ok");
                LabelPregunta.Text = string.Empty;
                LabelPreguntaUno.Text = string.Empty;
                LabelPreguntaDos.Text = string.Empty;
     
            }
            else
            {
                aciertoCorrecto += 0;
                DisplayAlert("Resouesta", $"Incorecta", "Ok");
                LabelPregunta.Text = string.Empty;
                LabelPreguntaUno.Text = string.Empty;
                LabelPreguntaDos.Text = string.Empty;
            }

        }


    

    }

}
    

