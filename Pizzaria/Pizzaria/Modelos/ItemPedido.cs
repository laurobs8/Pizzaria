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
        public Tamanhos TamanhoPizza { get; set; }
        public Pizza Pizza { get; set; } = new Pizza();

        public override string ToString()
        {
            var plural = QuantidadePizza > 1 ? "s" : "";
            return $"{QuantidadePizza} pizza{plural} de {Pizza.Nome} {TamanhoPizza.ToString()}{plural}";
        }
    }
}
