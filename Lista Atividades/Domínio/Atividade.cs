using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Atividades.Domínio
{


    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }


        private readonly AtividadeRepositorio repositorio = new();

        public bool Criar()
        {
               ValidarTitulo();
            if (!ValidarTitulo())
            {
                return false;
            }
            
           
                repositorio.Criar(Titulo);

            return true;

        }
        public bool Atualizarsituacao( )
        {
            if (!ValidarId())
            {
                return false;
            }
            if (!Validarsituacao())
            {
                return false;
            }

            Atividade atividadeEmAndamento = BuscarAtividadeEmAndamento();
            Situacao novasituacao = BuscarProximaSituacao();




            var atividadeAndamento = BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == BuscarProximaSituacao())
            {
                return false;
            }



            int novasituação = (int)BuscarProximaSituacao();
            
                                   
            repositorio.AtualizarSituacao(Id, (int) novasituacao);
            return true;
        }
        public Atividade BuscarAtividadeEmAndamento()
        {

            return repositorio.BuscarAtividadeEmAndamento();

        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return repositorio.ListarAtividadesPendentes();
        }
        private bool ValidarId() 
        {
            return Id > 0;

        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);


        }
        private bool Validarsituacao()
        {

            return Situacao != Situacao.Concluido;
        }
        private Situacao BuscarProximaSituacao() 
        {
            if (Situacao == Situacao.Pendente)
            {

                return Situacao.Realizando;
            }
        
            return Situacao.Concluido;
        }

    }





}
