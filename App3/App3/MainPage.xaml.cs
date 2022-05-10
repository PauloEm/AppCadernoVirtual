using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //initializeComponent: carrega a página compilada//
        }

        private async void Button_Clicked(object sender, EventArgs e)
        // viabilizar manipuladores de eventos assíncronos
        //Button_Clicked: botão está/foi clicado
        //Sender: envia a ação
        //EventArgs: argumentos específicos//
        {
            await  Navigation.PushAsync(new Quimica());
            //esperar por uma ação, navegação para a página, ex: Quimica//
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Fisica());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Matematica());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LP());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hist());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EDfisica());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ingles());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Filosofia());
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Biologia());
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgWeb());
        }

        private async void Button_Clicked_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Artes());
        }

        private async void Button_Clicked_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Geografia());
        }

        private async void Button_Clicked_12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Analise());
        }

        private async void Button_Clicked_13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisignDigital());
        }

        private async void Button_Clicked_14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FundamentosDaInfo());
        }

        private async void Button_Clicked_15(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TecnicasDeProg());
        }

        private async void Button_Clicked_16(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BD());
        }

        private async void Button_Clicked_17(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sociologia());
        }

        private async void Button_Clicked_18(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DS());
        }

        private async void Button_Clicked_19(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Etica());
        }

        private async void Button_Clicked_20(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SisEmbarcado());
        }

        private async void Button_Clicked_21(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgMobile());
        }

        private async void Button_Clicked_22(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Internet());
        }

        private async void Button_Clicked_23(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QualidTeste());
        }

        private async void Button_Clicked_24(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TCC());
        }
    }
}
