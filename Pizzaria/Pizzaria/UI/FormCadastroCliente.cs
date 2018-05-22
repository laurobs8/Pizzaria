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
    public partial class FormPizzaria : Form
    {
        private readonly ControllerCadastroCliente controller = new ControllerCadastroCliente();

        public FormPizzaria()
        {
            InitializeComponent();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            var sucesso = controller.SalvarCliente();
            if (sucesso)
            {
                var form = new FormEscolhaPizza(controller.Cliente);
                form.Show();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao salvar");
            }
        }

        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {
            controller.Cliente.Nome = TextBoxNome.Text;
        }

        private void TextBoxEndereco_TextChanged(object sender, EventArgs e)
        {
            controller.Cliente.Endereco = TextBoxEndereco.Text;
        }

        private void TextBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            controller.Cliente.Telefone = TextBoxTelefone.Text;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
