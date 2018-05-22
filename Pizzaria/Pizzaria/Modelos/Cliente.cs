using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
            => $@"Nome: {Nome}
Endereço: {Endereco}
Telefone: {Telefone}";
    }
}
