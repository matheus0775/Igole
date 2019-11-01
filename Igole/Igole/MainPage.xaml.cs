using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Igole
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cardapio());

        }

        private async void Promo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Promocao());

        }

        private async void Perfil_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfil());

        }

        private async void Pedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeuCarrinho());

        }
    }
}
