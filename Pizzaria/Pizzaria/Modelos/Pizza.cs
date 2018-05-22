using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Modelos
{
    class Pizza
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return $"{Nome} R$ {Preco}";
        }
    }
}
