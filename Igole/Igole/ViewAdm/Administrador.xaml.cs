using Igole.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Igole.ViewAdm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Administrador : ContentPage
    {
        public Administrador()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            ContasViewModel contasViewModel = new ContasViewModel();
            this.BindingContext = contasViewModel;


            contasViewModel.IniciaDados();

            LvCardapio.ItemsSource = new List<Model.ModCardapio>(contasViewModel.Cardapio);

            this.LvCardapio.ItemTapped += async (sender, e) =>
            {
                var message = await DisplayAlert("Message", "Qual operação Deseja realizar", "Excluir", "Editar");
                if (message)
                {
                    contasViewModel.Excluir(e.Item as Model.ModCardapio);
                    contasViewModel.IniciaDados();
                    contasViewModel.Cardapio = new List<Model.ModCardapio>(contasViewModel.Cardapio);
                }
                else
                {
                    contasViewModel.ModCardapio = e.Item as Model.ModCardapio;
                }
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}