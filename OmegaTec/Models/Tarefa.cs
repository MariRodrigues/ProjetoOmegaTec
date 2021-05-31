using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaTec.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }
        public int ClienteId { get; set; }

        public Cliente NomeCliente { get; set; }

        public String Descricao { get; set; }

        public int Prioridade { get; set; }
    }
}
