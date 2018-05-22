using Pizzaria.DAL;
using Pizzaria.Modelos;
using System;

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

            try
            {
                Database.SalvarCliente(Cliente);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }
    }
}
