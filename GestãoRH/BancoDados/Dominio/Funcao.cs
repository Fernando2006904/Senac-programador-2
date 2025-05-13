using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRH.BancoDados.Dominio
{
    internal class Funcao
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
    }
}
