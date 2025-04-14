using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class Cliente
    {



        public int ID { get; set; }
        public string Nome { get; set; }
        public string datanascimento { get; set; }
        public string telefone { get; set; }
        public string Email { get; set; }
        public genero genero { get; set; }
        public EndereçoCliente endereço { get; set; }
        public string NomeSocial { get; set; }
        
        public Estrangeiro_Cliente Estrangeiro { get; set; }

        

        
         
        




        
        

    }


}
