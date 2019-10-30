using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Igole.Model
{
    class ModCardapio
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String ImagemUrl { get; set; }

        public String Real { get; set; }
        public decimal Valor { get; set; }
    }
}
