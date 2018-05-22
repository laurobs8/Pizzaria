using System.Collections.Generic;
using System.Text;
using Pizzaria.DAL;
using Pizzaria.Modelos;

namespace Pizzaria.Controllers
{
    class ControllerEscolhaPizza
    {
        public FormaDeEntrega FormaDeEntrega { get; set; } = FormaDeEntrega.EntregaDomicilio;

        public FormaDePagamento FormaDePagamento { get; set; } = FormaDePagamento.Cartao;

        public Cliente Cliente { get; set;  }

        public List<ItemPedido> ItensPedido { get; } = new List<ItemPedido>();
        
        public ItemPedido ItemAtual { get; set; } = new ItemPedido();

        public bool Salvar()
        {
            return true;
        }

        public string ObterRecibo()
        {
            const string template = @"Pedido concluido com sucesso!

Itens do pedido:
{0}

Forma de pagamento: {1}

Forma de entrega: {2}

Dados do cliente: 
{3}";
            var itensBuilder = new StringBuilder();
            foreach (var item in ItensPedido)
            {
                itensBuilder.AppendLine(item.ToString());
            }

            return string.Format(template, itensBuilder.ToString(), FormaDePagamento.ToString(), FormaDeEntrega.ToString(), Cliente.ToString());

        }
    }
}
