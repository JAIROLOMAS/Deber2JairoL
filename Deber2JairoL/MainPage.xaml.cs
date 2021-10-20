using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Deber2JairoL
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //almacenar en variable, las notas que el usuario ingresa en las cajas de texto
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);

                //operacion
                double suma = (valor1 * 0.3) + (valor2 * 0.2);

                // visualizar nota final en pantalla
                txtResultado1.Text = suma.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "ok");
            }
        }

        private void btnSumar_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                //almacenar en variable, las notas que el usuario ingresa en las cajas de texto
                double valor3 = Convert.ToDouble(txtValorTres.Text);
                double valor4 = Convert.ToDouble(txtValorCuatro.Text);

                //operacion
                double suma = (valor3 * 0.3) + (valor4 * 0.2);

                // visualizar nota final en pantalla
                txtResultado2.Text = suma.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "ok");
            }

        }

        private void btnSumar3_Clicked(object sender, EventArgs e)
        {
            try
            {
                //almacenar en variable, las notas que el usuario ingresa en las cajas de texto
                double valorF1 = Convert.ToDouble(txtValorCinco.Text);
                double valorF2 = Convert.ToDouble(txtValorSeis.Text);

                //operacion
                double suma = valorF1  + valorF2 ;

                // visualizar nota final en pantalla
                txtValorSiete.Text = suma.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "ok");
            }
        }
    }

  