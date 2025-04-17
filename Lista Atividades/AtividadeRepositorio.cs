using Lista_Atividades.Banco_de_Dados;
using Lista_Atividades.Domínio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Atividades
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var con = Database.GetConnection())
            {

                con.Open();

                string query = "INSERT INTO atividade (titulo) VALUES  (@titulo);";

                using (var cmd = new MySqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@titulo", titulo);

                    cmd.ExecuteNonQuery();

                }

            }


        }
        public void AtualizarSituacao(int id, int novaSituação)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = "UPDATE atividade SET situacao = @Situacao WHERE id = @id;";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Situacao", novaSituação);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }








            }

        }
        public Atividade BuscarAtividadeEmAndamento()
        {

            using (var con = Database.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = {(int) Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Atividade
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")



                            };
                        }
                    }
                }
            }

            return new Atividade();

        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            List<Atividade> atividades = new List<Atividade>();

            using (var con = Database.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = {(int) Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade
                            {
                                Id = reader.GetInt32("Id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            });
                        }
                    }
                }
            }

            return atividades;




        }
    }
}

        
    
       
    


