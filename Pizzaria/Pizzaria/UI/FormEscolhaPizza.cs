using Pizzaria.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizzaria.UI
{

    public partial class FormEscolhaPizza : Form
    
    {
        private readonly ControllerEscolhaPizza controller = new ControllerEscolhaPizza();

        public FormEscolhaPizza()
        {
            InitializeComponent();
            ListViewItensPedido.Columns.Add("Pizza", 100);
            ListViewItensPedido.Columns.Add("Quantidade", 100);
            ListViewItensPedido.Columns.Add("Tamanho", 100);
        }

        private void RadioPagamentoDinheiro_CheckedChanged(object sender, EventArgs e)
        { 
            controller.FormaDePagamento = Modelos.FormaDePagamento.Dinheiro;
        }

        private void RadioPagamentoCartao_CheckedChanged(object sender, EventArgs e)
        {
         controller.FormaDePagamento = Modelos.FormaDePagamento.Cartao;

        }

        private void RadioEntregaLocal_CheckedChanged(object sender, EventArgs e)
        {
            controller.FormaDeEntrega = Modelos.FormaDeEntrega.BuscarPizzaria;
        }

        private void RadioEntregaResidencia_CheckedChanged(object sender, EventArgs e)
        {
            controller.FormaDeEntrega = Modelos.FormaDeEntrega.EntregaDomicilio;
        }

        private void AdicionarPedido_Click(object sender, EventArgs e)
        {
            


            var arr = new[]
            {
    "Mussarela", "2", "Grande"
};

            var item = new ListViewItem(arr);
            ListViewItensPedido.Items.Add(item);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
