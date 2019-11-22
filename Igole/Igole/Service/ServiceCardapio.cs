using System;
using System.Collections.Generic;
using System.Text;
using Igole.Model;
using Igole.ViewModel;
using Newtonsoft;

namespace Igole.Service
{
   
  public  class ServiceCardapio
    {
        private List<ModCardapio> Cardapios = new List<ModCardapio>
        {
            new ModCardapio { nameProduct="Guarana", description="Refrigerante 2 litros", image="Cardapio.png", Real="Valor R$", price= "10.00" }
            //new ModCardapio { nameProduct="CocaCoca", description="Refrigerante 2 litros", image="Cardapio.png",tag="A", amountVolume="2", stock="7", volumeType="A", category="1", subCategory="2", Real="Valor R$", price="10.00M" },
            //new ModCardapio { nameProduct="Pepsi", description="Refrigerante 2 litros", image="Cardapio.png", tag="A", amountVolume="2", stock="7", volumeType="A", category="1", subCategory="2", Real="Valor R$", price="10.00M" }


    };


        public IEnumerable<ModCardapio> GetCardapios()
        {

            return Cardapios;

        }


        

   }


}



//{
//contasViewModel.IniciaDados();
//contasViewModel.Cardapio = new List<Model.ModCardapio>(contasViewModel.Cardapio);
//    }
//else
//{
// contasViewModel.Cardapio = e.Item as Model.ModCardapio;
//}
//};
