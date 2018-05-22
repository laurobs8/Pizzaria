using Pizzaria.Controllers;
using Pizzaria.DAL;
using Pizzaria.Modelos;
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
        private readonly ControllerEscolhaPizza controller;
 
        public FormEscolhaPizza(Cliente cliente)
        {
            InitializeComponent();

            controller = new ControllerEscolhaPizza();
            controller.Cliente = cliente;
            InicializarEstado();
        }

        private void InicializarEstado()
        {
            RadioEntregaLocal.Checked = true;
            DropDownTamanho.SelectedIndex = 0;
            RadioPagamentoDinheiro.Checked = true;
            ListViewItensPedido.Columns.Add("Items");
            ListViewItensPedido.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            ListViewItensPedido.Columns[0].Width = 70;
            ListViewItensPedido.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            var pizzas = Database.ObterListaDePizzas();
            ComboBoxPizza.DataSource = pizzas;
            
            atualizarListView();
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
            controller.ItensPedido.Add(controller.ItemAtual);
            controller.ItemAtual = new ItemPedido();

            atualizarListView();
        }

        private void DropDownTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.ItemAtual.TamanhoPizza = (Tamanhos)DropDownTamanho.SelectedIndex;
        }

        private void ComboBoxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.ItemAtual.Pizza = ComboBoxPizza.SelectedItem as Pizza;
        }

        private void UpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            controller.ItemAtual.QuantidadePizza = (int)UpDownQuantidade.Value;
        }

        private void atualizarListView()
        {
            ListViewItensPedido.Items.Clear();

            foreach (var itemPedido in controller.ItensPedido)
            {
                ListViewItensPedido.Items.Add(itemPedido.ToString());
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            var sucesso = controller.Salvar();
            if (sucesso)
            {
                var recibo = controller.ObterRecibo();
                MessageBox.Show(recibo);
            }
            else
            {
                MessageBox.Show("Erro ao processar a sua requisição. Tente novamente mais tarde.");
            }
        }
    }
}
