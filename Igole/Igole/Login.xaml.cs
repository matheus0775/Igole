using DocumentFormat.OpenXml.Drawing.Charts;
using Igole.Model;
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
        //Uri uri;
        public Login()
        {
            //var vm = new ModLogin();

            //this.BindingContext = vm;

            //vm.ExibirAvisoDeLoginInvalido += () => DisplayAlert("Erro", "Login Inválido, tente novamente", "OK");

            InitializeComponent();



            //Email.Completed += (object sender, EventArgs e) =>
            //{
            //    Senha.Focus();
            //};
            //Senha.Completed += (object sender, EventArgs e) =>
            //{
            //    vm.SubmitCommand.Execute(null);
            //};




            //barra de naveção//
            NavigationPage.SetHasNavigationBar(this, false);





            // Define o binding context
            this.BindingContext = this;
            // Define a propriedade
            this.IsBusy = false;
            BtnLogin.Clicked += BtnLogin_Clicked;

        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {

            this.IsBusy = true;

            await DandoUmTempo(5000);

            if (Email.Text == "Teste" && Senha.Text == "123")
            {

                Application.Current.MainPage = new NavigationPage(new MainPage());
            }
            if  (Email.Text == "adm" && Senha.Text == "adm")
            {
                Application.Current.MainPage = new NavigationPage(new ViewAdm.Administrador());
            }
            else
            {
                await DisplayAlert("Erro", "Login Inválido, tente novamente", "OK");
            }



        }
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor = 5000);
        }

    }

 }



     
    
    