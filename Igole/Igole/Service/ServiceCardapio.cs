using System;
using System.Collections.Generic;
using System.Text;
using Igole.Model;

namespace Igole.Service
{
    class ServiceCardapio
    {
        private List<ModCardapio> Cardapios = new List<ModCardapio>
        {
            new ModCardapio { Nome="Guarana", Descricao="Refrigerante 2 litros", ImagemUrl="Cardapio.png", Real="Valor R$", Valor= 10.00M },
            new ModCardapio { Nome="CocaCoca", Descricao="Refrigerante 2 litros", ImagemUrl="Cardapio.png", Real="Valor R$", Valor=10.00M },
            new ModCardapio { Nome="Pepsi", Descricao="Refrigerante 2 litros", ImagemUrl="Cardapio.png", Real="Valor R$", Valor=10.00M }
        };
        public IEnumerable<ModCardapio> GetCardapios()
        {
            return Cardapios;
        }
    }
}
