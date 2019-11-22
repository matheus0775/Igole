using Igole.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Igole.ViewModel
{
    public class ContasViewModel : INotifyPropertyChanged
    {
        private Server _conexao;
        public List<ModCardapio> Cardapio { get { return _cardapios; } set { _cardapios = value; OnPropertyChanged(); } }

        public List<ModCardapio> _cardapios { get; set; }

        public ModCardapio _cardapio { get; set; }

        public ModCardapio ModCardapio { get { return _cardapio; } set { _cardapio = value; OnPropertyChanged(); } }

        public Command ButtonCommand { get; set; }

        public ContasViewModel()
        {
            _conexao = new Server();
            IniciaDados();

            ButtonCommand = new Command(ExecuteButton, CanExecuteButton);



 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void IniciaDados()
        {
            Cardapio = _conexao.GetAll().ToList();


            ModCardapio = new ModCardapio();

        }

        public void Excluir(ModCardapio cardapio)
        {
            _conexao.Delete(cardapio);
        }

        private bool CanExecuteButton()
        {
            return true;
        }

        private void ExecuteButton()
        {
            if (ModCardapio.Id >= 1)
            {
                _conexao.Update(ModCardapio);
                App.Current.MainPage.DisplayAlert("Produto", "Alterado com sucesso", "Ok");

            }
            else
            {
                _conexao.Add(ModCardapio);
                App.Current.MainPage.DisplayAlert("Produto", "Cadastro com sucesso", "Ok");
            }
            IniciaDados();
        }
    }
}
