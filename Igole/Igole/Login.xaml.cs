using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Igole
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage

    {
        Uri uri;
        public Login()
        {
            InitializeComponent();


            NavigationPage.SetHasNavigationBar(this, false);

            // Define o binding context
            this.BindingContext = this;
            // Define a propriedade
            this.IsBusy = false;
            BtnLogin.Clicked += BtnLogin_Clicked;

        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            //ativa o ActivityIndicator
            this.IsBusy = true;
            // aqui ficaria o seu código 
            // para fazer a autenticação
            await DandoUmTempo(5000);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor);
        }
    }
}

     
    
    