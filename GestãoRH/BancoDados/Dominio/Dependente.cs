using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRH.BancoDados.Dominio
{
    internal class Dependente
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimentoDependente { get; set; }
        public string GeneroDependente { get; set; }
        public string Parentesco { get; set; }

    }
}
