using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class  Cliente
    {



        public int ID { get; set; }
        public string Nome { get; set; }
        public string datanascimento { get; set; }
        public string telefone { get; set; }
        public string Email { get; set; }
        public genero genero { get; set; }
        public EndereçoCliente endereço { get; set; }
        public string NomeSocial { get; set; }
        public Etinia_2 etinia{ get; set; }

        public  Estrangeiro_Cliente  Estrangeiro { get; set; }

        public  Tipocliente tipocliente { get; set; }


        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }
            if (string.IsNullOrEmpty(datanascimento))
            {
                return false;
            }
            if (string.IsNullOrEmpty(telefone))
            {
                return false;
            }
            if (string.IsNullOrEmpty(Email))
            {
                return false;
            }
            if (genero == 0)
            {
                return false;
            }
            if (endereço == null)
            {
                return false;
            }
            if (string.IsNullOrEmpty(NomeSocial))
            {
                return false;
            }
            if (etinia == 0)
            {
                return false;
            }
            if (Estrangeiro == 0)
            {
                return false;
            }
            if (tipocliente == 0)
            {
                return false;
            }
            return true;
        }


    }


}
