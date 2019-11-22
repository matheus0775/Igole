using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igole.Service;
using Igole.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Igole
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cardapio : ContentPage
    {
        private ServiceCardapio _service = new ServiceCardapio();

        public Cardapio()
        {
            InitializeComponent();
            ContasViewModel contasViewModel = new ContasViewModel();
            this.BindingContext = contasViewModel;

         
            contasViewModel.IniciaDados();

            LvCardapio.ItemsSource = new List<Model.ModCardapio>(contasViewModel.Cardapio);


            //LvCardapio.ItemsSource = _service.GetCardapios();

            //contasViewModel.Cardapio = new List<Model.ModCardapio>(contasViewModel.Cardapio);

            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Blue;
            //((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }
    }
}


//contasViewModel.IniciaDados();
//contasViewModel.Cardapio = new List<Model.ModCardapio>(contasViewModel.Cardapio);
//    }
//else
//{
// contasViewModel.Cardapio = e.Item as Model.ModCardapio;
//}
//};


