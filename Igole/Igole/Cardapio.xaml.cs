using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igole.Service;
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
            LvCardapio.ItemsSource = _service.GetCardapios();
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Blue;
            //((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;

        }
    }
}