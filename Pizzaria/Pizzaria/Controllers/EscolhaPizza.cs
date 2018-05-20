using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Modelos;

namespace Pizzaria.Controllers
{
    class ControllerEscolhaPizza
    {
        public FormaDeEntrega FormaDeEntrega { get; set; } = FormaDeEntrega.EntregaDomicilio;
        public FormaDePagamento FormaDePagamento { get; set; } = FormaDePagamento.Cartao;
        public Cliente Cliente { get; }
        public List<ItemPedido> ItensPedido { get; } = new List<ItemPedido>();
        public bool Salvar()
        {
            return true;
        }
    }
}
