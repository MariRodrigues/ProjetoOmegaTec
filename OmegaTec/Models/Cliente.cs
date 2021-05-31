using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaTec.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public String NomeCliente { get; set; }
        public int Cnpj { get; set; }

        public String Endereco { get; set; }

        public String Telefone { get; set; }

    }
}
