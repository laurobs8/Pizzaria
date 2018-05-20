using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Modelos
{
    class ItemPedido
    {
        public int QuantidadePizza { get; set; }
        public Pizza Pizza { get; set; }
        public Tamanhos TamanhoPizza { get; set; }
    }
}
