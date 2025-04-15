using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Atividades.Domínio
{
    
    
        internal class Atividade
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public Situação Situacao { get; set; }
        }

    
}
