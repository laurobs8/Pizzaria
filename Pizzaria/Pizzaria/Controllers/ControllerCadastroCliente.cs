using Pizzaria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controllers
{
    class ControllerCadastroCliente
    {
        public Cliente Cliente { get; set; } = new Cliente();

        public bool SalvarCliente()
        {
            if (string.IsNullOrWhiteSpace(Cliente.Nome)    ||
                string.IsNullOrWhiteSpace(Cliente.Endereco) ||
                string.IsNullOrWhiteSpace(Cliente.Telefone))
            {
                return false;
            }

            return true;

        }
    }
}
